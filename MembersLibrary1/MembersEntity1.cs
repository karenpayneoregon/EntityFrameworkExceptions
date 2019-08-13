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
            var newEntities = ChangeTracker.Entries()
                .Where(p => p.State == EntityState.Added).ToList();

            if (newEntities is MemberList1)
            {
                Console.WriteLine();
            }


            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                throw new FormattedDbEntityValidationException(e);
            }
            catch (Exception ex)
            {
                /*
                 * Decide on how to handle back in the calling code and
                 * perhaps write to a log file
                 */
                throw ex;
            }
        }
    }
}
