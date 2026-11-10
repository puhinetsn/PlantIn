using Microsoft.EntityFrameworkCore;

namespace PlantInAPI.Data
{
    public class PlantInContext(DbContextOptions<PlantInContext> options) : DbContext(options)
    {
    }
}
