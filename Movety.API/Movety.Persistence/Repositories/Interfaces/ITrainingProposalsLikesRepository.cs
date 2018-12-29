using System;
using System.Collections.Generic;
using Movety.Persistence.DAO;

namespace Movety.Persistence.Repositories.Interfaces
{
    public interface ITrainingProposalsLikesRepository
    {
        void Add(TrainingProposalsLikes trainingProposalsLikes);
        IEnumerable<TrainingProposalsLikes> GetAll();
        IEnumerable<TrainingProposalsLikes> Find(Func<TrainingProposalsLikes, bool> predicate);
        IEnumerable<TrainingProposalsLikes> GetByTrainingProposalId(Guid id);
    }
}