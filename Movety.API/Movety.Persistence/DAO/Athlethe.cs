using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movety.Persistence.DAO
{
    public class Athlethe : Entity<Guid>
    {
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public Guid UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string Description { get; set; }
    }
}