using System;

namespace Movety.Domain.Entities
{
    public class TrainingProposalAcceptance
    {
        public Guid TrainingProposalId { get; set; }
        public Guid UserId { get; set; }
    }
}