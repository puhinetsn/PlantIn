using PlantInAPI.Data;
using PlantInAPI.src.PlantsSpecies.DTOs;
using PlantInAPI.src.PlantsSpecies.Models;
using PlantInAPI.src.PlantsSpecies.Repositories;

namespace PlantInAPI.src.PlantsSpecies.Service
{
    public class PlantService : IPlantSpeciesService
    {
        private readonly IPlantSpeciesRepo plantRepo;

        public PlantService(IPlantSpeciesRepo repo) => plantRepo = repo;

        public async Task<PlantSpecies> AddPlantAsync(PlantRequestDTO plantDto)
        {
            var plant = new PlantSpecies
            {
                CommonName = plantDto.CommonName,
                LatinName = plantDto.LatinName,
                AlternativeNames = plantDto.AlternativeNames,
                Description = plantDto.Description
            };

            await plantRepo.AddPlant(plant);

            return plant;
        }

        public async Task<IEnumerable<PlantResponseDTO>> GetAllPlantsAsync()
        {
            var products = await plantRepo.GetAllPlants();

            return products.Select(p => new PlantResponseDTO
            (
                p.Id,
                p.CommonName,
                p.LatinName,
                p.AlternativeNames,
                p.Description
            ));
        }

        public async Task<PlantSpecies> GetPlantByIdAsync(Guid id)
        {
            var plant = await plantRepo.GetPlantById(id);

            if (plant == null)
                throw new KeyNotFoundException("Plant not found");

            return plant;
        }

        public async Task UpdatePlant(Guid id, PlantSpecies plant)
        {
            var foundPlant = await plantRepo.GetPlantById(id);

            if (foundPlant == null)
                throw new KeyNotFoundException("Plant not found");

            foundPlant.CommonName = plant.CommonName;
            foundPlant.LatinName = plant.LatinName;
            foundPlant.AlternativeNames = plant.AlternativeNames;
            foundPlant.Description = plant.Description;

            await plantRepo.UpdatePlant(id, foundPlant);
        }

        public async Task DeletePlant(Guid id)
        {
            var plant = await plantRepo.GetPlantById(id);

            if (plant == null)
                throw new KeyNotFoundException("Plant not found");
            await plantRepo.DeletePlant(id);
        }
    }   
}
