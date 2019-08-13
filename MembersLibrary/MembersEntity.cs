namespace MembersLibrary
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MembersEntity : DbContext
    {
        public MembersEntity()
            : base("name=MembersEntityConnectionString")
        {
        }

        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<MemberList> MemberLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>()
                .HasMany(e => e.MemberLists)
                .WithRequired(e => e.Gender1)
                .HasForeignKey(e => e.Gender)
                .WillCascadeOnDelete(false);
        }
    }
}
