using System.Collections.Generic;
using System.Data.Entity;

namespace EntityValidationLibrary.Classes
{
    /// <summary>
    /// Container for violation on a save changes
    /// </summary>
    public class EntityValidationExceptionItem
    {
        /// <summary>
        /// Entity name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// State of entity during save operation
        /// </summary>
        public EntityState State { get; set; }
        public List<EntityValidationExceptionProperty> PropertyItems { get; set; }
        public override string ToString()
        {
            return $"{Name} state: {State.ToString()}";
        }
    }
}