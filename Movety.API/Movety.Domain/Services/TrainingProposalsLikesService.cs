using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Movety.Domain.Entities;
using Movety.Domain.Exceptions;
using Movety.Domain.Services.Interfaces;
using Movety.Persistence.Repositories.Interfaces;

namespace Movety.Domain.Services
{
    public class TrainingProposalsLikesService : ITrainingProposalsLikesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TrainingProposalsLikesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<TrainingProposalLikes> GetAll()
        {
            List<TrainingProposalLikes> trainingProposalsLikes = new List<TrainingProposalLikes>();
            var trainingProposalsLikesDAO = _unitOfWork.TrainingProposalsLikes.GetAll();
            var groupOfTrainingProposalIds = trainingProposalsLikesDAO.GroupBy(x => x.TrainingProposalsId);
            foreach (var trainingProposalId in groupOfTrainingProposalIds)
            {
                var trainingProposalsLike = new TrainingProposalLikes {TrainingProposalId = trainingProposalId.Key};
                List<Athlethe> athletes = new List<Athlethe>();
                foreach (var likeDAO in trainingProposalsLikesDAO.Where(x => x.TrainingProposalsId == trainingProposalId.Key))
                {
                    var athleteDAO = _unitOfWork.Athletes.Get(likeDAO.UserId);
                    var athlete = _mapper.Map<Athlethe>(athleteDAO);
                    athletes.Add(athlete);
                }

                trainingProposalsLike.Athletes = athletes;
                trainingProposalsLikes.Add(trainingProposalsLike);
            }

            return trainingProposalsLikes;
        }

        public TrainingProposalLikes GetByTrainingProposalId(Guid id)
        {
            TrainingProposalLikes trainingProposalsLike = new TrainingProposalLikes
                {TrainingProposalId = id};

            List<Athlethe> athletes = new List<Athlethe>();
            var trainingProposalsLikesDAO = _unitOfWork.TrainingProposalsLikes.GetByTrainingProposalId(id);

            if (!trainingProposalsLikesDAO.Any())
            {
                return null;
            }

            foreach (var like in trainingProposalsLikesDAO)
            {
                var athleteDAO = _unitOfWork.Athletes.Get(like.UserId);
                var athlete = _mapper.Map<Athlethe>(athleteDAO);
                athletes.Add(athlete);
            }

            trainingProposalsLike.Athletes = athletes;

            return trainingProposalsLike;
        }

        public IEnumerable<TrainingProposal> GetLikedTrainingProposalsByUserId(Guid id)
        {
            List<TrainingProposal> trainingProposals = new List<TrainingProposal>();
            var trainingProposalsLikesDAO = _unitOfWork.TrainingProposalsLikes.Find(x => x.UserId == id);
            foreach (var like in trainingProposalsLikesDAO)
            {
                var trainingProposalDAO = _unitOfWork.TrainingProposals.Get(like.TrainingProposalsId);
                trainingProposals.Add(_mapper.Map<TrainingProposal>(trainingProposalDAO));
            }

            return trainingProposals;
        }
    }
}