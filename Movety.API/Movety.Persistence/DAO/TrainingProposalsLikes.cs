using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movety.Persistence.DAO
{
    public class TrainingProposalsLikes
    {
        [ForeignKey(nameof(TrainingProposalsId))]
        public TrainingProposals TrainingProposals { get; set; }
        public Guid TrainingProposalsId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public Guid UserId { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Modified { get; set; }
    }
}