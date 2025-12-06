using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Models.Enums;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.Imports;

public class StarSystemImport : IGoogleSheetImport
{
    [Name(StarSystemSheetFields.AdminNotes)]
    public string? AdminNotes { get; set; }

    [Name(StarSystemSheetFields.AdditionalNotes)]
    public string? AdditionalNotes { get; set; }

    [Name(StarSystemSheetFields.Bases)]
    public int? Bases { get; set; }

    [Name(StarSystemSheetFields.BlackHoleDestination)]
    public string? BlackHoleDestination { get; set; }

    [Name(StarSystemSheetFields.Buy)]
    public float Buy { get; set; }

    [Name(StarSystemSheetFields.CivilizedBy)]
    public string? CivilizedBy { get; set; }

    [Name(StarSystemSheetFields.Color)]
    public string? Color { get; set; }

    [Name(StarSystemSheetFields.ConflictType)]
    public StarSystemConflictTypes StarSystemConflictType { get; set; }

    [Name(StarSystemSheetFields.DataQualityCheck)]
    public string? DataQualityCheck { get; set; }

    [Name(StarSystemSheetFields.DiscoveredBy)]
    public string? DiscoveredBy { get; set; }

    [Name(StarSystemSheetFields.DiscoveredLinkOnWiki)]
    public string? DiscoveredLinkOnWiki { get; set; }

    [Name(StarSystemSheetFields.DiscoveredNotes)]
    public string? DiscoveredNotes { get; set; }

    [Name(StarSystemSheetFields.DiscoveryDate)]
    public string? DiscoveryDate { get; set; }

    [Name(StarSystemSheetFields.DiscoveryPlatform)]
    public string? PlatformType { get; set; }

    [Name(StarSystemSheetFields.DocSequence)]
    public int DocSequence { get; set; }

    [Name(StarSystemSheetFields.EconomyType)]
    public StarSystemEconomyTypes StarSystemEconomyType { get; set; }

    [Name(StarSystemSheetFields.Evolution)]
    public string? Evolution { get; set; }

    [Name(StarSystemSheetFields.ExoSuitSClassUpgradeModules)]
    public HashSet<StarSystemSuitUpgradeTypes> SuitUpgradeModules { get; set; } = [];

    [Name(StarSystemSheetFields.ExternalLink1)]
    public string? ExternalLink1 { get; set; }

    [Name(StarSystemSheetFields.ExternalLink2)]
    public string? ExternalLink2 { get; set; }

    [Name(StarSystemSheetFields.ExternalLink3)]
    public string? ExternalLink3 { get; set; }

    [Name(StarSystemSheetFields.Faction)]
    public StarSystemFactionTypes StarSystemFaction { get; set; }

    [Name(StarSystemSheetFields.GalaxyName)]
    public string? GalaxyName { get; set; }

    [Name(StarSystemSheetFields.GalaxySequence)]
    public int GalaxySequence { get; set; }

    [Name(StarSystemSheetFields.GalacticCoordinates)]
    public string? GalacticCoordinates { get; set; }

    [Name(StarSystemSheetFields.GalleryTextNotes)]
    public string? GalleryTextNotes { get; set; }

    [Name(StarSystemSheetFields.GameModeType)]
    public GameModeTypes GameModeType { get; set; }

    [Name(StarSystemSheetFields.GameRelease)]
    public string? GameRelease { get; set; }

    [Name(StarSystemSheetFields.GameReleaseVersionNumber)]
    public float GameReleaseVersionNumber { get; set; }

    [Name(StarSystemSheetFields.GlyphCode)]
    public string? GlyphCode { get; set; }

    [Name(StarSystemSheetFields.HasCenterAccess)]
    public string? HasCenterAccess { get; set; }

    [Name(StarSystemSheetFields.HasWater)]
    public bool HasWater { get; set; }

    [Name(StarSystemSheetFields.Hex2DecSystemId)]
    public int Hex2DecSystemId { get; set; }

    [Name(StarSystemSheetFields.IsDissonant)]
    public bool IsDissonant { get; set; }

    [Name(StarSystemSheetFields.IsGiantSystem)]
    public bool IsGiantSystem { get; set; }

    [Name(StarSystemSheetFields.IsPhantomSystem)]
    public bool IsPhantomSystem { get; set; }

    [Name(StarSystemSheetFields.KeySystemIndicator)]
    public string? KeySystemIndicator { get; set; }

    [Name(StarSystemSheetFields.LegacyPCDiscoverersGamerTagName)]
    public string? LegacyPCDiscoverersGamerTagName { get; set; }

    [Name(StarSystemSheetFields.LegacyPCSystemName)]
    public string? LegacyPCSystemName { get; set; }

