namespace PlantInAPI.src.PlantsSpecies.Models
{
    public class PlantSpecies
    {
        public Guid Id { get; private set; }
        public string CommonName { get; set; } = string.Empty;
        public string LatinName { get; set; } = string.Empty;
        public string? AlternativeNames { get; set; }
        public string? Description { get; set; }
        public ToxicityLevel Toxicity { get; set; }
        public SunlightLevel Sunlight { get; set; }
        public bool ToxicToHumans { get; set; }
        public bool ToxicToCats { get; set; }
        public bool ToxicToDogs { get; set; }
        public int PotSize { get; set; }
        public string Soil { get; set; }
        public int Temperature { get; set; }
        public string[] TypicalProblems { get; set; }
    }

    public enum ToxicityLevel
    {
        Low,
        Medium,
        High
    }

    public enum SunlightLevel {
        Low,
        Medium,
        High
    }

}
