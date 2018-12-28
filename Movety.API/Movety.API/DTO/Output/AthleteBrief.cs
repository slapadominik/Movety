using System;

namespace Movety.API.DTO.Output
{
    public class AthleteBrief
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}