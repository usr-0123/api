using api.Data;

namespace api.Helpers.ActivityLog
{
    public class CleanupActivityLogsService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;

        public CleanupActivityLogsService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<DBContext>();
                    // ActivityLogHelper
                }
                {
                    
                }
            }
        }
    }
}

