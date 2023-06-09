using dockerapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace dockerapi.Setup
{
    public static class SetupDockerApi
    {
        public static IServiceCollection AddDockerAPI(
        this IServiceCollection services)
        {
            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            services.AddDbContext<ApiDbContext>(options =>
                options.UseNpgsql(
                    connectionString
                )
            );

            services.AddControllers();
            services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo
                    {
                        Title = "Blog API",
                        Description = ".NET 6 Web API with Docker and PostgreSql"
                    });
                });

            return services;
        }
    }
}