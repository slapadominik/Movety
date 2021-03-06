﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Movety.Domain.Entities;
using Movety.Domain.Exceptions;
using Movety.Domain.Services.Interfaces;
using Movety.Persistence.DAO;
using Movety.Persistence.Repositories.Interfaces;
using Athlethe = Movety.Domain.Entities.Athlethe;
using Location = Movety.Domain.Entities.Location;
using SportField = Movety.Domain.Entities.SportField;

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
                var trainingProposal = _mapper.Map<TrainingProposal>(trainingProposalDAO);
                trainingProposal.SportField = _mapper.Map<SportField>(_unitOfWork.SportFields.Get(trainingProposalDAO.SportFieldId));
                trainingProposal.Location = _mapper.Map<Location>(_unitOfWork.Locations.Get(trainingProposalDAO.LocationId));

                if (trainingProposalDAO.AuthorId.HasValue)
                {
                    Movety.Persistence.DAO.Athlethe authorDAO = _unitOfWork.Athletes.Get(trainingProposalDAO.AuthorId.Value);
                    trainingProposal.Author = _mapper.Map<Athlethe>(authorDAO);
                }
                trainingProposals.Add(trainingProposal);
            }

            return trainingProposals;
        }

        public void Add(Guid userId, Guid trainingProposalId)
        {
            if (_unitOfWork.Athletes.Get(userId) == null)
            {
                throw new UserNotFoundException();
            }

            if (_unitOfWork.TrainingProposals.Get(trainingProposalId) == null)
            {
                throw new TrainingProposalNotFoundException();
            }

            TrainingProposalsLikes trainingProposalsLikes = new TrainingProposalsLikes
                {TrainingProposalsId = trainingProposalId, UserId = userId, Created = DateTime.Now};
            _unitOfWork.TrainingProposalsLikes.Add(trainingProposalsLikes);
            if (_unitOfWork.Complete() != 1)
            {
                throw new InvalidOperationException();
            }
        }
    }
}