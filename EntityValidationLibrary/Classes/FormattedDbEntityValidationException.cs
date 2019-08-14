using System;
using System.Data.Entity.Validation;
using System.Text;

namespace EntityValidationLibrary.Classes
{
    public class FormattedDbEntityValidationException : Exception
    {
        private ValidationErrors _information;

        public FormattedDbEntityValidationException(DbEntityValidationException innerException) 
            :base(null, innerException)
        {
        }

        public ValidationErrors ValidationErrors()
        {
            _information = new ValidationErrors((DbEntityValidationException)InnerException);
            return _information;
        }

        public override string Message
        {
            get
            {
                if (!(InnerException is DbEntityValidationException innerException)) return base.Message;

                var sb = new StringBuilder();

                foreach (var eve in innerException.EntityValidationErrors)
                {
                    sb.AppendLine($"- Entity of type \"{eve.Entry.Entity.GetType().FullName}\" in" + 
                                  $" state \"{eve.Entry.State}\" has the following validation errors:");

                    foreach (var ve in eve.ValidationErrors)
                    {
                        sb.AppendLine($"   {ve.PropertyName}, Value: " + 
                                      $"\"{eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName)}\", " + 
                                      $"Error: \"{ve.ErrorMessage}\"");
                    }
                }

                sb.AppendLine();

                return sb.ToString();

            }
        }
    }
}
