using AGT.GalacticArchives.Core.Models.Enums.StarSystem;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class StarSystemSearchRequest : GameEntitySearchRequest
{
    public string? StarSystemNameAllPlatforms { get; set; }

    public string? OriginalSystemName { get; set; }

    public string? GlyphCode { get; set; }

    public bool? IsGiantSystem { get; set; }

    public bool? IsDissonant { get; set; }

    public int? StarCount { get; set; }

    public string? StarCategory { get; set; }

    public string? Color { get; set; }

    public int? NumberOfPlanets { get; set; }

    public int? NumberOfMoons { get; set; }

    public int? LightYearsFromCenter { get; set; }

    public bool? HasWater { get; set; }

    public FactionTypes? Faction { get; set; }

    public EconomyTypes? EconomyType { get; set; }

    public ConflictTypes? ConflictType { get; set; }

    public WealthTypes? WealthType { get; set; }

    public float? Buy { get; set; }

    public float? Sell { get; set; }

    public string? KeySystemIndicator { get; set; }

    public HashSet<string?> SpaceStationTradeItems { get; set; } = [];

    public HashSet<string?> ExoSuitSClassUpgradeModules { get; set; } = [];

    public HashSet<string?> SpaceShipSClassUpgradeModules { get; set; } = [];

    public HashSet<string?> MultiToolSClassUpgradeModules { get; set; } = [];

    public bool? IsPhantomSystem { get; set; }

    public bool? HasCenterAccess { get; set; }

    public string? BlackHoleDestination { get; set; }

    public string? LegacyPCSystemName { get; set; }

    public string? LegacyPSSystemName { get; set; }

    public string? LegacyXboxSystemName { get; set; }

    public string? LegacyPCDiscoverersGamerTagName { get; set; }

    public string? LegacyPSDiscoverersGamerTagName { get; set; }

    public string? LegacyXboxDiscoverersGamerTagName { get; set; }
}