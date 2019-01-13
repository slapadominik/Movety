using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Movety.Domain.Entities;
using Movety.Domain.Exceptions;
using Movety.Domain.Services.Interfaces;
using Movety.Persistence.DAO;
using Movety.Persistence.Repositories.Interfaces;

namespace Movety.Domain.Services
{
    public class TrainingProposalsAcceptanceService : ITrainingProposalsAcceptanceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TrainingProposalsAcceptanceService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(Guid requesterId, TrainingProposalAcceptance acceptance)
        {
            var userDAO = _unitOfWork.Athletes.Get(acceptance.UserId);
            if (userDAO == null)
            {
                throw new UserNotFoundException();
            }
            var trainingProposal = _unitOfWork.TrainingProposals.Get(acceptance.TrainingProposalId);
            if (trainingProposal == null)
            {
                throw new TrainingProposalNotFoundException();
            }

            if (trainingProposal.AuthorId != requesterId)
            {
                throw new AcceptanceAuthorizationException($"User {acceptance.UserId} is not author of training proposal {acceptance.TrainingProposalId}");
            }

            if (!_unitOfWork.TrainingProposalsLikes.Find(x =>
                x.TrainingProposalsId == acceptance.TrainingProposalId && x.UserId == acceptance.UserId).Any())
            {
                throw new TrainingProposalLikeNotFoundException($"User {acceptance.UserId} didn't like training proposal {acceptance.TrainingProposalId}");
            }

            var likes = _unitOfWork.TrainingProposalsLikes.Find(x =>
                x.TrainingProposalsId == acceptance.TrainingProposalId);

            if (trainingProposal.MaxParticipants == likes.Count())
            {
                throw new MaxParticipantsException($"Training proposal already has max participants.");
            }


            Movety.Persistence.DAO.TrainingProposalsAcceptance acceptanceDAO = new TrainingProposalsAcceptance
            {
                TrainingProposalsId = acceptance.TrainingProposalId, UserId = acceptance.UserId, Created = DateTime.Now
            };

            _unitOfWork.Acceptances.Add(acceptanceDAO);

            if (_unitOfWork.Complete() < 1)
            {
                throw new InvalidOperationException();
            }
        }

        public IEnumerable<TrainingProposalAcceptance> GetByTrainingProposalId(Guid id)
        {
            var acceptancesDAO = _unitOfWork.Acceptances.Find(x => x.TrainingProposalsId == id);
            var acceptances = _mapper.Map<IEnumerable<Domain.Entities.TrainingProposalAcceptance>>(acceptancesDAO);
            return acceptances;
        }
    }
}