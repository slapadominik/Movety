using System;
using System.ComponentModel.DataAnnotations;

namespace Movety.Persistence.DAO
{
    public abstract class Entity<T> where T : struct 
    {
        [Key]
        public T Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Modified { get; set; }
    }
}