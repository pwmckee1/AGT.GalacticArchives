using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.Meta;

namespace AGT.GalacticArchives.Core.Models.Requests.Entities;

public class StarSystemSubmissionRequest
{
    public required string Username { get; set; }

    public required GalaxyTypes GalaxyType { get; set; }

    public required string RegionName { get; set; }

    public required string StarSystemName { get; set; }

    public string? OriginalStarSystemName { get; set; }

    public required string GalacticCoordinates { get; set; }

    public required string GamerTagHandle { get; set; }

    public DateTime? DateOfSurvey { get; set; }

    public Communities? CommunityThatCivilized { get; set; }

    // One planet with 5 moons
    public bool IsGiantPlanetSystem { get; set; }

    public bool IsDissonant { get; set; }

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

    public GamePlatformType? GamePlatformType { get; set; }

    public GameModeTypes? GameModeType { get; set; }

    public string? GameRelease { get; set; }

    // Max of 6 Planets/Moons in a system
    public int? PlanetQty { get; set; }

    // Max of 6 Planets/Moons in a system
    public int? MoonQty { get; set; }

    public HashSet<string> PlanetNames { get; set; } = [];

    public HashSet<string> MoonNames { get; set; } = [];

    public string? OtherNotes { get; set; }

    public string? Discord { get; set; }

    public string? Email { get; set; }

    public string? NmsFriendCode { get; set; }

    public string? RedditName { get; set; }

    public string? TwitterName { get; set; }
}