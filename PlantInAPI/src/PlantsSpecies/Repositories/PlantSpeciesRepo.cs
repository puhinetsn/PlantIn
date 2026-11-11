using PlantInAPI.Data;
using PlantInAPI.src.PlantsSpecies.Models;
using Microsoft.EntityFrameworkCore;
using PlantInAPI.src.PlantsSpecies.DTOs;

namespace PlantInAPI.src.PlantsSpecies.Repositories
{
    public class PlantSpeciesRepo : IPlantSpeciesRepo
    {
        private readonly PlantInContext plantDB;

        public PlantSpeciesRepo(PlantInContext db) => plantDB = db;

        public async Task DeletePlant(Guid id)
        {
            var plant = await plantDB.PlantSpecies.FindAsync(id);

            if (plant != null)
            {
                plantDB.PlantSpecies.Remove(plant);

                await plantDB.SaveChangesAsync();
            }
        }

        public async Task AddPlant(PlantSpecies plant)
        {
            await plantDB.PlantSpecies.AddAsync(plant);
            await plantDB.SaveChangesAsync();
        }

        public async Task<IEnumerable<PlantSpecies>> GetAllPlants()
        {
            return await plantDB.PlantSpecies.ToListAsync();

        }

        public async Task<PlantSpecies> GetPlantById(Guid id)
        {
            return await plantDB.PlantSpecies.FindAsync(id);
        }

        public async Task UpdatePlant(Guid id, PlantSpecies plant)
        {
            plantDB.PlantSpecies.Update(plant);
            await plantDB.SaveChangesAsync();
        }
    }
}
