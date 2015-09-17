using System;

namespace SDellaportas.EfSoftDelete.Console.Models
{
    public class Entity
    {
        public Guid Id { get; protected set; }

        public bool IsDeleted { get; protected set; }

        public DateTime DeletionTime { get; protected set; } 
    }
}