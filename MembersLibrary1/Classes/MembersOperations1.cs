using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseConnectionLibrary;

namespace MembersLibrary1.Classes
{
    public class MembersOperations1 : BaseExceptionProperties
    {
        private string _ValidationErrorMessage;
        public string ValidationErrorMessage => _ValidationErrorMessage;
        public void AddBadMember1(MemberList1 pMemberList1)
        {
            using (var context = new MembersEntity1())
            {
                context.Entry(pMemberList1).State = EntityState.Added;
                try
                {
                    context.SaveChanges();
                }
                catch (DbEntityValidationException ev)
                {
                    var test = new ValidationErrors(ev);
                    Console.WriteLine();
                    //foreach (var eve in ev.EntityValidationErrors)
                    //{
                    //    IEnumerable<DbEntityValidationResult> test = ev.EntityValidationErrors;
                    //    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                    //        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    //    foreach (var ve in eve.ValidationErrors)
                    //    {
                    //        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                    //            ve.PropertyName, ve.ErrorMessage);
                    //    }
                    //}
                }
                catch (Exception ex)
                {
                    mHasException = true;
                    _ValidationErrorMessage = ((FormattedDbEntityValidationException) ex).Message;
                    Console.WriteLine();

                }
            }
        }
    }
}
