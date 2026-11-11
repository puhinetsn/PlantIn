namespace PlantInAPI.src.PlantsSpecies.DTOs
{
    public record PlantRequestDTO
    (
        string CommonName,
        string LatinName,
        string? AlternativeNames,
        string? Description
    );
}
