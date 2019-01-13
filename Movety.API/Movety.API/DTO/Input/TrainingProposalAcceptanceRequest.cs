using System;

namespace Movety.API.DTO.Input
{
    public class TrainingProposalAcceptanceRequest
    {
        public Guid RequesterId { get; set; }
        public TrainingProposalAcceptance TrainingProposalAcceptance { get; set; }
    }
}