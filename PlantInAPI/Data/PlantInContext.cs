using Microsoft.EntityFrameworkCore;
using PlantInAPI.src.PlantsSpecies.Models;

namespace PlantInAPI.Data
{
    public class PlantInContext(DbContextOptions<PlantInContext> options) : DbContext(options)
    {
        public DbSet<PlantSpecies> PlantSpecies => Set<PlantSpecies>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlantSpecies>(e =>
            {
                e.Property(p => p.Id).HasDefaultValueSql("uuidv7()");
                e.Property(p => p.CommonName).IsRequired().HasMaxLength(150);
                e.Property(p => p.LatinName).IsRequired().HasMaxLength(200);
                e.Property(p => p.AlternativeNames).HasMaxLength(1000);
                e.Property(p => p.Description).HasMaxLength(5000);
                e.HasIndex(p => p.LatinName).IsUnique();
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSeeding((ctx, _) => SeedAsync(ctx).GetAwaiter().GetResult())
                .UseAsyncSeeding((ctx, _, ct) => SeedAsync(ctx, ct));
        }

        private static async Task SeedAsync(DbContext ctx, CancellationToken ct = default)
        {
            var set = ctx.Set<PlantSpecies>();
            var existing = await set.Select(p => p.LatinName).ToHashSetAsync(ct);

            var seed = new[]
            {
                new PlantSpecies
                {
                    CommonName = "African Violet",
                    LatinName = "Saintpaulia ionantha",
                    AlternativeNames = "Saintpaulia, Usambara violet",
                    Description = "Compact flowering houseplant with fuzzy leaves and clusters of violet, pink or white blooms."
                },
                new PlantSpecies
                {
                    CommonName = "Aloe Vera",
                    LatinName = "Aloe vera",
                    AlternativeNames = "True aloe, Medicinal aloe, Aloe barbadensis",
                    Description = "Succulent with thick, fleshy, serrated leaves that store a soothing gel."
                },
                new PlantSpecies
                {
                    CommonName = "Anthurium",
                    LatinName = "Anthurium andraeanum",
                    AlternativeNames = "Flamingo flower, Painted tongue, Tailflower",
                    Description = "Tropical plant with glossy heart-shaped leaves and long-lasting waxy red, pink or white spathes."
                },
                new PlantSpecies
                {
                    CommonName = "Areca Palm",
                    LatinName = "Dypsis lutescens",
                    AlternativeNames = "Butterfly palm, Golden cane palm, Yellow palm",
                    Description = "Clumping palm with feathery, arching fronds and golden-yellow stems."
                }
            };

            set.AddRange(seed.Where(s => !existing.Contains(s.LatinName)));
            await ctx.SaveChangesAsync(ct);
        }
    }
}
