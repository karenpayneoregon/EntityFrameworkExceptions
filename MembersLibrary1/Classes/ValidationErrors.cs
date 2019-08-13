using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersLibrary1.Classes
{
    public class ValidationErrors
    {
        public List<EntityValidationExceptionItem> EntityValidationExceptionList = 
            new List<EntityValidationExceptionItem>();

        public ValidationErrors(DbEntityValidationException pEv)
        {

            foreach (var eve in pEv.EntityValidationErrors)
            {
                var item = new EntityValidationExceptionItem()
                {
                    Name = eve.Entry.Entity.GetType().Name,
                    State = eve.Entry.State
                };

                EntityValidationExceptionList.Add(item);

                item.Items = new List<EntityValidationExceptionProperty>();

                foreach (var ve in eve.ValidationErrors)
                {

                    item.Items.Add(new EntityValidationExceptionProperty()
                    {
                        PropertyName = ve.PropertyName,
                        ErrorMessage = ve.ErrorMessage,
                        Value = eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName)
                    });
                    
                }
            }

            var sb = new StringBuilder();

            foreach (var entity in EntityValidationExceptionList)
            {
                sb.AppendLine(entity.ToString());
                foreach (var item in entity.Items)
                {
                    sb.AppendLine($"  {item.ToString()}");
                }
            }
        }
    }
}
