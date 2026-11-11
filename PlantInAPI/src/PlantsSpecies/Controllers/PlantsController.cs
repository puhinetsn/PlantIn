using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using PlantInAPI.src.PlantsSpecies.DTOs;
using PlantInAPI.src.PlantsSpecies.Models;
using PlantInAPI.src.PlantsSpecies.Service;

namespace PlantInAPI.src.PlantsSpecies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlantsController : ControllerBase
    {
        private readonly IPlantSpeciesService plantServ;
        private readonly IValidator<PlantRequestDTO> validator;

        public PlantsController(IPlantSpeciesService plantService, IValidator<PlantRequestDTO> plantValidator) {
            Console.WriteLine("Controller constructor");
            plantServ = plantService;
            validator = plantValidator;
        } 

        [HttpGet]

        public async Task<IActionResult> GetAllPlants()
        {
            
            var plants = await plantServ.GetAllPlantsAsync();

            return Ok(plants);
        }

        [HttpPost]
        public async Task<IActionResult> AddPlant(PlantRequestDTO plantDto)
        {
            var result = await validator.ValidateAsync(plantDto);
            if (!result.IsValid)
                return ValidationProblem(new ValidationProblemDetails(result.ToDictionary()));

            var plant = await plantServ.AddPlantAsync(plantDto);
            return StatusCode(201, plant); 
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetPlantById(Guid id)
        {
            try
            {
                var plant = await plantServ.GetPlantByIdAsync(id);
                return Ok(plant); 
            }
            catch (KeyNotFoundException)
            {
                return NotFound(); 
            }
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdatePlant(Guid id, PlantSpecies plant)
        {
            try
            {
                await plantServ.UpdatePlant(id, plant); 
                return NoContent(); 
            }
            catch (KeyNotFoundException)
            {
                return NotFound(); 
            }
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await plantServ.DeletePlant(id); 
                return NoContent(); 
            }
            catch (KeyNotFoundException)
            {
                return NotFound(); 
            }
        }

    }
}

