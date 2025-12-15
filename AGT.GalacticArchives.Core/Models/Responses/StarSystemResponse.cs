using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;

namespace AGT.GalacticArchives.Core.Models.Responses;

public class StarSystemResponse : GameEntityResponse
{
    public string? OriginalSystemName { get; set; }

    public string? StarSystemNameAllPlatforms { get; set; }

    public string? AdminNotes { get; set; }

    public string? DataQualityCheck { get; set; }

    public string? PlanetOfInterestId { get; set; }

    public bool? IsGiantSystem { get; set; }

    public string? SpecialInterest { get; set; }

    public bool? IsDissonant { get; set; }

    public int? StarCount { get; set; }

    public string? StarCategory { get; set; }

    public StarColorTypes? Color { get; set; }

    public int? NumberOfPlanets { get; set; }

    public int? NumberOfMoons { get; set; }

    public FactionTypes? Faction { get; set; }

    public int? LightYearsFromCenter { get; set; }

    public int? LightYearsFromCenterAutoEstimate { get; set; }

    public bool? HasWater { get; set; }

    public EconomyTypes? EconomyType { get; set; }

    public WealthTypes? WealthType { get; set; }

    public float? Buy { get; set; }

    public float? Sell { get; set; }

    public ConflictTypes? ConflictType { get; set; }

    public string? KeySystemIndicator { get; set; }

    public HashSet<SpaceStationTradeItemTypes> SpaceStationTradeItems { get; set; } = [];

    public HashSet<ExoSuitUpgradeModuleTypes> ExosuitUpgradeModules { get; set; } = [];

    public HashSet<StarshipUpgradeTypes> StarshipUpgradeModules { get; set; } = [];

    public HashSet<MultiToolUpdateModuleTypes> MultiToolUpdateTypes { get; set; } = [];

    public string? SummaryAdditions { get; set; }

    public string? DiscoveredNotes { get; set; }

    public string? PlanetsNotes { get; set; }

    public string? StarshipsNotes { get; set; }

    public string? MultiToolNotes { get; set; }

    public string? LocInfoNotes { get; set; }

    public string? SpaceStationNotes { get; set; }

    public string? GalleryTextNotes { get; set; }

    public bool? IsPhantomSystem { get; set; }

    public bool? HasCenterAccess { get; set; }

    public string? BlackHoleDestination { get; set; }

    public string? PortalRepository { get; set; }

    public string? ExternalLink1 { get; set; }

    public string? ExternalLink2 { get; set; }

    public string? ExternalLink3 { get; set; }

    public string? VideoLink { get; set; }

    public string? LegacyPCSystemName { get; set; }

    public string? LegacyPSSystemName { get; set; }

    public string? LegacyXboxSystemName { get; set; }

    public string? LegacyPCDiscoverersGamerTagName { get; set; }

    public string? LegacyPSDiscoverersGamerTagName { get; set; }

    public string? LegacyXboxDiscoverersGamerTagName { get; set; }

    public string? Evolution { get; set; }

    public string? SystemMisc { get; set; }

    public float? StarSystemAge { get; set; }

    public string? ResearchTeam { get; set; }

    public int? Bases { get; set; }

    public string? PlanetsTextNotes { get; set; }

    public string? StarshipsTextNotes { get; set; }
}