using dockerapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
builder.Services.AddDbContext<ApiDbContext>(options =>
    options.UseNpgsql(
        connectionString
    )
);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Blog API",
            Description = ".NET 6 Web API with Docker and PostgreSql"
        });
    });

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web API V1");
});
app.UseRouting();
app.UseEndpoints(opts =>
{
    opts.MapControllers();
});

app.Run();