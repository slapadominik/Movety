using System.Linq;
using Movety.Persistence.DAO;
using Movety.Persistence.DbContexts;
using Movety.Persistence.Repositories.Interfaces;

namespace Movety.Persistence.Repositories
{
    public class SportFieldRepository : ISportFieldRepository
    {
        private readonly TrainingsDbContext _context;

        public SportFieldRepository(TrainingsDbContext context)
        {
            _context = context;
        }

        public SportField Get(int id)
        {
            return _context.SportFields.SingleOrDefault(x => x.Id == id);
        }
    }
}