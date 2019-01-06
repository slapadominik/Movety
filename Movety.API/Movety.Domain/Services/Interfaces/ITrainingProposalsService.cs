using System;
using System.Collections.Generic;
using Movety.Domain.Entities;

namespace Movety.Domain.Services.Interfaces
{
    public interface ITrainingProposalsService
    {
        TrainingProposal Get(Guid id);
        IEnumerable<TrainingProposal> GetAll();
        IEnumerable<TrainingProposal> GetNewTrainingProposalsForUser(Guid id);
    }
}