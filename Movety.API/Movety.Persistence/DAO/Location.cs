using System;

namespace Movety.Persistence.DAO
{
    public class Location : Entity<Guid>
    {
        public string City { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}