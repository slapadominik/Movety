using System;
using System.Collections;
using System.Collections.Generic;
using Movety.Persistence.DAO;

namespace Movety.Persistence.Repositories.Interfaces
{
    public interface ITrainingProposalsRepository
    {
        void Add(TrainingProposals trainingProposal);

        TrainingProposals Get(Guid id);
        IEnumerable<TrainingProposals> GetAll();
        IEnumerable<TrainingProposals> Find(Func<TrainingProposals, bool> predicate);

        void Remove(TrainingProposals trainingProposals);        
    }
}