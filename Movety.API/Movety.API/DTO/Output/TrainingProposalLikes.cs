using System;
using System.Collections.Generic;

namespace Movety.API.DTO.Output
{
    public class TrainingProposalLikes
    {
        public Guid TrainingProposalId { get; set; }
        public IEnumerable<AthleteBrief> AthletesBrief { get; set; }
    }
}