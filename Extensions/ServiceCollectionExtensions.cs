namespace api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCustomServices(this IServiceCollection services)
    {
        // services.AddScoped<>()
        // var versionInfo = JsonConvert.DeserializeObject<VersionInfo>()
        return services;
    }
}