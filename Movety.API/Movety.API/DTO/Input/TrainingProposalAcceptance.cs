using System;

namespace Movety.API.DTO.Input
{
    public class TrainingProposalAcceptance
    {
        public Guid UserId { get; set; }
        public Guid TrainingProposalId { get; set; }
    }
}