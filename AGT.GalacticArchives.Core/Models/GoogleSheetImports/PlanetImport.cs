using AGT.GalacticArchives.Core.Constants.ImportFields;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class PlanetImport : IImportFormFile
{
    [Name(PlanetSheetFields.PlanetId)]
    public Guid? PlanetId { get; set; }

    [Name(PlanetSheetFields.AgeOfPlanetInBillionsOfYears)]
    public int? AgeOfPlanetInBillionsOfYears { get; set; }

    [Name(PlanetSheetFields.AdminNotes)]
    public string? AdminNotes { get; set; }

    [Name(PlanetSheetFields.AdditionalNotes)]
    public string? AdditionalNotes { get; set; }

    [Name(PlanetSheetFields.ArchetypeOfLand)]
    public LandArchetypes? ArchetypeOfLand { get; set; }

    [Name(PlanetSheetFields.AssignedRawIngredient)]
    public EdibleMaterialTypes? AssignedRawIngredient { get; set; }

    [Name(PlanetSheetFields.AtmosphereGas1)]
    public HarvestedMaterialType? AtmosphereGas1 { get; set; }

    [Name(PlanetSheetFields.AtmosphereGas2)]
    public HarvestedMaterialType? AtmosphereGas2 { get; set; }

    [Name(PlanetSheetFields.AtmosphereGasPercentage1)]
    public float? AtmosphereGasPercentage1 { get; set; }

    [Name(PlanetSheetFields.AtmosphereGasPercentage2)]
    public float? AtmosphereGasPercentage2 { get; set; }

    [Name(PlanetSheetFields.AtmosphereDaytimeColor)]
    public AtmosphereColorTypes? AtmosphereDaytimeColor { get; set; }

    [Name(PlanetSheetFields.AtmosphereResource)]
    public HarvestedMaterialType? AtmosphereResource { get; set; }

    [Name(PlanetSheetFields.PlanetBiomeDescription)]
    public BiomeSubTypes? PlanetBiomeDescription { get; set; }

    [Name(PlanetSheetFields.BiomeResource)]
    public HarvestedMaterialType? BiomeResource { get; set; }

    [Name(PlanetSheetFields.PlanetBiomeType)]
    public BiomeTypes? PlanetBiomeType { get; set; }

    [Name(PlanetSheetFields.Civilization)]
    public string? Civilization { get; set; }

    [Name(PlanetSheetFields.DataQualityCheck)]
    public string? DataQualityCheck { get; set; }

    [Name(PlanetSheetFields.DayRadiation)]
    public float? DayRadiation { get; set; }

    [Name(PlanetSheetFields.DayStormRadiation)]
    public float? DayStormRadiation { get; set; }

    [Name(PlanetSheetFields.DayStormTemp)]
    public float? DayStormTemp { get; set; }

    [Name(PlanetSheetFields.DayStormToxic)]
    public float? DayStormToxic { get; set; }

    [Name(PlanetSheetFields.DayTemp)]
    public float? DayTemp { get; set; }

    [Name(PlanetSheetFields.DayToxic)]
    public float? DayToxic { get; set; }

    [Name(PlanetSheetFields.DiscoveredLinkOnWiki)]
    public string? DiscoveredLinkOnWiki { get; set; }

    [Name(PlanetSheetFields.DiscoveryDate)]
    public DateTime? DiscoveryDate { get; set; }

    [Name(PlanetSheetFields.DiscoveryPlatform)]
    public GamePlatformTypes? DiscoveryPlatform { get; set; }

    [Name(PlanetSheetFields.DiscoveredBy)]
    public string? DiscoveredBy { get; set; }

    [Name(PlanetSheetFields.DocumentSequence)]
    public int? DocumentSequence { get; set; }

    [Name(PlanetSheetFields.ExternalLink1)]
    public string? ExternalLink1 { get; set; }

    [Name(PlanetSheetFields.ExternalLink2)]
    public string? ExternalLink2 { get; set; }

    [Name(PlanetSheetFields.ExtremeWeatherExcludingMegaExotic)]
    public PlanetExtremeWeatherTypes? ExtremeWeatherExcludingMegaExotic { get; set; }

    [Name(PlanetSheetFields.ExtremeWeatherIncludingMegaExotic)]
    public PlanetExtremeWeatherTypes? ExtremeWeatherIncludingMegaExotic { get; set; }

    [Name(PlanetSheetFields.Extras)]
    public HashSet<UniqueMaterialTypes> Extras { get; set; } = [];

    [Name(PlanetSheetFields.FaunaLevelCategory)]
    public PlanetBiotaLevelTypes? FaunaLevelCategory { get; set; }

    [Name(PlanetSheetFields.FloraLevelCategory)]
    public PlanetBiotaLevelTypes? FloraLevelCategory { get; set; }

    [Name(PlanetSheetFields.Galaxy)]
    public GalaxyTypes? Galaxy { get; set; }

    [Name(PlanetSheetFields.HasGarden)]
    public bool? HasGarden { get; set; }

    [Name(PlanetSheetFields.GameVersionNumberForPage)]
    public float? GameVersionNumberForPage { get; set; }

    [Name(PlanetSheetFields.Geology)]
    public GeologyTypes? Geology { get; set; }

    [Name(PlanetSheetFields.Glitches)]
    public GlitchMaterialTypes? Glitches { get; set; }

    [Name(PlanetSheetFields.HasSandworms)]
    public bool? HasSandworms { get; set; }

    [Name(PlanetSheetFields.HistoricalPlanetDiscoverCreditBeforeReset)]
    public string? HistoricalPlanetDiscoverCreditBeforeReset { get; set; }

    [Name(PlanetSheetFields.HistoricalPlanetNameLastKnownEra)]
    public string? HistoricalPlanetNameLastKnownEra { get; set; }

    [Name(PlanetSheetFields.HistoricalPlanetNamePlatform)]
    public string? HistoricalPlanetNamePlatform { get; set; }

    [Name(PlanetSheetFields.HistoricalPlanetNameReset)]
    public string? HistoricalPlanetNameReset { get; set; }

    [Name(PlanetSheetFields.RingsOrGiant)]
    public bool? HasRings { get; set; }

    [Name(PlanetSheetFields.RingsOrGiant)]
    public bool? IsGasGiant { get; set; }

    [Name(PlanetSheetFields.IsInfected)]
    public bool? IsInfected { get; set; }

    [Name(PlanetSheetFields.PlanetOrMoon)]
    public bool? IsPlanet { get; set; }

    [Name(PlanetSheetFields.PlanetOrMoon)]
    public bool? IsMoon { get; set; }

    [Name(PlanetSheetFields.LegacyPCDiscoveryDate)]
    public DateTime? LegacyPCDiscoveryDate { get; set; }

    [Name(PlanetSheetFields.LegacyPCDiscoveryEra)]
    public string? LegacyPCDiscoveryEra { get; set; }

    [Name(PlanetSheetFields.LegacyPCDiscoverersGamerTagName)]
    public string? LegacyPCDiscoverersGamerTagName { get; set; }

    [Name(PlanetSheetFields.LegacyPCPlanetName)]
    public string? LegacyPCPlanetName { get; set; }

    [Name(PlanetSheetFields.LegacyPSDiscoveryDate)]
    public DateTime? LegacyPSDiscoveryDate { get; set; }

    [Name(PlanetSheetFields.LegacyPSDiscoveryEra)]
    public string? LegacyPSDiscoveryEra { get; set; }

    [Name(PlanetSheetFields.LegacyPSDiscoverersGamerTagName)]
    public string? LegacyPSDiscoverersGamerTagName { get; set; }

    [Name(PlanetSheetFields.LegacyPSPlanetName)]
    public string? LegacyPSPlanetName { get; set; }

    [Name(PlanetSheetFields.LegacyWikiLinkOther)]
    public string? LegacyWikiLinkOther { get; set; }

    [Name(PlanetSheetFields.LegacyWikiLinkPC)]
    public string? LegacyWikiLinkPC { get; set; }

    [Name(PlanetSheetFields.LegacyWikiLinkPS)]
    public string? LegacyWikiLinkPS { get; set; }

    [Name(PlanetSheetFields.LegacyWikiLinkXbox)]
    public string? LegacyWikiLinkXbox { get; set; }

    [Name(PlanetSheetFields.LegacyXboxDiscoveryEra)]
    public string? LegacyXboxDiscoveryEra { get; set; }

    [Name(PlanetSheetFields.LegacyXboxDiscoverersGamerTagName)]
    public string? LegacyXboxDiscoverersGamerTagName { get; set; }

    [Name(PlanetSheetFields.LegacyXboxDiscoveryDate)]
    public DateTime? LegacyXboxDiscoveryDate { get; set; }

    [Name(PlanetSheetFields.LegacyXboxPlanetName)]
    public string? LegacyXboxPlanetName { get; set; }

    [Name(PlanetSheetFields.GameModeType)]
    public GameModeTypes? GameModeType { get; set; }

    [Name(PlanetSheetFields.PlanetName)]
    public string? PlanetName { get; set; }

    [Name(PlanetSheetFields.NightStormTemp)]
    public float? NightStormTemp { get; set; }

    [Name(PlanetSheetFields.NightTemp)]
    public float? NightTemp { get; set; }

    [Name(PlanetSheetFields.NumberOfFauna)]
    public int? NumberOfFauna { get; set; }

    [Name(PlanetSheetFields.OriginalPlanetName)]
    public string? OriginalPlanetName { get; set; }

    [Name(PlanetSheetFields.OtherNotes)]
    public string? OtherNotes { get; set; }

    [Name(PlanetSheetFields.PlanetGlyphs)]
    public string? PlanetGlyphs { get; set; }

    [Name(PlanetSheetFields.PlanetIdInSystem)]
    public int? PlanetIdInSystem { get; set; }

    [Name(PlanetSheetFields.PlanetMoonMatch)]
    public string? PlanetMoonMatch { get; set; }

    [Name(PlanetSheetFields.PlanetNameAllPlatforms)]
    public string? PlanetNameAllPlatforms { get; set; }

    [Name(PlanetSheetFields.PlanetOrMoonAddedInOrigins)]
    public bool? PlanetOrMoonAddedInOrigins { get; set; }

    [Name(PlanetSheetFields.PortalRepository)]
    public string? PortalRepository { get; set; }

    [Name(PlanetSheetFields.PrimaryCoreElement)]
    public PlanetaryCoreTypes? PrimaryCoreElement { get; set; }

    [Name(PlanetSheetFields.PrimaryResource)]
    public HashSet<HarvestedMaterialType> PrimaryResource { get; set; } = [];

    [Name(PlanetSheetFields.RawIngredients)]
    public HashSet<EdibleMaterialTypes> RawIngredients { get; set; } = [];

    [Name(PlanetSheetFields.RegionName)]
    public string? RegionName { get; set; }

    [Name(PlanetSheetFields.ResearchTeam)]
    public string? ResearchTeam { get; set; }

    [Name(PlanetSheetFields.SentinelActivity)]
    public SentinelActivityTypes? SentinelActivity { get; set; }

    [Name(PlanetSheetFields.SpecialResource)]
    public HashSet<PlanetPropertyTypes> SpecialResource { get; set; } = [];

    [Name(PlanetSheetFields.StarSystemName)]
    public string? StarSystemName { get; set; }

    [Name(PlanetSheetFields.SummaryInfo)]
    public string? SummaryInfo { get; set; }

    [Name(PlanetSheetFields.SurveyDate)]
    public string? SurveyDate { get; set; }

    [Name(PlanetSheetFields.GameReleaseName)]
    public string? GameReleaseName { get; set; }

    [Name(PlanetSheetFields.SurveyedBy)]
    public string? SurveyedBy { get; set; }

    [Name(PlanetSheetFields.PlanetTerrain)]
    public TerrainTypes? PlanetTerrain { get; set; }

    [Name(PlanetSheetFields.PlanetLandType)]
    public LandTypes? PlanetLandType { get; set; }

    [Name(PlanetSheetFields.UndergroundDayRadiation)]
    public float? UndergroundDayRadiation { get; set; }

    [Name(PlanetSheetFields.UndergroundDayStormRadiation)]
    public float? UndergroundDayStormRadiation { get; set; }

    [Name(PlanetSheetFields.UndergroundDayStormTemp)]
    public float? UndergroundDayStormTemp { get; set; }

    [Name(PlanetSheetFields.UndergroundDayStormToxic)]
    public float? UndergroundDayStormToxic { get; set; }

    [Name(PlanetSheetFields.UndergroundDayTemp)]
    public float? UndergroundDayTemp { get; set; }

    [Name(PlanetSheetFields.UndergroundDayToxic)]
    public float? UndergroundDayToxic { get; set; }

    [Name(PlanetSheetFields.UndergroundNightStormTemp)]
    public float? UndergroundNightStormTemp { get; set; }

    [Name(PlanetSheetFields.UndergroundNightTemp)]
    public float? UndergroundNightTemp { get; set; }

    [Name(PlanetSheetFields.UnderwaterDayRadiation)]
    public float? UnderwaterDayRadiation { get; set; }

    [Name(PlanetSheetFields.UnderwaterDayStormRadiation)]
    public float? UnderwaterDayStormRadiation { get; set; }

    [Name(PlanetSheetFields.UnderwaterDayStormTemp)]
    public float? UnderwaterDayStormTemp { get; set; }

    [Name(PlanetSheetFields.UnderwaterDayStormToxic)]
    public float? UnderwaterDayStormToxic { get; set; }

    [Name(PlanetSheetFields.UnderwaterDayTemp)]
    public float? UnderwaterDayTemp { get; set; }

    [Name(PlanetSheetFields.UnderwaterDayToxic)]
    public float? UnderwaterDayToxic { get; set; }

    [Name(PlanetSheetFields.UnderwaterNightStormTemp)]
    public float? UnderwaterNightStormTemp { get; set; }

    [Name(PlanetSheetFields.UnderwaterNightTemp)]
    public float? UnderwaterNightTemp { get; set; }

    [Name(PlanetSheetFields.PlanetWeather)]
    public WeatherTypes? PlanetWeather { get; set; }

    [Name(PlanetSheetFields.WikiLink)]
    public string? WikiLink { get; set; }
}