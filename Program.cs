using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

// Configure UI generation

var url = "http://localhost:5114";
var assembley = Assembly.GetExecutingAssembly();
UIConfigGenerator.UIConfigGenerator.ParseAssembley(assembley, url);

app.Run();
