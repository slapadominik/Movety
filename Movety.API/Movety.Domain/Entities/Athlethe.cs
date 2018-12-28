using System;

namespace Movety.Domain.Entities
{
    public class Athlethe
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string Description { get; set; }
    }
}