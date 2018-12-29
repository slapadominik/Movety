using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Movety.Persistence.DAO;
using Movety.Persistence.DbContexts;
using Movety.Persistence.Repositories.Interfaces;

namespace Movety.Persistence.Repositories
{
    public class TrainingProposalsLikesRepository : ITrainingProposalsLikesRepository
    {
        private readonly TrainingsDbContext _context;

        public TrainingProposalsLikesRepository(TrainingsDbContext context)
        {
            _context = context;
        }

        public void Add(TrainingProposalsLikes trainingProposalsLikes)
        {
            _context.TrainingProposalsLikes.Add(trainingProposalsLikes);
        }

        public IEnumerable<TrainingProposalsLikes> GetAll()
        {
            return _context.TrainingProposalsLikes.ToList();
        }

        public IEnumerable<TrainingProposalsLikes> Find(Func<TrainingProposalsLikes, bool> predicate)
        {
            return _context.TrainingProposalsLikes.Where(predicate);
        }

        public IEnumerable<TrainingProposalsLikes> GetByTrainingProposalId(Guid id)
        {
            return _context.TrainingProposalsLikes.Where(x => x.TrainingProposalsId == id);
        }
    }
}