    [Name(StarSystemSheetFields.LegacyPSDiscoverersGamerTagName)]
    public string? LegacyPSDiscoverersGamerTagName { get; set; }

    [Name(StarSystemSheetFields.LegacyPSSystemName)]
    public string? LegacyPSSystemName { get; set; }

    [Name(StarSystemSheetFields.LegacyXboxDiscoverersGamerTagName)]
    public string? LegacyXboxDiscoverersGamerTagName { get; set; }

    [Name(StarSystemSheetFields.LegacyXboxSystemName)]
    public string? LegacyXboxSystemName { get; set; }

    [Name(StarSystemSheetFields.LightYearsFromCenter)]
    public int? LightYearsFromCenter { get; set; }

    [Name(StarSystemSheetFields.LightYearsFromCenterAutoEstimate)]
    public int LightYearsFromCenterAutoEstimate { get; set; }

    [Name(StarSystemSheetFields.LocInfoNotes)]
    public string? LocInfoNotes { get; set; }

    [Name(StarSystemSheetFields.MTTextNotes)]
    public string? MTTextNotes { get; set; }

    [Name(StarSystemSheetFields.MultiToolSClassUpgradeModules)]
    public HashSet<StarSystemMultiToolUpdateTypes> MultiToolSClassUpgradeModules { get; set; } = [];

    [Name(StarSystemSheetFields.Name)]
    public string? Name { get; set; }

    [Name(StarSystemSheetFields.NMSWikiLink)]
    public string? NMSWikiLink { get; set; }

    [Name(StarSystemSheetFields.NumberOfMoons)]
    public int NumberOfMoons { get; set; }

    [Name(StarSystemSheetFields.NumberOfPlanets)]
    public int NumberOfPlanets { get; set; }

    [Name(StarSystemSheetFields.OriginalSystemName)]
    public string? OriginalSystemName { get; set; }

    [Name(StarSystemSheetFields.PlanetOfInterestId)]
    public string? PlanetOfInterestId { get; set; }

    [Name(StarSystemSheetFields.PlanetsTextNotes)]
    public string? PlanetsTextNotes { get; set; }

    [Name(StarSystemSheetFields.PortalRepository)]
    public string? PortalRepository { get; set; }

    [Name(StarSystemSheetFields.RegionName)]
    public string? RegionName { get; set; }

    [Name(StarSystemSheetFields.Sell)]
    public float Sell { get; set; }

    [Name(StarSystemSheetFields.SpecialInterest)]
    public string? SpecialInterest { get; set; }

    [Name(StarSystemSheetFields.SpaceShipSClassUpgradeModules)]
    public HashSet<StarSystemShipUpgradeTypes> StarSystemShipUpgradeModules { get; set; } = [];

    [Name(StarSystemSheetFields.SpaceStationNotes)]
    public string? SpaceStationNotes { get; set; }

    [Name(StarSystemSheetFields.SpaceStationTradeItems)]
    public HashSet<StarSystemStationTradeItemTypes> SpaceStationTradeItems { get; set; } = [];

    [Name(StarSystemSheetFields.StarCategory)]
    public string? StarCategory { get; set; }

    [Name(StarSystemSheetFields.StarCount)]
    public int StarCount { get; set; }

    [Name(StarSystemSheetFields.StarshipsTextNotes)]
    public string? StarshipsTextNotes { get; set; }

    [Name(StarSystemSheetFields.SummaryAdditions)]
    public string? SummaryAdditions { get; set; }

    [Name(StarSystemSheetFields.SurveyDate)]
    public string? SurveyDate { get; set; }

    [Name(StarSystemSheetFields.SurveyorName)]
    public string? SurveyorName { get; set; }

    [Name(StarSystemSheetFields.SystemHexadecimal)]
    public string? SystemHexadecimal { get; set; }

    [Name(StarSystemSheetFields.SystemMisc)]
    public string? SystemMisc { get; set; }

    [Name(StarSystemSheetFields.SystemNameAllPlatforms)]
    public string? StarSystemNameAllPlatforms { get; set; }

    [Name(StarSystemSheetFields.VideoLink)]
    public string? VideoLink { get; set; }

    [Name(StarSystemSheetFields.WealthType)]
    public StarSystemWealthTypes StarSystemWealthType { get; set; }

    [Name(StarSystemSheetFields.XCoordDec)]
    public int XCoordDec { get; set; }

    [Name(StarSystemSheetFields.YCoordDec)]
    public int YCoordDec { get; set; }

    [Name(StarSystemSheetFields.ZCoordDec)]
    public int ZCoordDec { get; set; }
}