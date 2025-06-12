using api.Models.ActivityLog;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DbContext> options) : base(options)
        {
            // _tenantService = new _tenantService(this, null);
        }
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }
    }
}