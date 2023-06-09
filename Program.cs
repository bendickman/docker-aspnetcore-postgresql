using dockerapi.Setup;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDockerAPI();

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