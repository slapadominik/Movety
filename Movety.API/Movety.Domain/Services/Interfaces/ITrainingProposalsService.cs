using System;
using System.Collections.Generic;
using Movety.Domain.Entities;

namespace Movety.Domain.Services.Interfaces
{
    public interface ITrainingProposalsService
    {
        void Add(TrainingProposal trainingProposal);

        TrainingProposal Get(Guid id);
        IEnumerable<TrainingProposal> GetAll();
        IEnumerable<TrainingProposal> Find(Func<TrainingProposal, bool> predicate);

        void Remove(TrainingProposal trainingProposals);
    }
}