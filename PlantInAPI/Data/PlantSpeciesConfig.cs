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
                e.Property(p => p.Id).HasDefaultValueSql("uuidv7()");
                e.Property(p => p.CommonName).IsRequired().HasMaxLength(150);
                e.Property(p => p.LatinName).IsRequired().HasMaxLength(200);
                e.Property(p => p.AlternativeNames).HasMaxLength(1000);
                e.Property(p => p.Description).HasMaxLength(5000);
                e.HasIndex(p => p.LatinName).IsUnique();
            }
        }
    }
}
