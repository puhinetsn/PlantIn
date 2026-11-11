using Microsoft.EntityFrameworkCore;

namespace PlantInAPI.Data.Seeding
{
    public interface IEntitySeeder
    {
        Task SeedAsync(DbContext context, CancellationToken ct = default);
    }
}
