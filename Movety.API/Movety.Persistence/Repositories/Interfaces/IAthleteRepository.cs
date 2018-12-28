using System;
using Movety.Persistence.DAO;

namespace Movety.Persistence.Repositories.Interfaces
{
    public interface IAthleteRepository
    {
        Athlethe Get(Guid userId);
    }
}