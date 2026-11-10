using PlantInAPI.src.PlantsSpecies.Models;

namespace PlantInAPI.src.PlantsSpecies.Repositories
{
    public interface IPlantSpeciesRepo
    {
        Task<IEnumerable<PlantSpecies>> GetAllPlants();
        Task AddPlant(PlantSpecies plant);
    }
}
