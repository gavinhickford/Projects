using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIGN.Domain.Classes;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SIGN.Data.EFCore
{
    public interface ISIGNContext
    {
        DbSet<Assessment> Assessments { get; set; }
        DbSet<Decision> Decisions { get; set; }
        DbSet<Guideline> Guidelines { get; set; }
        DbSet<StepAction> StepActions { get; set; }
        DbSet<Step> Steps { get; set; }

        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));
    }
}