namespace PlantInAPI.src.PlantsSpecies.DTOs
{
    public record PlantResponseDTO
    (
        Guid Id,
        string CommonName,
        string LatinName,
        string? AlternativeNames,
        string? Description
    );
}
