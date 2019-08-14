using System.Diagnostics.CodeAnalysis;

namespace MembersLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gender")]
    public partial class Gender
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gender()
        {
            MemberList1 = new HashSet<ClubMember>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClubMember> MemberList1 { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
