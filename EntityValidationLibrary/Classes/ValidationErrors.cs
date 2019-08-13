using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Text;
using LanguageExtensionsLibrary;

namespace EntityValidationLibrary.Classes
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
                        ErrorMessage = ve.ErrorMessage.SplitCamelCase().Replace("field ",""),
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
