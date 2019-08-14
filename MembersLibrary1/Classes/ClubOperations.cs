using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseConnectionLibrary;
using EntityValidationLibrary.Classes;

namespace MembersLibrary1.Classes
{
    public class ClubOperations : BaseExceptionProperties
    {
        private ValidationErrors _validationErrors;
        public string ValidationErrorMessage => _validationErrorMessage;

        private string _validationErrorMessage;
        public ValidationErrors ValidationErrors => _validationErrors;
        /// <summary>
        /// This method shows an easy method to get violations on
        /// required properties not set and length of field violations
        /// </summary>
        /// <param name="pMemberList1"></param>
        public void AddBadMember1(ClubMember pMemberList1)
        {
            using (var context = new ClubMembersEntity())
            {
                context.Entry(pMemberList1).State = EntityState.Added;
                try
                {

                    context.SaveChanges();

                }
                catch (FormattedDbEntityValidationException fve)
                {

                    mHasException = true;
                    _validationErrors = fve.ValidationErrors();
                    _validationErrorMessage = fve.Message;

                }
                catch (Exception ex)
                {

                    mHasException = true;
                    mLastException = ex;

                }
            }
        }
        /// <summary>
        /// Get all gender types from the database table
        /// </summary>
        /// <returns></returns>
        public List<Gender> GetGenders()
        {
            using (var context = new ClubMembersEntity())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var genders = context.Genders.AsNoTracking().ToList();
                genders.Insert(0, new Gender() {Name = "Select", Id = 0});

                return genders;
            }
        }
        /// <summary>
        /// Mock up of countries
        /// </summary>
        public List<string> Countries => new List<string>()
        {
            "Select",
            "France",
            "Italy",
            "Spain",
            "USA"
        };
    }
}
