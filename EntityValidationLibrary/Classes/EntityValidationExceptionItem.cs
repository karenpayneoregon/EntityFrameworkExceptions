using System.Collections.Generic;
using System.Data.Entity;

namespace EntityValidationLibrary.Classes
{
    public class EntityValidationExceptionItem
    {
        public string Name { get; set; }
        public EntityState State { get; set; }
        public List<EntityValidationExceptionProperty> Items { get; set; }
        public override string ToString()
        {
            return $"{Name} state: {State.ToString()}";
        }
    }
}