using api.Data;
using Microsoft.EntityFrameworkCore;

namespace api.Extensions;

public static class DatabaseExtensions
{
    public static IServiceCollection AddCustomDatabase(this IServiceCollection services, IConfiguration configuration,
        IWebHostEnvironment env)
    {
        services.AddDbContext<DBContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            if (env.IsDevelopment()) options.EnableSensitiveDataLogging();
        });
        return services;
    }
}