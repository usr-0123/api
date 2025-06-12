using api.Data.EntityConfigs;
using api.Models;
using api.Models.ActivityLog;
using api.Services.Tenant;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class DBContext : DbContext
    {
        private ITenantService _tenantService = null;
        private readonly Guid? _tenantId = Guid.Empty;
        public DBContext(DbContextOptions<DbContext> options) : base(options)
        {
            _tenantService = new TenantService(this, null);
            _tenantId = _tenantService.GetCurrentTenant()?.Result?.Value?.TenantId;
        }
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Conventions.Add(_ => new TriggerConfig());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("master");
            modelBuilder.ApplyConfiguration(new UserConfig());
        }

        public override int SaveChanges()
        {
            var changeModels = ChangeTracker.Entries<BaseModel>().Where(o => o.State == EntityState.Added || o.State == EntityState.Modified);

            foreach (var bm in changeModels)
            {
                bm.Entity.TenantId = _tenantId.Value;
            }
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.LogTo(Console.WriteLine);
    }
}