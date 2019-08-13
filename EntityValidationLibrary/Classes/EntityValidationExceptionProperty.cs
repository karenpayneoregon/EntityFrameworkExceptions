namespace EntityValidationLibrary.Classes
{
    public class EntityValidationExceptionProperty
    {
        public string PropertyName { get; set; }
        public object Value { get; set; }
        public string ErrorMessage { get; set; }
        public override string ToString()
        {
            object value = Value ?? "(empty)";
            return $"{PropertyName} issue: '{ErrorMessage}' value: {value}";
        }
    }
}