using System;
using Movety.Persistence.DAO;

namespace Movety.Persistence.Repositories.Interfaces
{
    public interface ILocationRepository
    {
        void Add(Location location);
        Location Get(Guid id);
    }
}