using System;
using System.Collections.Generic;

namespace Movety.API.DTO.Output
{
    public class AcceptanceAthletesBriefs
    {
        public Guid TrainingProposalId { get; set; }
        public IList<AthleteBrief> Users { get; set; }
    }
}