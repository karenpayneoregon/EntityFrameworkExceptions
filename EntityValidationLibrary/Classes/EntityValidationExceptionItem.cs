using System.Collections.Generic;
using System.Data.Entity;

namespace EntityValidationLibrary.Classes
{
    public class EntityValidationExceptionItem
    {
        /// <summary>
        /// Property name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// State of entity during save operation
        /// </summary>
        public EntityState State { get; set; }
        public List<EntityValidationExceptionProperty> Items { get; set; }
        public override string ToString()
        {
            return $"{Name} state: {State.ToString()}";
        }
    }
}