using AGT.GalacticArchives.Core.Interfaces.GameData;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class StarSystem : IGameData
{
    public Guid EntityId => StarSystemId;

    public Guid StarSystemId { get; set; } = Guid.NewGuid();

    public required string Name { get; set; }

    public string NormalizedName => Name.ToUpperInvariant();

    public string? SystemNameAllPlatforms { get; set; }

    public string? AdminNotes { get; set; }

    public string? DataQualityCheck { get; set; }

    public string? OriginalSystemName { get; set; }

    public required string GalacticCoordinates { get; set; }

    // TODO Get with Caleb about calculation
    public string? GlyphCode { get; set; }

    public string? PlanetOfInterestId { get; set; }

    public string? SurveyorName { get; set; }

    public string? DiscoveredBy { get; set; }

    public string? DiscoveredLinkOnWiki { get; set; }

    public bool IsGiantSystem { get; set; }

    public string? DiscoveryDate { get; set; }

    public string? SurveyDate { get; set; }

    public string? SpecialInterest { get; set; }

    public bool IsDissonant { get; set; }

    public string? CivilizedBy { get; set; }

    public string? Bases { get; set; }

    public string? PlatformType { get; set; }

    public string? GameModeType { get; set; }

    public int? StarCount { get; set; }

    public string? StarCategory { get; set; }

    public string? Color { get; set; }

    public int? NumberOfPlanets { get; set; }

    public int? NumberOfMoons { get; set; }

    public string? Faction { get; set; }

    public int? LightYearsFromCenter { get; set; }

    public int? LightYearsFromCenterAutoEstimate { get; set; }

    public bool HasWater { get; set; }

    public string? EconomyType { get; set; }

    public string? WealthType { get; set; }

    public float? Buy { get; set; }

    public float? Sell { get; set; }

    public string? ConflictType { get; set; }

    public string? GameRelease { get; set; }

    public string? KeySystemIndicator { get; set; }

    public HashSet<string?> SpaceStationTradeItems { get; set; } = [];

    public HashSet<string?> ExoSuitSClassUpgradeModules { get; set; } = [];

    public HashSet<string?> SpaceShipSClassUpgradeModules { get; set; } = [];

    public HashSet<string?> MultiToolSClassUpgradeModules { get; set; } = [];

    public int? XCoordDec { get; set; }

    public int? YCoordDec { get; set; }

    public int? ZCoordDec { get; set; }

    public int? Hex2DecSystemId { get; set; }

    public string? SummaryAdditions { get; set; }

    public string? DiscoveredNotes { get; set; }

    public string? PlanetsTextNotes { get; set; }

    public string? StarshipsTextNotes { get; set; }

    public string? MTTextNotes { get; set; }

    public string? LocInfoNotes { get; set; }

    public string? SpaceStationNotes { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? GalleryTextNotes { get; set; }

    public bool? IsPhantomSystem { get; set; }

    public bool? HasCenterAccess { get; set; }

    public string? BlackHoleDestination { get; set; }

    public string? NMSWikiLink { get; set; }

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

    public Guid? RegionId { get; set; }

    public Region? Region { get; set; }

    public HashSet<Planet> Planets { get; set; } = [];

    // TODO Replace this with Reflection
    public Dictionary<string, object?> ToDictionary()
    {
        return new Dictionary<string, object?>
        {
            { nameof(StarSystemId), StarSystemId.ToString() },
            { nameof(Name), Name },
            { nameof(NormalizedName), NormalizedName },
            { nameof(AdminNotes), AdminNotes },
            { nameof(DataQualityCheck), DataQualityCheck },
            { nameof(OriginalSystemName), OriginalSystemName },
            { nameof(GalacticCoordinates), GalacticCoordinates },
            { nameof(GlyphCode), GlyphCode },
            { nameof(PlanetOfInterestId), PlanetOfInterestId },
            { nameof(SurveyorName), SurveyorName },
            { nameof(DiscoveredBy), DiscoveredBy },
            { nameof(IsGiantSystem), IsGiantSystem },
            { nameof(SpecialInterest), SpecialInterest },
            { nameof(IsDissonant), IsDissonant },
            { nameof(CivilizedBy), CivilizedBy },
            { nameof(PlatformType), PlatformType },
            { nameof(GameModeType), GameModeType },
            { nameof(StarCount), StarCount },
            { nameof(StarCategory), StarCategory },
            { nameof(Color), Color },
            { nameof(NumberOfPlanets), NumberOfPlanets },
            { nameof(NumberOfMoons), NumberOfMoons },
            { nameof(Faction), Faction },
            { nameof(LightYearsFromCenter), LightYearsFromCenter },
            { nameof(HasWater), HasWater },
            { nameof(EconomyType), EconomyType },
            { nameof(WealthType), WealthType },
            { nameof(Buy), Buy },
            { nameof(Sell), Sell },
            { nameof(ConflictType), ConflictType },
            { nameof(GameRelease), GameRelease },
            { nameof(SystemNameAllPlatforms), SystemNameAllPlatforms },
            { nameof(RegionId), RegionId.ToString() },
            { nameof(DiscoveredLinkOnWiki), DiscoveredLinkOnWiki },
            { nameof(Bases), Bases },
            { nameof(LightYearsFromCenterAutoEstimate), LightYearsFromCenterAutoEstimate },
            { nameof(KeySystemIndicator), KeySystemIndicator },
            { nameof(SpaceStationTradeItems), SpaceStationTradeItems },
            { nameof(ExoSuitSClassUpgradeModules), ExoSuitSClassUpgradeModules },
            { nameof(SpaceShipSClassUpgradeModules), SpaceShipSClassUpgradeModules },
            { nameof(MultiToolSClassUpgradeModules), MultiToolSClassUpgradeModules },
            { nameof(XCoordDec), XCoordDec },
            { nameof(YCoordDec), YCoordDec },
            { nameof(ZCoordDec), ZCoordDec },
            { nameof(Hex2DecSystemId), Hex2DecSystemId },
            { nameof(SummaryAdditions), SummaryAdditions },
            { nameof(DiscoveredNotes), DiscoveredNotes },
            { nameof(PlanetsTextNotes), PlanetsTextNotes },
            { nameof(StarshipsTextNotes), StarshipsTextNotes },
            { nameof(MTTextNotes), MTTextNotes },
            { nameof(LocInfoNotes), LocInfoNotes },
            { nameof(SpaceStationNotes), SpaceStationNotes },
            { nameof(AdditionalNotes), AdditionalNotes },
            { nameof(GalleryTextNotes), GalleryTextNotes },
            { nameof(IsPhantomSystem), IsPhantomSystem },
            { nameof(HasCenterAccess), HasCenterAccess },
            { nameof(BlackHoleDestination), BlackHoleDestination },
            { nameof(NMSWikiLink), NMSWikiLink },
            { nameof(PortalRepository), PortalRepository },
            { nameof(ExternalLink1), ExternalLink1 },
            { nameof(ExternalLink2), ExternalLink2 },
            { nameof(ExternalLink3), ExternalLink3 },
            { nameof(VideoLink), VideoLink },
            { nameof(LegacyPCSystemName), LegacyPCSystemName },
            { nameof(LegacyPSSystemName), LegacyPSSystemName },
            { nameof(LegacyXboxSystemName), LegacyXboxSystemName },
            { nameof(LegacyPCDiscoverersGamerTagName), LegacyPCDiscoverersGamerTagName },
            { nameof(LegacyPSDiscoverersGamerTagName), LegacyPSDiscoverersGamerTagName },
            { nameof(LegacyXboxDiscoverersGamerTagName), LegacyXboxDiscoverersGamerTagName },
            { nameof(Evolution), Evolution },
            { nameof(SystemMisc), SystemMisc },
        };
    }
}