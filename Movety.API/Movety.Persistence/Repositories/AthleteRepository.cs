using System;
using System.Linq;
using Movety.Persistence.DAO;
using Movety.Persistence.DbContexts;
using Movety.Persistence.Repositories.Interfaces;

namespace Movety.Persistence.Repositories
{
    public class AthleteRepository : IAthleteRepository
    {
        private readonly TrainingsDbContext _context;

        public AthleteRepository(TrainingsDbContext context)
        {
            _context = context;
        }

        public Athlethe Get(Guid userId)
        {
            return _context.Athlethes.SingleOrDefault(x => x.UserId == userId);
        }
    }
}