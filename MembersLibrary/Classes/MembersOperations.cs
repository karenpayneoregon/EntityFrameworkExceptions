using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersLibrary.Classes
{
    public class MembersOperations
    {
        public List<MemberItem> MembersList()
        {
            using (var context = new MembersEntity())
            {
                context.Configuration.AutoDetectChangesEnabled = false;
                return 
                    (context.MemberLists.AsNoTracking()
                        .Join(context.Genders.AsNoTracking(), ml => ml.Gender, gender => gender.Id,
                            (ml, gender) => new MemberItem
                            {
                                Id = ml.Id,
                                FirstName = ml.FirstName,
                                LastName = ml.LastName,
                                Gender = gender.Name
                            })).ToList();
            }
        }
    }
}
