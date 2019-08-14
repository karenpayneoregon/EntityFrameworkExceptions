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
                var exceptionItem = new EntityValidationExceptionItem()
                {
                    Name = eve.Entry.Entity.GetType().Name,
                    State = eve.Entry.State
                };

                EntityValidationExceptionList.Add(exceptionItem);

                exceptionItem.PropertyItems = new List<EntityValidationExceptionProperty>();

                foreach (var ve in eve.ValidationErrors)
                {

                    exceptionItem.PropertyItems.Add(new EntityValidationExceptionProperty()
                    {
                        PropertyName = ve.PropertyName,
                        ErrorMessage = ve.ErrorMessage
                            .SplitCamelCase().Replace("field ",""),
                        Value = eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName)
                    });
                    
                }
            }

            var sb = new StringBuilder();

            foreach (var entity in EntityValidationExceptionList)
            {
                sb.AppendLine(entity.ToString());
                foreach (var exceptionProperty in entity.PropertyItems)
                {
                    sb.AppendLine($"  {exceptionProperty.ToString()}");
                }
            }
        }
    }
}
