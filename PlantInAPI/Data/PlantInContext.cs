using Microsoft.EntityFrameworkCore;
using PlantInAPI.Data.Seeding;
using PlantInAPI.src.PlantsSpecies.Models;
using PlantInAPI.src.User.Models;

namespace PlantInAPI.Data
{
    public class PlantInContext(DbContextOptions<PlantInContext> options) : DbContext(options)
    {
        public DbSet<PlantSpecies> PlantSpecies => Set<PlantSpecies>();
        public DbSet<UserModel> Users => Set<UserModel>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PlantInContext).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SeederConfig.StartSeeding(optionsBuilder);
        }
    }
}
