namespace EntityValidationLibrary.Classes
{
    /// <summary>
    /// Container for validation exceptions 
    /// </summary>
    public class EntityValidationExceptionProperty
    {
        /// <summary>
        /// Property name to field name
        /// </summary>
        public string PropertyName { get; set; }
        /// <summary>
        /// Offending value on a failed save operation
        /// </summary>
        public object Value { get; set; }
        /// <summary>
        /// Reason for failure on a save operation
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Note that Value can be something other than (empty)
        /// such as null or (null) etc.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var value = Value ?? "(empty)";
            return $"{PropertyName} issue: '{ErrorMessage}' value: {value}";
        }
    }
}