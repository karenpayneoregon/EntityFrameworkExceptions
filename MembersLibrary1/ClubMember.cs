namespace MembersLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberList1")]
    public partial class ClubMember
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(Order = 1)]
        public bool Active { get; set; }

        [Required]
        [Column(Order = 2)]
        [StringLength(10)]
        public string FirstName { get; set; }

        [Required]
        [Column(Order = 3)]
        [StringLength(10)]
        public string LastName { get; set; }

        [Required]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Gender { get; set; }

        [Required]
        [Column(Order = 5)]
        public string Street { get; set; }

        [Required]
        [Column(Order = 6)]
        public string City { get; set; }

        [Required]
        [Column(Order = 7)]
        [StringLength(2)]
        public string State { get; set; }

        [Required]
        [Column(Order = 8)]
        public string Country { get; set; }

        [Required]
        [Column(Order = 9, TypeName = "datetime2")]
        public DateTime JoinDate { get; set; }

        [Required]
        [Column(Order = 10)]
        public string ContactPhone { get; set; }

        public virtual Gender Gender1 { get; set; }
    }
}
