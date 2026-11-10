namespace PlantInAPI.src.PlantsSpecies.DTOs
{
    public record PlantSpeciesDTO
    (
        Guid Id,
        string CommonName,
        string LatinName,
        string? AlternativeNames,
        string? Description
    );
}
