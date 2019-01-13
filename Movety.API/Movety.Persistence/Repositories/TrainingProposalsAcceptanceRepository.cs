using System;
using System.Collections.Generic;
using System.Linq;
using Movety.Persistence.DAO;
using Movety.Persistence.DbContexts;
using Movety.Persistence.Repositories.Interfaces;

namespace Movety.Persistence.Repositories
{
    public class TrainingProposalsAcceptanceRepository : ITrainingProposalsAcceptanceRepository
    {
        private readonly TrainingsDbContext _context;

        public TrainingProposalsAcceptanceRepository(TrainingsDbContext context)
        {
            _context = context;
        }

        public void Add(TrainingProposalsAcceptance acceptance)
        {
            _context.TrainingProposalsAcceptances.Add(acceptance);
        }

        public IEnumerable<TrainingProposalsAcceptance> Find(Func<TrainingProposalsAcceptance, bool> predicate)
        {
            return _context.TrainingProposalsAcceptances.Where(predicate);
        }
    }
}