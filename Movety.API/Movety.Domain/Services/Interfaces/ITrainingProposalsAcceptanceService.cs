using System;
using System.Collections.Generic;
using Movety.Domain.Entities;

namespace Movety.Domain.Services.Interfaces
{
    public interface ITrainingProposalsAcceptanceService
    {
        void Add(Guid requesterId, TrainingProposalAcceptance acceptance);
        IEnumerable<TrainingProposalAcceptance > GetByTrainingProposalId(Guid id);
    }
}