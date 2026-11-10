using Microsoft.EntityFrameworkCore;
using PlantInAPI.src.PlantsSpecies.Models;

namespace PlantInAPI.Data
{
    public class PlantSpeciesSeeder
    {
        public async Task SeedAsync(DbContext context, CancellationToken ct = default)
        {
            var set = context.Set<PlantSpecies>();
            var existing = (await set.Select(p => p.LatinName).ToListAsync(ct)).ToHashSet();

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
            await context.SaveChangesAsync(ct);
        }
    }
}
