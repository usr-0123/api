using api.Extensions;
using api.Helpers.ActivityLog;
using Microsoft.EntityFrameworkCore;

namespace api;

public class Startup
{
    private const string appSpecificOrigins = "_SpecificOrigins";
    private IConfiguration Config { get; set; }
    private IWebHostEnvironment Env { get; set; }

    public Startup(IConfiguration configuration, IWebHostEnvironment env)
    {
        Env = env;
        Config = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddCoreServices(Env, appSpecificOrigins);
        services.AddCustomAuthentication(Config, Env);
        services.AddCustomSwagger();
        services.AddCustomDatabase(Config, Env);
        services.AddRepositories();
        services.AddCustomServices();
        services.AddHostedService<CleanupActivityLogsService>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DbContext dbContext)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            // app.UseSwagger(c => {c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1"); });
        }
        app.UseHttpsRedirection();
        app.UseCors();
        app.UseStaticFiles(); // For the wwwroot folder
        app.UseRouting();
        // app.UseTokenValidation();
        app.UseAuthentication();
        app.UseAuthorization();
        // app.UseInjectUser();
        // app.UseInjectApplicationModule(); // for injecting the application module.
        // app.UsePbiAuth();
        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        app.UseSwagger();
    }
}