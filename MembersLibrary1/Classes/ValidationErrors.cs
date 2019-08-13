using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersLibrary1.Classes
{
    public class ValidationErrors
    {
        public List<EntityValidationExceptionItem> _EntityValidationExceptionList = new List<EntityValidationExceptionItem>();
        public ValidationErrors(DbEntityValidationException pEv)
        {

            foreach (var eve in pEv.EntityValidationErrors)
            {
                IEnumerable<DbEntityValidationResult> test = pEv.EntityValidationErrors;
                Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                    eve.Entry.Entity.GetType().Name, eve.Entry.State);

                var item = new EntityValidationExceptionItem()
                {
                    Name = eve.Entry.Entity.GetType().Name,
                    State = eve.Entry.State
                };

                _EntityValidationExceptionList.Add(item);

                item.Items = new List<EntityValidationExceptionProperty>();

                foreach (var ve in eve.ValidationErrors)
                {
                    Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",ve.PropertyName, ve.ErrorMessage);
                    item.Items.Add(new EntityValidationExceptionProperty()
                    {
                        PropertyName = ve.PropertyName,
                        ErrorMessage = ve.ErrorMessage,
                        Value = eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName)
                    });
                    
                }
            }

            var sb = new StringBuilder();

            foreach (var entity in _EntityValidationExceptionList)
            {
                sb.AppendLine(entity.ToString());
                foreach (var item in entity.Items)
                {
                    sb.AppendLine($"  {item.ToString()}");
                }
            }

            Console.WriteLine(sb.ToString());

        }

    }

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
