using PlantInAPI.Data;
using PlantInAPI.src.PlantsSpecies;

var builder = WebApplication.CreateBuilder(args);


builder.AddPlantInDb();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();


builder.Services.AddPlantsDependencies();



var app = builder.Build();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.Run();
