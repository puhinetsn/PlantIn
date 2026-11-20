using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlantInAPI.src.PlantsSpecies.Models;

namespace PlantInAPI.Data
{
    public class PlantSpeciesConfig
    {
        public class PlantSpeciesConfiguration : IEntityTypeConfiguration<PlantSpecies>
        {
            public void Configure(EntityTypeBuilder<PlantSpecies> e)
            {
                e.Property(p => p.Id).HasDefaultValueSql("uuidv7()").ValueGeneratedOnAdd();

                e.Property(p => p.CommonName).IsRequired().HasMaxLength(150);
                e.Property(p => p.LatinName).IsRequired().HasMaxLength(200);
                e.Property(p => p.AlternativeNames).HasMaxLength(1000);
                e.Property(p => p.Description).HasMaxLength(5000);

                e.Property(p => p.Toxicity).IsRequired().HasConversion<string>().HasMaxLength(20);
                e.Property(p => p.Sunlight).IsRequired().HasConversion<string>().HasMaxLength(20);
                e.Property(p => p.ToxicToHumans).IsRequired();
                e.Property(p => p.ToxicToCats).IsRequired();
                e.Property(p => p.ToxicToDogs).IsRequired();

                e.Property(p => p.PotSize).IsRequired();
                e.Property(p => p.Soil).IsRequired().HasMaxLength(200);
                e.Property(p => p.Temperature).IsRequired();
                e.Property(p => p.TypicalProblems).IsRequired();  

                e.HasIndex(p => p.LatinName).IsUnique();
            }
        }
    }
}
