using FluentValidation;
using PlantInAPI.src.PlantsSpecies.Repositories;
using PlantInAPI.src.PlantsSpecies.Service;
using PlantInAPI.src.PlantsSpecies.Validation;

namespace PlantInAPI.src.PlantsSpecies
{
    public static class PlantDI
    {
        public static IServiceCollection AddPlantsDependencies(this IServiceCollection services)
        {
            services.AddScoped<IPlantSpeciesRepo, PlantSpeciesRepo>();
            services.AddScoped<IPlantSpeciesService, PlantService>();
            services.AddValidatorsFromAssemblyContaining<PlantValidator>();

            return services;
        }
    }
}
