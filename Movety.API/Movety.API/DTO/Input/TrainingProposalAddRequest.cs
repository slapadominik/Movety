using System;

namespace Movety.API.DTO.Input
{
    public class TrainingProposalAddRequest
    {
        public int SportFieldId { get; set; }
        public Location Location { get; set; }
        public DateTime DatetimeFrom { get; set; }
        public DateTime DatetimeTo { get; set; }
        public string Description { get; set; }
        public int MaxParticipants { get; set; }
    }
}