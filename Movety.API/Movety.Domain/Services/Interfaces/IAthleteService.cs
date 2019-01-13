using System;
using System.Collections.Generic;
using Movety.Domain.Entities;

namespace Movety.Domain.Services.Interfaces
{
    public interface IAthleteService
    {
        IEnumerable<Athlethe> GetAll();
        Athlethe Get(Guid id);        
    }
}