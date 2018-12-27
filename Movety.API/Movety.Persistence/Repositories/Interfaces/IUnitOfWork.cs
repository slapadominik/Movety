﻿using System;

namespace Movety.Persistence.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ILocationRepository Locations { get; }
        ISportFieldRepository SportFields { get; }
        ITrainingProposalsRepository TrainingProposals { get; }
        int Complete();
    }
}