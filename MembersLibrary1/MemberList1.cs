namespace MembersLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MemberList1
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Active { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string LastName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Gender { get; set; }

        [Key]
        [Column(Order = 5)]
        public string Street { get; set; }

        [Key]
        [Column(Order = 6)]
        public string City { get; set; }

        [Key]
        [Column(Order = 7)]
        public string State { get; set; }

        [Key]
        [Column(Order = 8)]
        public string Country { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "datetime2")]
        public DateTime JoinDate { get; set; }

        [Key]
        [Column(Order = 10)]
        public string ContactPhone { get; set; }

        public virtual Gender Gender1 { get; set; }
    }
}
