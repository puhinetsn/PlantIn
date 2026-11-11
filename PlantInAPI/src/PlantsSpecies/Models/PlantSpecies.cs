namespace PlantInAPI.src.PlantsSpecies.Models
{
    public class PlantSpecies
    {
        public Guid Id { get; private set; }
        public string CommonName { get; set; } = string.Empty;
        public string LatinName { get; set; } = string.Empty;
        public string? AlternativeNames { get; set; }
        public string? Description { get; set; }
    }
}
