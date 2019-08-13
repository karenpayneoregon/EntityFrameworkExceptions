namespace MembersLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberList")]
    public partial class MemberList
    {
        public int Id { get; set; }

        public bool Active { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Gender { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Country { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime JoinDate { get; set; }

        [Required]
        public string ContactPhone { get; set; }

        public virtual Gender Gender1 { get; set; }
    }
}
