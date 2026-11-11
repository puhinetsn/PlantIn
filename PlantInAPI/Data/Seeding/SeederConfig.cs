using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace PlantInAPI.Data.Seeding
{
    public static class SeederConfig
    {
        private static readonly IEntitySeeder[] Seeders =
        [
            new PlantSpeciesSeeder(),
        ]; 

        public static void StartSeeding(DbContextOptionsBuilder optionsBuilder)
        {
            foreach (var seeder in Seeders)
            {
                optionsBuilder
                    .UseSeeding((ctx, _) => seeder.SeedAsync(ctx).GetAwaiter().GetResult())
                    .UseAsyncSeeding((ctx, _, ct) => seeder.SeedAsync(ctx, ct));
            }
        }
    }
}
