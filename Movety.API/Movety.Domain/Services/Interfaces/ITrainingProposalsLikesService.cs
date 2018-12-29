using System;
using System.Collections.Generic;
using Movety.Domain.Entities;

namespace Movety.Domain.Services.Interfaces
{
    public interface ITrainingProposalsLikesService
    {
        IEnumerable<TrainingProposalLikes> GetAll();
        TrainingProposalLikes GetByTrainingProposalId(Guid id);
        IEnumerable<TrainingProposal> GetLikedTrainingProposalsByUserId(Guid id);
        void Add(Guid userId, Guid trainingProposalId);
    }
}