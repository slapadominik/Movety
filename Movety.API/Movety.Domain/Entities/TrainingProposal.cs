using System;

namespace Movety.Domain.Entities
{
    public class TrainingProposal
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Athlethe Author { get; set; }
        public SportField SportField { get; set; }
        public Location Location { get; set; }
        public DateTime DatetimeFrom { get; set; }
        public DateTime DatetimeTo { get; set; }
        public string Description { get; set; }
        public int MaxParticipants { get; set; }
    }
}