using System;

namespace Movety.API.DTO.Output
{
    public class TrainingProposalResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public SportField SportField { get; set; }
        public Location Location { get; set; }
        public DateTime DatetimeFrom { get; set; }
        public DateTime DatetimeTo { get; set; }
        public string Description { get; set; }
        public int MaxParticipants { get; set; }
    }
}