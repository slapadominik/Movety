using System;
using System.Collections.Generic;
using Movety.Persistence.DAO;

namespace Movety.Persistence.Repositories.Interfaces
{
    public interface ITrainingProposalsAcceptanceRepository
    {
        void Add(TrainingProposalsAcceptance acceptance);
        IEnumerable<TrainingProposalsAcceptance> Find(Func<TrainingProposalsAcceptance, bool> predicate);
    }
}