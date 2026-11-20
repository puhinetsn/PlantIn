using PlantInAPI.src.PlantsSpecies.Models;

namespace PlantInAPI.src.PlantsSpecies.DTOs
{
    public record PlantRequestDTO
    (
        string CommonName,
        string LatinName,
        string? AlternativeNames,
        string? Description,
        ToxicityLevel Toxicity,
        SunlightLevel Sunlight,
        bool ToxicToHumans,
        bool ToxicToCats,
        bool ToxicToDogs,
        int PotSize,
        string Soil,
        int Temperature,
        string[] TypicalProblems
    );
}
