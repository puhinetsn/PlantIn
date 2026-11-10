using PlantInAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.AddPlantInDb();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
