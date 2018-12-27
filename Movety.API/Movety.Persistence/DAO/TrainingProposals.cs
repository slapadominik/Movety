using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movety.Persistence.DAO
{
    public class TrainingProposals : Entity<Guid>
    {
        [ForeignKey(nameof(SportFieldId))]
        public SportField SportField { get; set; }        
        public int SportFieldId { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }

        [ForeignKey(nameof(LocationId))]
        public Location Location { get; set; }
        public Guid LocationId { get; set; }

        public DateTime DatetimeFrom { get; set; }
        public DateTime DatetimeTo { get; set; }       
        public string Description { get; set; }
        public int MaxParticipants { get; set; }

        public List<TrainingProposalsLikes> TrainingProposalsLikes { get; set; }
        public List<TrainingProposalsAcceptance> TrainingProposalsAcceptances { get; set; }
    }
}