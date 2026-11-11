using PlantInAPI.src.PlantsSpecies.DTOs;
using PlantInAPI.src.PlantsSpecies.Models;

namespace PlantInAPI.src.PlantsSpecies.Repositories
{
    public interface IPlantSpeciesRepo
    {
        Task<IEnumerable<PlantSpecies>> GetAllPlants();
        Task AddPlant(PlantSpecies plant);

        Task<PlantSpecies> GetPlantById(Guid id);
        Task UpdatePlant(Guid id, PlantSpecies plant);

        Task DeletePlant(Guid id);
    }
}
