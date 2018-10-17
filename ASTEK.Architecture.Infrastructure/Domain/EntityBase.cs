using System;
using System.Collections.Generic;

namespace ASTEK.Architecture.Infrastructure.Domain
{
    public abstract class EntityBase<TId>
    {
        public TId Id { get; set; }

        public DateTime DateCreation {get; set;}

        public bool IsDeleted { get; set; }

        public override bool Equals(object obj)
        {
            return obj != null
                   && obj is EntityBase<TId>
                   && this == (EntityBase<TId>) obj;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        } 
    }
}