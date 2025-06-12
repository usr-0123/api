namespace api.Extensions
{
    public static class CoreExtensions
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, IWebHostEnvironment env,
            string SpecificOrigins)
        {
            // Automapper
            if (env.IsDevelopment() || env.IsProduction()) 
            {
                services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
                services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            }

            // services.AddAutoMapper(typeof(Map));
            
            // MediatR
            services.AddHttpContextAccessor();
            services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddCors(options =>
            {
                options.AddPolicy(name: SpecificOrigins, builder =>
                {
                    builder
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .WithExposedHeaders("Content-Disposition")
                        .SetIsOriginAllowed(origin => true);
                });
            });
            
            return services;
        }
    }
}

