using Microsoft.EntityFrameworkCore;

namespace PlantInAPI.Data
{
    public static class DataExtensions
    {
        public static void AddPlantInDb(this WebApplicationBuilder builder)
        {
            var connString = builder.Configuration.GetConnectionString("PlantIn");
            builder.Services.AddDbContext<PlantInContext>(options =>
                options.UseNpgsql(connString));
        }
    }
}
