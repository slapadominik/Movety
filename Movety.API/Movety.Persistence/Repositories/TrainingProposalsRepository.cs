using System;
using System.Collections.Generic;
using System.Linq;
using Movety.Persistence.DAO;
using Movety.Persistence.DbContexts;
using Movety.Persistence.Repositories.Interfaces;

namespace Movety.Persistence.Repositories
{
    public class TrainingProposalsRepository : ITrainingProposalsRepository
    {
        private readonly TrainingsDbContext _context;

        public TrainingProposalsRepository(TrainingsDbContext context)
        {
            _context = context;
        }

        public void Add(TrainingProposals trainingProposal)
        {
            throw new NotImplementedException();
        }

        public TrainingProposals Get(Guid id)
        {
            return _context.TrainingProposals.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<TrainingProposals> GetAll()
        {
            return _context.TrainingProposals.ToList();
        }

        public IEnumerable<TrainingProposals> Find(Func<TrainingProposals, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(TrainingProposals trainingProposals)
        {
            throw new NotImplementedException();
        }
    }
}