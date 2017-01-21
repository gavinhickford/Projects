using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SIGN.Data.EFCore
{
    public class SIGNContext : IdentityDbContext<SIGNUser>, ISIGNContext
    {
        public SIGNContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Guideline> Guidelines { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<StepAction> StepActions { get; set; }
        public DbSet<Decision> Decisions { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<RecommendationGrade> RecommendationGrades { get; set; }
        public DbSet<StepDetail> StepDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guideline>().Ignore(g => g.IsDirty);
            modelBuilder.Entity<Assessment>().Ignore(g => g.IsDirty);
            modelBuilder.Entity<Step>().Ignore(g => g.IsDirty);
            modelBuilder.Entity<Decision>().Ignore(g => g.IsDirty);
            modelBuilder.Entity<StepAction>().Ignore(g => g.IsDirty);
            modelBuilder.Entity<Recommendation>().Ignore(g => g.IsDirty);
            modelBuilder.Entity<RecommendationGrade>().Ignore(g => g.IsDirty);
            modelBuilder.Entity<StepDetail>().Ignore(g => g.IsDirty);

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
