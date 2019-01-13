using System;
using System.Collections.Generic;
using Movety.Persistence.DAO;

namespace Movety.Persistence.Repositories.Interfaces
{
    public interface IAthleteRepository
    {
        IEnumerable<Athlethe> GetAll();
        Athlethe Get(Guid userId);
    }
}