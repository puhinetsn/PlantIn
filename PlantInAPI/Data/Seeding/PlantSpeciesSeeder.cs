using Microsoft.EntityFrameworkCore;
using PlantInAPI.src.PlantsSpecies.Models;

namespace PlantInAPI.Data.Seeding
{
    public class PlantSpeciesSeeder: IEntitySeeder
    {
        public async Task SeedAsync(DbContext context, CancellationToken ct = default)
        {
            var set = context.Set<PlantSpecies>();
            var existing = (await set.Select(p => p.LatinName).ToListAsync(ct)).ToHashSet();

            var seed = new[]
            {

            new PlantSpecies
            {
                CommonName = "African Violet",
                LatinName = "Saintpaulia ionantha",
                AlternativeNames = "Usambara violet",
                Description = "Compact flowering houseplant with fuzzy leaves and year-round blooms in purple, pink or white.",
                Toxicity = ToxicityLevel.Low,
                Sunlight = SunlightLevel.Medium,
                ToxicToHumans = false,
                ToxicToCats = false,
                ToxicToDogs = false,
                PotSize = 10,
                Temperature = 21,
                Soil = "Light, well-draining African violet mix",
                TypicalProblems = new[]
                {
        "Crown rot from overwatering",
        "Leaf spots from cold water on foliage",
        "No blooms in low light",
    }
            },

new PlantSpecies
{
    CommonName = "Aloe Vera",
    LatinName = "Aloe vera",
    AlternativeNames = "True aloe, Medicinal aloe",
    Description = "Succulent with fleshy, gel-filled leaves, valued for its soothing gel.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = false,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 15,
    Temperature = 22,
    Soil = "Sandy, fast-draining cactus mix",
    TypicalProblems = new[]
    {
        "Root rot from overwatering",
        "Leggy growth in low light",
        "Brown or sunburnt leaf tips",
    }
},

new PlantSpecies
{
    CommonName = "Anthurium",
    LatinName = "Anthurium andraeanum",
    AlternativeNames = "Flamingo flower, Laceleaf, Tailflower",
    Description = "Tropical plant with glossy heart-shaped leaves and long-lasting waxy red, pink or white spathes.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 15,
    Temperature = 22,
    Soil = "Airy, chunky aroid mix with bark and perlite",
    TypicalProblems = new[]
    {
        "Yellow leaves from overwatering",
        "Brown leaf tips in dry air",
        "Few flowers in low light",
    }
},

new PlantSpecies
{
    CommonName = "Areca Palm",
    LatinName = "Dypsis lutescens",
    AlternativeNames = "Butterfly palm, Golden cane palm, Yellow palm",
    Description = "Feathery, arching palm that makes a lush, pet-safe indoor tree.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 25,
    Temperature = 22,
    Soil = "Well-draining peat-based potting mix",
    TypicalProblems = new[]
    {
        "Brown frond tips from dry air or fluoride",
        "Spider mites",
        "Yellowing from overwatering",
    }
},

new PlantSpecies
{
    CommonName = "Asparagus Fern",
    LatinName = "Asparagus setaceus",
    AlternativeNames = "Common asparagus fern, Lace fern",
    Description = "Delicate, feathery foliage on arching stems; not a true fern.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 15,
    Temperature = 20,
    Soil = "Rich, well-draining potting mix",
    TypicalProblems = new[]
    {
        "Needle drop from dry air or underwatering",
        "Spider mites",
        "Yellowing in direct sun",
    }
},

new PlantSpecies
{
    CommonName = "Rex Begonia",
    LatinName = "Begonia rex",
    AlternativeNames = "Painted-leaf begonia, King begonia",
    Description = "Grown for its dramatic, colourful patterned foliage.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 15,
    Temperature = 20,
    Soil = "Light, humus-rich, well-draining mix",
    TypicalProblems = new[]
    {
        "Powdery mildew",
        "Leaf drop from drafts",
        "Stem rot from overwatering",
    }
},

new PlantSpecies
{
    CommonName = "Bird of Paradise",
    LatinName = "Strelitzia reginae",
    AlternativeNames = "Crane flower",
    Description = "Large paddle-shaped leaves and striking orange and blue flowers resembling a bird in flight.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 30,
    Temperature = 22,
    Soil = "Rich, well-draining potting mix",
    TypicalProblems = new[]
    {
        "Split leaves from wind or low humidity",
        "Spider mites",
        "No flowers without enough light",
    }
},

new PlantSpecies
{
    CommonName = "Bird's Nest Fern",
    LatinName = "Asplenium nidus",
    AlternativeNames = "Nest fern",
    Description = "Fern with wavy, glossy, undivided fronds growing in a rosette.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 15,
    Temperature = 21,
    Soil = "Light, airy, moisture-retentive mix with bark",
    TypicalProblems = new[]
    {
        "Brown edges from dry air",
        "Rot if water collects in the crown",
        "Scale insects",
    }
},

new PlantSpecies
{
    CommonName = "Boston Fern",
    LatinName = "Nephrolepis exaltata",
    AlternativeNames = "Sword fern",
    Description = "Classic hanging fern with long, arching, lush green fronds.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 20,
    Temperature = 20,
    Soil = "Peat-based, moisture-retentive potting mix",
    TypicalProblems = new[]
    {
        "Crispy fronds from low humidity",
        "Leaf drop from drafts",
        "Mealybugs",
    }
},

new PlantSpecies
{
    CommonName = "Calathea Ornata",
    LatinName = "Calathea ornata",
    AlternativeNames = "Pinstripe calathea",
    Description = "Dark green leaves with delicate pink pinstripes that fold up at night.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 15,
    Temperature = 22,
    Soil = "Peat-based, moisture-retentive, well-draining mix",
    TypicalProblems = new[]
    {
        "Crispy leaf edges from dry air or tap water minerals",
        "Curling leaves from underwatering",
        "Spider mites",
    }
},

new PlantSpecies
{
    CommonName = "Cast Iron Plant",
    LatinName = "Aspidistra elatior",
    AlternativeNames = "Bar-room plant",
    Description = "Extremely tough plant with dark, glossy leaves that tolerates neglect and deep shade.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Low,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 25,
    Temperature = 18,
    Soil = "Well-draining, general-purpose potting mix",
    TypicalProblems = new[]
    {
        "Leaf scorch in direct sun",
        "Root rot from overwatering",
        "Scale insects",
    }
},

new PlantSpecies
{
    CommonName = "Chinese Evergreen",
    LatinName = "Aglaonema commutatum",
    AlternativeNames = "Aglaonema, Silver evergreen",
    Description = "Easy foliage plant with patterned green and silver leaves tolerating low light.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Low,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 20,
    Temperature = 22,
    Soil = "Light, well-draining potting mix",
    TypicalProblems = new[]
    {
        "Yellow leaves from overwatering",
        "Brown tips from cold drafts",
        "Mealybugs",
    }
},

new PlantSpecies
{
    CommonName = "Chinese Money Plant",
    LatinName = "Pilea peperomioides",
    AlternativeNames = "Pancake plant, UFO plant, Missionary plant",
    Description = "Round, coin-shaped leaves on slender stalks; produces many offsets.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 12,
    Temperature = 20,
    Soil = "Well-draining mix with perlite",
    TypicalProblems = new[]
    {
        "Leaf curl from too much light",
        "Drooping from overwatering",
        "Leaning toward light",
    }
},

new PlantSpecies
{
    CommonName = "Christmas Cactus",
    LatinName = "Schlumbergera bridgesii",
    AlternativeNames = "Holiday cactus, Zygocactus",
    Description = "Epiphytic cactus with segmented stems and bright winter flowers.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 15,
    Temperature = 18,
    Soil = "Loose, well-draining mix with bark and perlite",
    TypicalProblems = new[]
    {
        "Bud drop from sudden changes in light or temperature",
        "Limp segments from root rot",
        "Fungal infections in wet soil",
    }
},

new PlantSpecies
{
    CommonName = "Florist's Chrysanthemum",
    LatinName = "Chrysanthemum morifolium",
    AlternativeNames = "Mum, Garden mum",
    Description = "Popular flowering plant with dense blooms in many colours.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 20,
    Temperature = 16,
    Soil = "Rich, well-draining potting mix",
    TypicalProblems = new[]
    {
        "Aphids",
        "Powdery mildew",
        "Wilting from irregular watering",
    }
},

new PlantSpecies
{
    CommonName = "Never Never Plant",
    LatinName = "Ctenanthe setosa",
    AlternativeNames = "Grey star, Bamburanta",
    Description = "Calathea relative with long wavy leaves that have silvery-green stripes and purple undersides.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 18,
    Temperature = 22,
    Soil = "Peat-based, moisture-retentive, well-draining mix",
    TypicalProblems = new[]
    {
        "Curling leaves from low humidity",
        "Brown edges from tap water minerals",
        "Spider mites",
    }
},

new PlantSpecies
{
    CommonName = "Daffodil",
    LatinName = "Narcissus pseudonarcissus",
    AlternativeNames = "Wild daffodil, Lent lily",
    Description = "Spring bulb with trumpet-shaped yellow flowers.",
    Toxicity = ToxicityLevel.High,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 20,
    Temperature = 15,
    Soil = "Well-draining, gritty bulb compost",
    TypicalProblems = new[]
    {
        "Bulb rot in wet soil",
        "Blind buds (no flowers) from poor light",
        "Narcissus bulb fly",
    }
},

new PlantSpecies
{
    CommonName = "Corn Plant",
    LatinName = "Dracaena fragrans",
    AlternativeNames = "Dracaena, Cornstalk dracaena",
    Description = "Upright, cane-like houseplant with broad, arching strap leaves.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 25,
    Temperature = 21,
    Soil = "Well-draining potting mix",
    TypicalProblems = new[]
    {
        "Brown tips from fluoride in tap water",
        "Yellow lower leaves from overwatering",
        "Spider mites",
    }
},

new PlantSpecies
{
    CommonName = "Dumb Cane",
    LatinName = "Dieffenbachia seguine",
    AlternativeNames = "Dieffenbachia, Tropic snow",
    Description = "Large, variegated leaves on thick stems; sap causes painful mouth irritation.",
    Toxicity = ToxicityLevel.High,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 25,
    Temperature = 22,
    Soil = "Rich, well-draining potting mix",
    TypicalProblems = new[]
    {
        "Leaf drop from drafts",
        "Yellow leaves from overwatering",
        "Spider mites",
    }
},

new PlantSpecies
{
    CommonName = "Echeveria",
    LatinName = "Echeveria elegans",
    AlternativeNames = "Mexican snowball, Hen and chicks",
    Description = "Compact succulent forming tight blue-green rosettes.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 10,
    Temperature = 22,
    Soil = "Gritty, fast-draining cactus mix",
    TypicalProblems = new[]
    {
        "Etiolation (stretching) in low light",
        "Rot from overwatering",
        "Mealybugs",
    }
},

new PlantSpecies
{
    CommonName = "Elephant Ear",
    LatinName = "Alocasia amazonica",
    AlternativeNames = "Alocasia, African mask plant",
    Description = "Dramatic arrow-shaped, dark green leaves with bold white veins.",
    Toxicity = ToxicityLevel.High,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 20,
    Temperature = 22,
    Soil = "Airy, well-draining aroid mix",
    TypicalProblems = new[]
    {
        "Spider mites",
        "Leaf drop in winter dormancy",
        "Root rot from overwatering",
    }
},

new PlantSpecies
{
    CommonName = "English Ivy",
    LatinName = "Hedera helix",
    AlternativeNames = "Common ivy",
    Description = "Vigorous evergreen climber or trailer with lobed leaves.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 15,
    Temperature = 18,
    Soil = "Well-draining, general-purpose potting mix",
    TypicalProblems = new[]
    {
        "Spider mites in dry air",
        "Leaf drop from underwatering",
        "Leggy growth in low light",
    }
},

new PlantSpecies
{
    CommonName = "Weeping Fig",
    LatinName = "Ficus benjamina",
    AlternativeNames = "Benjamin fig, Benjamin tree",
    Description = "Graceful indoor tree with small, glossy, pointed leaves on drooping branches.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 30,
    Temperature = 21,
    Soil = "Well-draining potting mix",
    TypicalProblems = new[]
    {
        "Leaf drop after moving or from drafts",
        "Scale insects",
        "Overwatering",
    }
},

new PlantSpecies
{
    CommonName = "Fiddle Leaf Fig",
    LatinName = "Ficus lyrata",
    AlternativeNames = "Fiddle-leaf fig",
    Description = "Statement tree with large, violin-shaped, glossy leaves.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 30,
    Temperature = 21,
    Soil = "Well-draining, chunky potting mix",
    TypicalProblems = new[]
    {
        "Brown spots from root rot",
        "Leaf drop after relocation",
        "Dust build-up on leaves",
    }
},

new PlantSpecies
{
    CommonName = "Nerve Plant",
    LatinName = "Fittonia albivenis",
    AlternativeNames = "Mosaic plant, Fittonia",
    Description = "Low-growing plant with vividly veined leaves in white, pink or red.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 10,
    Temperature = 22,
    Soil = "Light, moisture-retentive potting mix",
    TypicalProblems = new[]
    {
        "Sudden wilting when dry",
        "Crispy leaves from low humidity",
        "Root rot from overwatering",
    }
},

new PlantSpecies
{
    CommonName = "Zebra Haworthia",
    LatinName = "Haworthia fasciata",
    AlternativeNames = "Zebra plant, Fairy washboard",
    Description = "Small succulent rosette with white-banded, pointed leaves.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 10,
    Temperature = 20,
    Soil = "Gritty, fast-draining cactus mix",
    TypicalProblems = new[]
    {
        "Root rot from overwatering",
        "Sunburn in direct light",
        "Mealybugs",
    }
},

new PlantSpecies
{
    CommonName = "Hyacinth",
    LatinName = "Hyacinthus orientalis",
    AlternativeNames = "Common hyacinth, Dutch hyacinth",
    Description = "Spring bulb with dense, very fragrant flower spikes.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 15,
    Temperature = 15,
    Soil = "Well-draining, gritty bulb compost",
    TypicalProblems = new[]
    {
        "Bulb rot in wet soil",
        "Floppy flower stems in warm or dim spots",
        "Skin irritation when handling bulbs",
    }
},

new PlantSpecies
{
    CommonName = "Iron Cross Begonia",
    LatinName = "Begonia masoniana",
    AlternativeNames = "Mason's begonia",
    Description = "Textured, puckered green leaves marked with a dark brown cross.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 15,
    Temperature = 20,
    Soil = "Light, humus-rich, well-draining mix",
    TypicalProblems = new[]
    {
        "Powdery mildew",
        "Leaf rot if foliage stays wet",
        "Leaf drop in cold drafts",
    }
},

new PlantSpecies
{
    CommonName = "Jade Plant",
    LatinName = "Crassula ovata",
    AlternativeNames = "Money plant, Lucky plant, Friendship tree",
    Description = "Long-lived succulent with thick, woody stems and plump, oval leaves.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 20,
    Temperature = 20,
    Soil = "Gritty, fast-draining cactus mix",
    TypicalProblems = new[]
    {
        "Root rot from overwatering",
        "Leggy growth in low light",
        "Mealybugs",
    }
},

new PlantSpecies
{
    CommonName = "Flaming Katy",
    LatinName = "Kalanchoe blossfeldiana",
    AlternativeNames = "Kalanchoe, Christmas kalanchoe",
    Description = "Succulent with clusters of long-lasting, brightly coloured flowers.",
    Toxicity = ToxicityLevel.High,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 12,
    Temperature = 20,
    Soil = "Gritty, fast-draining cactus mix",
    TypicalProblems = new[]
    {
        "Powdery mildew",
        "Leggy growth in low light",
        "Root rot from overwatering",
    }
},

new PlantSpecies
{
    CommonName = "Lily",
    LatinName = "Lilium longiflorum",
    AlternativeNames = "Easter lily, Daylily (Hemerocallis)",
    Description = "Elegant trumpet-shaped flowers. Both true lilies and daylilies are extremely dangerous to cats.",
    Toxicity = ToxicityLevel.High,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 20,
    Temperature = 18,
    Soil = "Rich, well-draining potting mix",
    TypicalProblems = new[]
    {
        "Bulb rot in wet soil",
        "Aphids",
        "Leaf yellowing after flowering",
    }
},

new PlantSpecies
{
    CommonName = "Lily of the Valley",
    LatinName = "Convallaria majalis",
    AlternativeNames = "May bells, Our Lady's tears",
    Description = "Shade-loving perennial with fragrant, bell-shaped white flowers.",
    Toxicity = ToxicityLevel.High,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 20,
    Temperature = 15,
    Soil = "Humus-rich, moisture-retentive mix",
    TypicalProblems = new[]
    {
        "Leaf scorch in direct sun",
        "Dries out in hot, dry spells",
        "Fungal leaf spots",
    }
},

new PlantSpecies
{
    CommonName = "Money Tree",
    LatinName = "Pachira aquatica",
    AlternativeNames = "Guiana chestnut, Malabar chestnut",
    Description = "Often sold with a braided trunk and palmate leaves; thought to bring good fortune.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 25,
    Temperature = 21,
    Soil = "Well-draining potting mix with perlite",
    TypicalProblems = new[]
    {
        "Leaf drop from overwatering or drafts",
        "Root rot",
        "Spider mites",
    }
},

new PlantSpecies
{
    CommonName = "Monstera",
    LatinName = "Monstera deliciosa",
    AlternativeNames = "Swiss cheese plant, Split-leaf philodendron",
    Description = "Large, glossy leaves with natural splits and holes; a popular climbing houseplant.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 30,
    Temperature = 22,
    Soil = "Chunky, well-draining aroid mix",
    TypicalProblems = new[]
    {
        "Yellow leaves from overwatering",
        "No splits in low light",
        "Spider mites and scale",
    }
},

new PlantSpecies
{
    CommonName = "Moth Orchid",
    LatinName = "Phalaenopsis amabilis",
    AlternativeNames = "Phalaenopsis, Orchid",
    Description = "Easy, long-blooming orchid with arching sprays of broad flowers.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 12,
    Temperature = 22,
    Soil = "Orchid bark mix (no regular potting soil)",
    TypicalProblems = new[]
    {
        "Root rot from overwatering",
        "Wrinkled leaves from underwatering",
        "Bud drop from drafts",
    }
},

new PlantSpecies
{
    CommonName = "Parlor Palm",
    LatinName = "Chamaedorea elegans",
    AlternativeNames = "Neanthe bella palm",
    Description = "Small, slow-growing palm with graceful fronds that tolerates low light.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Low,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 20,
    Temperature = 21,
    Soil = "Well-draining peat-based potting mix",
    TypicalProblems = new[]
    {
        "Brown tips from dry air",
        "Spider mites",
        "Yellowing from overwatering",
    }
},

new PlantSpecies
{
    CommonName = "Peace Lily",
    LatinName = "Spathiphyllum wallisii",
    AlternativeNames = "Spathiphyllum, Spath",
    Description = "Glossy dark leaves and white spathes; droops dramatically when thirsty.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Low,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 20,
    Temperature = 22,
    Soil = "Peat-based, moisture-retentive potting mix",
    TypicalProblems = new[]
    {
        "Drooping when dry",
        "Brown tips from fluoride or dry air",
        "No flowers in deep shade",
    }
},

new PlantSpecies
{
    CommonName = "Baby Rubber Plant",
    LatinName = "Peperomia obtusifolia",
    AlternativeNames = "Pepper face, American rubber plant",
    Description = "Compact plant with thick, glossy, spoon-shaped leaves.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 12,
    Temperature = 21,
    Soil = "Light, well-draining potting mix with perlite",
    TypicalProblems = new[]
    {
        "Leaf drop from overwatering",
        "Wrinkled leaves from underwatering",
        "Mealybugs",
    }
},

new PlantSpecies
{
    CommonName = "Heartleaf Philodendron",
    LatinName = "Philodendron hederaceum",
    AlternativeNames = "Sweetheart plant, Philodendron scandens",
    Description = "Fast-growing vine with glossy heart-shaped leaves.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 15,
    Temperature = 21,
    Soil = "Well-draining aroid mix",
    TypicalProblems = new[]
    {
        "Yellow leaves from overwatering",
        "Leggy growth in low light",
        "Aphids and mealybugs",
    }
},

new PlantSpecies
{
    CommonName = "Poinsettia",
    LatinName = "Euphorbia pulcherrima",
    AlternativeNames = "Christmas star, Christmas flower",
    Description = "Holiday plant with showy red, pink or white bracts; the sap can mildly irritate skin and stomach.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 15,
    Temperature = 18,
    Soil = "Well-draining potting mix",
    TypicalProblems = new[]
    {
        "Leaf drop from cold drafts",
        "Root rot from overwatering",
        "Whiteflies",
    }
},

new PlantSpecies
{
    CommonName = "Polka Dot Plant",
    LatinName = "Hypoestes phyllostachya",
    AlternativeNames = "Freckle face, Measles plant",
    Description = "Compact plant with pink, red or white speckled leaves.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 12,
    Temperature = 21,
    Soil = "Light, moisture-retentive potting mix",
    TypicalProblems = new[]
    {
        "Leggy growth without pinching",
        "Wilting when dry",
        "Fading colour in low light",
    }
},

new PlantSpecies
{
    CommonName = "Ponytail Palm",
    LatinName = "Beaucarnea recurvata",
    AlternativeNames = "Elephant's foot, Bottle palm",
    Description = "Succulent-like plant with a swollen trunk base and a fountain of long, curly leaves.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 25,
    Temperature = 22,
    Soil = "Gritty, fast-draining cactus mix",
    TypicalProblems = new[]
    {
        "Trunk rot from overwatering",
        "Brown tips from dry air or minerals",
        "Slow growth in low light",
    }
},

new PlantSpecies
{
    CommonName = "Pothos",
    LatinName = "Epipremnum aureum",
    AlternativeNames = "Devil's ivy, Golden pothos, Ivy arum",
    Description = "Nearly indestructible trailing vine with heart-shaped, often variegated leaves.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 15,
    Temperature = 21,
    Soil = "Well-draining, general-purpose potting mix",
    TypicalProblems = new[]
    {
        "Yellow leaves from overwatering",
        "Loss of variegation in low light",
        "Mealybugs",
    }
},

new PlantSpecies
{
    CommonName = "Prayer Plant",
    LatinName = "Maranta leuconeura",
    AlternativeNames = "Maranta, Ten commandments plant",
    Description = "Patterned leaves that fold upward at night like praying hands.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 15,
    Temperature = 22,
    Soil = "Peat-based, moisture-retentive, well-draining mix",
    TypicalProblems = new[]
    {
        "Crispy edges from dry air",
        "Curling leaves from underwatering",
        "Spider mites",
    }
},

new PlantSpecies
{
    CommonName = "Rattlesnake Plant",
    LatinName = "Calathea lancifolia",
    AlternativeNames = "Goeppertia insignis",
    Description = "Long, wavy leaves with dark spots and purple undersides.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 18,
    Temperature = 22,
    Soil = "Peat-based, moisture-retentive, well-draining mix",
    TypicalProblems = new[]
    {
        "Brown leaf edges from low humidity",
        "Curling leaves from thirst",
        "Spider mites",
    }
},

new PlantSpecies
{
    CommonName = "Rubber Plant",
    LatinName = "Ficus elastica",
    AlternativeNames = "Rubber fig, Indian rubber tree",
    Description = "Bold, thick, glossy leaves on a sturdy upright stem.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 30,
    Temperature = 21,
    Soil = "Well-draining potting mix",
    TypicalProblems = new[]
    {
        "Lower leaf drop from overwatering",
        "Dust on leaves",
        "Scale and spider mites",
    }
},

new PlantSpecies
{
    CommonName = "Sago Palm",
    LatinName = "Cycas revoluta",
    AlternativeNames = "King sago, Japanese sago palm",
    Description = "Slow-growing cycad with stiff, feathery fronds. All parts, especially the seeds, are highly toxic.",
    Toxicity = ToxicityLevel.High,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 30,
    Temperature = 22,
    Soil = "Gritty, fast-draining mix",
    TypicalProblems = new[]
    {
        "Yellowing fronds from overwatering",
        "Scale insects",
        "Slow growth in low light",
    }
},

new PlantSpecies
{
    CommonName = "Umbrella Plant",
    LatinName = "Schefflera arboricola",
    AlternativeNames = "Dwarf umbrella tree, Dwarf schefflera",
    Description = "Shrubby plant with glossy leaflets radiating from each stem like an umbrella.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 25,
    Temperature = 20,
    Soil = "Well-draining potting mix",
    TypicalProblems = new[]
    {
        "Leaf drop from overwatering or drafts",
        "Spider mites",
        "Leggy growth in low light",
    }
},

new PlantSpecies
{
    CommonName = "Satin Pothos",
    LatinName = "Scindapsus pictus",
    AlternativeNames = "Silver vine, Silver philodendron",
    Description = "Trailing vine with velvety green leaves splashed with silver.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 15,
    Temperature = 21,
    Soil = "Well-draining aroid mix",
    TypicalProblems = new[]
    {
        "Curling leaves from underwatering",
        "Root rot from overwatering",
        "Mealybugs",
    }
},

new PlantSpecies
{
    CommonName = "String of Pearls",
    LatinName = "Senecio rowleyanus",
    AlternativeNames = "String of beads, Curio rowleyanus",
    Description = "Trailing succulent with bead-like round leaves on thin stems.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 12,
    Temperature = 21,
    Soil = "Gritty, fast-draining cactus mix",
    TypicalProblems = new[]
    {
        "Shriveled pearls from underwatering",
        "Mushy stems from overwatering",
        "Sparse growth in low light",
    }
},

new PlantSpecies
{
    CommonName = "Snake Plant",
    LatinName = "Dracaena trifasciata",
    AlternativeNames = "Sansevieria trifasciata, Mother-in-law's tongue",
    Description = "Upright, sword-like leaves; extremely tolerant of low light and neglect.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Low,
    ToxicToHumans = false,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 20,
    Temperature = 21,
    Soil = "Gritty, fast-draining cactus mix",
    TypicalProblems = new[]
    {
        "Root rot from overwatering",
        "Mushy leaves in cold",
        "Mealybugs",
    }
},

new PlantSpecies
{
    CommonName = "Triostar",
    LatinName = "Stromanthe sanguinea",
    AlternativeNames = "Stromanthe Triostar, Tricolor prayer plant",
    Description = "Striking leaves variegated in green, cream and pink with burgundy undersides.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 18,
    Temperature = 22,
    Soil = "Peat-based, moisture-retentive, well-draining mix",
    TypicalProblems = new[]
    {
        "Crispy edges from dry air",
        "Curling leaves from thirst",
        "Spider mites",
    }
},

new PlantSpecies
{
    CommonName = "Wandering Jew",
    LatinName = "Tradescantia zebrina",
    AlternativeNames = "Inch plant, Silver inch plant",
    Description = "Fast-growing trailing plant with purple-and-silver striped leaves.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.Medium,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 15,
    Temperature = 20,
    Soil = "Light, well-draining potting mix",
    TypicalProblems = new[]
    {
        "Leggy growth in low light",
        "Faded stripes in low light",
        "Skin irritation from sap",
    }
},

new PlantSpecies
{
    CommonName = "Tulip",
    LatinName = "Tulipa gesneriana",
    AlternativeNames = "Garden tulip",
    Description = "Spring bulb with cup-shaped flowers in nearly every colour.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 20,
    Temperature = 15,
    Soil = "Well-draining, gritty bulb compost",
    TypicalProblems = new[]
    {
        "Bulb rot in wet soil",
        "Tulip fire (Botrytis)",
        "Floppy stems in warm spots",
    }
},

new PlantSpecies
{
    CommonName = "Venus Flytrap",
    LatinName = "Dionaea muscipula",
    AlternativeNames = "Flytrap",
    Description = "Carnivorous plant with hinged, jaw-like traps that catch insects.",
    Toxicity = ToxicityLevel.Low,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = false,
    ToxicToCats = false,
    ToxicToDogs = false,
    PotSize = 12,
    Temperature = 20,
    Soil = "Nutrient-free mix of peat moss and perlite (use only distilled or rain water)",
    TypicalProblems = new[]
    {
        "Death from tap water minerals",
        "Blackening traps after overfeeding",
        "Needs winter dormancy",
    }
},

new PlantSpecies
{
    CommonName = "Spineless Yucca",
    LatinName = "Yucca elephantipes",
    AlternativeNames = "Giant yucca, Yucca gigantea",
    Description = "Tree-like plant with a thick trunk and a crown of sword-shaped leaves.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.High,
    ToxicToHumans = false,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 30,
    Temperature = 20,
    Soil = "Gritty, fast-draining mix",
    TypicalProblems = new[]
    {
        "Root rot from overwatering",
        "Lower leaf yellowing",
        "Spider mites",
    }
},

new PlantSpecies
{
    CommonName = "ZZ Plant",
    LatinName = "Zamioculcas zamiifolia",
    AlternativeNames = "Zanzibar gem, Eternity plant",
    Description = "Glossy, waxy leaves on arching stems; thrives on neglect and low light.",
    Toxicity = ToxicityLevel.Medium,
    Sunlight = SunlightLevel.Low,
    ToxicToHumans = true,
    ToxicToCats = true,
    ToxicToDogs = true,
    PotSize = 20,
    Temperature = 21,
    Soil = "Gritty, fast-draining potting mix",
    TypicalProblems = new[]
    {
        "Rhizome rot from overwatering",
        "Yellow leaves from too much water",
        "Slow growth in low light",
    }
},

            };

            set.AddRange(seed.Where(s => !existing.Contains(s.LatinName)));
            await context.SaveChangesAsync(ct);
        }
    }
}
