using System;
using System.Collections.Generic;

namespace Movety.API.DTO.Output
{
    public class TrainingProposalsLikedByUser
    {
        public Guid UserId { get; set; }
        public IEnumerable<TrainingProposalResponse> TrainingProposals { get; set; }
    }
}