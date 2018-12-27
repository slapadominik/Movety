using System;
using System.Collections.Generic;

namespace Movety.Persistence.DAO
{
    public class User : Entity<Guid>
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }        
        public string SecurityStamp { get; set; }

        public List<TrainingProposalsLikes> TrainingProposalsLikes { get; set; }
        public List<TrainingProposalsAcceptance> TrainingProposalsAcceptances { get; set; }
    }
}