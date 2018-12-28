using System;
using System.Collections.Generic;

namespace Movety.Domain.Entities
{
    public class TrainingProposalLikes
    {
        public Guid TrainingProposalId { get; set; }
        public IEnumerable<Athlethe> Athletes { get; set; }
    }
}