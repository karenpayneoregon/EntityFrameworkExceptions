using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using EntityValidationLibrary.Classes;
using MembersLibrary1.Classes;

namespace MembersLibrary1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ClubMembersEntity : DbContext
    {
        /// <summary>
        /// Same connection string as used in MembersEntity
        /// </summary>
        public ClubMembersEntity() : base("name=MembersEntity1ConnectionString")
        {

        }

        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<ClubMember> MemberList1 { get; set; }

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
            /*
             * Get modified and/or new (not used but here for how to).
             */
            var changedEntities = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified).ToList();

            /*
             * Only get new
             */
            var newEntities = ChangeTracker.Entries()
                .Where(p => p.State == EntityState.Added).ToList();

            foreach (var item in newEntities)
            {
                /*
                 * Set active by default
                 * Set JoinDate here or change JoinDate in the table for a default value
                 */
                if (item.Entity is ClubMember entity)
                {
                    entity.JoinDate = DateTime.Now;
                    entity.Active = true;
                }
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
                 * Will e handle back at the caller
                 */
               
                throw ex;
            }
        }
    }
}
