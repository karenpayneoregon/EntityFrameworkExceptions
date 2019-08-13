using System.Data.Entity.Validation;
using MembersLibrary1.Classes;

namespace MembersLibrary1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MembersEntity1 : DbContext
    {
        /// <summary>
        /// Same connection string as used in MembersEntity
        /// </summary>
        public MembersEntity1()
            : base("name=MembersEntity1ConnectionString")
        {
        }

        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<MemberList1> MemberList1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>()
                .HasMany(e => e.MemberList1)
                .WithRequired(e => e.Gender1)
                .HasForeignKey(e => e.Gender)
                .WillCascadeOnDelete(false);
        }
        public override int SaveChanges()
        {
            var modifiedEntities = ChangeTracker.Entries()
                .Where(p => p.State == EntityState.Added).ToList();
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                var newException = new FormattedDbEntityValidationException(e);
                throw newException;
            }
        }
    }
}
