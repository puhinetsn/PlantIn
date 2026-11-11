using PlantInAPI.src.PlantsSpecies.DTOs;
using PlantInAPI.src.PlantsSpecies.Models;

namespace PlantInAPI.src.PlantsSpecies.Service
{
    public interface IPlantSpeciesService
    {
        Task<IEnumerable<PlantResponseDTO>> GetAllPlantsAsync();
        Task<PlantSpecies> AddPlantAsync(PlantRequestDTO productDto);
        Task<PlantSpecies> GetPlantByIdAsync(Guid id);
        Task UpdatePlant(Guid id, PlantSpecies plant);
        Task DeletePlant(Guid id);
    }
}
