using System;
using System.Collections.Generic;
using AutoMapper;
using Movety.Domain.Entities;
using Movety.Domain.Exceptions;
using Movety.Domain.Services.Interfaces;
using Movety.Persistence.Repositories.Interfaces;
using Location = Movety.Domain.Entities.Location;
using SportField = Movety.Domain.Entities.SportField;

namespace Movety.Domain.Services
{
    public class TrainingProposalsService : ITrainingProposalsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TrainingProposalsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(TrainingProposal trainingProposal)
        {
            var trainingProposalDAO = _mapper.Map<Persistence.DAO.TrainingProposals>(trainingProposal);
            _unitOfWork.TrainingProposals.Add(trainingProposalDAO);
            _unitOfWork.Complete();
        }

        public TrainingProposal Get(Guid id)
        {
            var trainingProposalDAO = _unitOfWork.TrainingProposals.Get(id);
            if (trainingProposalDAO == null)
            {
                throw new TrainingProposalNotFoundException($"Nie istnieje propozycja treningowa o podanym ID");
            }
            var sportFieldDAO = _unitOfWork.SportFields.Get(trainingProposalDAO.SportFieldId);
            if (sportFieldDAO == null)
            {
                throw new SportFieldNotFoundException($"Nie istnieje dziedzina sportowa o podanym ID");
            }

            var locationDAO = _unitOfWork.Locations.Get(trainingProposalDAO.LocationId);
            if (locationDAO == null)
            {
                throw new LocationNotFoundException($"Nie istnieje lokalizacja o podanym ID");
            }

            var trainingProposal = _mapper.Map<TrainingProposal>(trainingProposalDAO);
            var sportField = _mapper.Map<SportField>(sportFieldDAO);
            var location = _mapper.Map<Location>(locationDAO);

            trainingProposal.SportField = sportField;
            trainingProposal.Location = location;

            return trainingProposal;
        }

        public IEnumerable<TrainingProposal> GetAll()
        {
            List<TrainingProposal> trainingProposals = new List<TrainingProposal>();
            var trainingProposalsDAO = _unitOfWork.TrainingProposals.GetAll();

            foreach (var trainingProposalDAO in trainingProposalsDAO)
            {
                var trainingProposal = _mapper.Map<TrainingProposal>(trainingProposalDAO);
                trainingProposal.SportField = _mapper.Map<SportField>(_unitOfWork.SportFields.Get(trainingProposalDAO.SportFieldId));
                trainingProposal.Location = _mapper.Map<Location>(_unitOfWork.Locations.Get(trainingProposalDAO.LocationId));
                trainingProposals.Add(trainingProposal);
            }

            return trainingProposals;
        }

        public IEnumerable<TrainingProposal> Find(Func<TrainingProposal, bool> predicate)
        {
            //return _unitOfWork.TrainingProposals.Find(predicate);
            return null;
        }

        public void Remove(TrainingProposal trainingProposals)
        {
            //_unitOfWork.TrainingProposals.Remove(trainingProposals);
            _unitOfWork.Complete();
        }
    }
}