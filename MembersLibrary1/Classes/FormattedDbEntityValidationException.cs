using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersLibrary1.Classes
{
    public class FormattedDbEntityValidationException : Exception
    {
        public FormattedDbEntityValidationException(DbEntityValidationException innerException) :base(null, innerException)
        {
        }

        public override string Message
        {
            get
            {
                if (!(InnerException is DbEntityValidationException innerException)) return base.Message;

                var sb = new StringBuilder();

                foreach (var eve in innerException.EntityValidationErrors)
                {
                    sb.AppendLine($"- Entity of type \"{eve.Entry.Entity.GetType().FullName}\" in state \"{eve.Entry.State}\" has the following validation errors:");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        var dddd = eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName);
                        //sb.AppendLine($"   \"{ve.PropertyName}\", Value: \"{eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName)}\", Error: \"{ve.ErrorMessage}\"");
                        sb.AppendLine($"   {ve.PropertyName}, Value: \"{eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName)}\", Error: \"{ve.ErrorMessage}\"");
                    }
                }

                sb.AppendLine();

                return sb.ToString();

            }
        }
    }
}
