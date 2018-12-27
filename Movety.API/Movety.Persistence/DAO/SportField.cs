using System;
using System.ComponentModel.DataAnnotations;

namespace Movety.Persistence.DAO
{
    public class SportField : Entity<int>
    {
        [Required]
        public string Name { get; set; }
    }
}