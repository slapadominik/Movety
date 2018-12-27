using System;
using System.Linq;
using Movety.Persistence.DAO;
using Movety.Persistence.DbContexts;
using Movety.Persistence.Repositories.Interfaces;

namespace Movety.Persistence.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly TrainingsDbContext _context;

        public LocationRepository(TrainingsDbContext context)
        {
            _context = context;
        }

        public void Add(Location location)
        {
            throw new NotImplementedException();
        }

        public Location Get(Guid id)
        {
            return _context.Locations.SingleOrDefault(x => x.Id == id);
        }
    }
}