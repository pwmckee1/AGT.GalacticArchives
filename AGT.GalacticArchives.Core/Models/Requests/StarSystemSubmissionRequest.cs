using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.Enums.Planet;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class StarSystemSubmissionRequest : BaseSubmissionRequest
{
    public string? OriginalStarSystemName { get; set; }

    // One planet with 5 moons
    public bool? IsGiantPlanetSystem { get; set; }

    public bool? IsDissonant { get; set; }

    public string? StarSpectralClass { get; set; }

    public LifeformTypes? LifeformType { get; set; }

    public EconomyTypes? EconomyType { get; set; }

    public WealthTypes? WealthType { get; set; }

    public ConflictTypes? ConflictLevel { get; set; }

    public bool? HasWater { get; set; }

    public float? EconomyBuy { get; set; }

    public float? EconomySell { get; set; }

    public string? LightYearsFromCenter { get; set; }

    public int? StarQty { get; set; }

    public bool? HasCenterAccess { get; set; }

    public bool? HasPhantomStar { get; set; }

    // Max of 6 Planets/Moons in a system
    public int? PlanetQty { get; set; }

    // Max of 6 Planets/Moons in a system
    public int? MoonQty { get; set; }

    public HashSet<string> PlanetNames { get; set; } = [];

    public HashSet<string> MoonNames { get; set; } = [];
}