using System;
using Movety.Persistence.DAO;

namespace Movety.Persistence.Repositories.Interfaces
{
    public interface ILocationRepository
    {
        Location Get(Guid id);
    }
}