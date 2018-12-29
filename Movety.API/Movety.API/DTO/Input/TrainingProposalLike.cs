using System;

namespace Movety.API.DTO.Input
{
    public class TrainingProposalLike
    {
        public Guid UserId { get; set; }
        public Guid TrainingProposalId { get; set; }
    }
}