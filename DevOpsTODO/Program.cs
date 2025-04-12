using DevOpsTODO.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton<Contexto>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
