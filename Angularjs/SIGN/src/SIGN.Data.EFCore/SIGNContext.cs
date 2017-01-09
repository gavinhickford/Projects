using Microsoft.EntityFrameworkCore;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SIGN.Data.EFCore
{
    public class SIGNContext : IdentityDbContext<SIGNUser>
    {
        //private IConfigurationRoot _configuration;

        public SIGNContext(DbContextOptions options) : base(options)
        {
            //    _configuration = configuration;
        }

        public DbSet<Guideline> Guidelines { get; set; }
        public DbSet<Assessment> Assessments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //    string connectionString = _configuration["ConnectionStrings:SIGNContextConnectionString"];
            //    optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guideline>().Ignore(g => g.IsDirty);
            modelBuilder.Entity<Assessment>().Ignore(g => g.IsDirty);
            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            SetModificationHistory();
            int result = await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
            SetIsDirtyFlag();
            return result;
        }

        public override int SaveChanges()
        {
            SetModificationHistory();
            int result = base.SaveChanges();
            SetIsDirtyFlag();

            return result;
        }

        private void SetIsDirtyFlag()
        {
            var savedEntities = this.ChangeTracker.Entries()
                .Where(e => e.Entity is IModificationHistory)
                .Select(e => e.Entity as IModificationHistory);

            foreach (var entity in savedEntities)
            {
                entity.IsDirty = false;
            }
        }

        private void SetModificationHistory()
        {
            var modifiedEntities = this.ChangeTracker.Entries()
                .Where(e => e.Entity is IModificationHistory && (e.State == EntityState.Added ||
                    e.State == EntityState.Modified))
                .Select(e => e.Entity as IModificationHistory);

            foreach (var entity in modifiedEntities)
            {
                entity.DateModified = DateTime.Now;
                if (entity.DateCreated == DateTime.MinValue)
                {
                    entity.DateCreated = DateTime.Now;
                }
            }
        }
    }
}
