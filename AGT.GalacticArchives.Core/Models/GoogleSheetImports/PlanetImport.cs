using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Enums;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class PlanetImport : IGoogleSheetImport
{
    [Name(PlanetSheetFields.AgeOfPlanetInBillionsOfYears)]
    public string? AgeOfPlanetInBillionsOfYears { get; set; }

    [Name(PlanetSheetFields.AdminNotes)]
    public string? AdminNotes { get; set; }

    [Name(PlanetSheetFields.AdditionalNotes)]
    public string? AdditionalNotes { get; set; }

    [Name(PlanetSheetFields.ArchetypeOfLand)]
    public PlanetLandArchetypes? ArchetypeOfLand { get; set; }

    [Name(PlanetSheetFields.AssignedRawIngredient)]
    public string? AssignedRawIngredient { get; set; }

    [Name(PlanetSheetFields.AtmosphereGas1)]
    public ExoticMaterialTypes? AtmosphereGas1 { get; set; }

    [Name(PlanetSheetFields.AtmosphereGas2)]
    public ExoticMaterialTypes? AtmosphereGas2 { get; set; }

    [Name(PlanetSheetFields.AtmosphereGasPercentage1)]
    public string? AtmosphereGasPercentage1 { get; set; }

    [Name(PlanetSheetFields.AtmosphereGasPercentage2)]
    public string? AtmosphereGasPercentage2 { get; set; }

    [Name(PlanetSheetFields.AtmosphereDaytimeColor)]
    public AtmosphereColorTypes? AtmosphereDaytimeColor { get; set; }

    [Name(PlanetSheetFields.AtmosphereResource)]
    public ExoticMaterialTypes? AtmosphereResource { get; set; }

    [Name(PlanetSheetFields.BiomeDescription)]
    public BiomeSubTypes? PlanetBiomeDescription { get; set; }

    [Name(PlanetSheetFields.BiomeResource)]
    public ExoticMaterialTypes? BiomeResource { get; set; }

    [Name(PlanetSheetFields.BiomeType)]
    public BiomeTypes? PlanetBiomeType { get; set; }

    [Name(PlanetSheetFields.CivilizedBy)]
    public string? CivilizedBy { get; set; }

    [Name(PlanetSheetFields.DataQualityCheck)]
    public string? DataQualityCheck { get; set; }

    [Name(PlanetSheetFields.DayRadiation)]
    public string? DayRadiation { get; set; }

    [Name(PlanetSheetFields.DayStormRadiation)]
    public string? DayStormRadiation { get; set; }

    [Name(PlanetSheetFields.DayStormTemp)]
    public string? DayStormTemp { get; set; }

    [Name(PlanetSheetFields.DayStormToxic)]
    public string? DayStormToxic { get; set; }

    [Name(PlanetSheetFields.DayTemp)]
    public string? DayTemp { get; set; }

    [Name(PlanetSheetFields.DayToxic)]
    public string? DayToxic { get; set; }

    [Name(PlanetSheetFields.DiscoveredLinkOnWiki)]
    public string? DiscoveredLinkOnWiki { get; set; }

    [Name(PlanetSheetFields.DiscoveryDate)]
    public string? DiscoveryDate { get; set; }

    [Name(PlanetSheetFields.DiscoveryPlatform)]
    public string? DiscoveryPlatform { get; set; }

    [Name(PlanetSheetFields.DiscovererGamertag)]
    public string? DiscovererGamertag { get; set; }

    [Name(PlanetSheetFields.DocumentSequence)]
    public string? DocumentSequence { get; set; }

    [Name(PlanetSheetFields.ExternalLink1)]
    public string? ExternalLink1 { get; set; }

    [Name(PlanetSheetFields.ExternalLink2)]
    public string? ExternalLink2 { get; set; }

    [Name(PlanetSheetFields.ExtremeWeatherExcludingMegaExotic)]
    public PlanetExtremeWeatherTypes? ExtremeWeatherExcludingMegaExotic { get; set; }

    [Name(PlanetSheetFields.ExtremeWeatherIncludingMegaExotic)]
    public string? ExtremeWeatherIncludingMegaExotic { get; set; }

    [Name(PlanetSheetFields.ExtrasA)]
    public string? ExtrasA { get; set; }

    [Name(PlanetSheetFields.ExtrasB)]
    public string? ExtrasB { get; set; }

    [Name(PlanetSheetFields.ExtrasC)]
    public string? ExtrasC { get; set; }

    [Name(PlanetSheetFields.FaunaCategory)]
    public string? FaunaCategory { get; set; }

    [Name(PlanetSheetFields.Flora)]
    public string? Flora { get; set; }

    [Name(PlanetSheetFields.Galaxy)]
    public string? Galaxy { get; set; }

    [Name(PlanetSheetFields.GalaxyName)]
    public string? GalaxyName { get; set; }

    [Name(PlanetSheetFields.Garden)]
    public string? Garden { get; set; }

    [Name(PlanetSheetFields.GameVersionNumberForPage)]
    public string? GameVersionNumberForPage { get; set; }

    [Name(PlanetSheetFields.Geology)]
    public string? Geology { get; set; }

    [Name(PlanetSheetFields.Glitches)]
    public string? Glitches { get; set; }

    [Name(PlanetSheetFields.HasSandworms)]
    public string? HasSandworms { get; set; }

    [Name(PlanetSheetFields.HistoricalPlanetDiscoverCreditBeforeReset)]
    public string? HistoricalPlanetDiscoverCreditBeforeReset { get; set; }

    [Name(PlanetSheetFields.HistoricalPlanetNameLastKnownEra)]
    public string? HistoricalPlanetNameLastKnownEra { get; set; }

    [Name(PlanetSheetFields.HistoricalPlanetNamePlatform)]
    public string? HistoricalPlanetNamePlatform { get; set; }

    [Name(PlanetSheetFields.HistoricalPlanetNameReset)]
    public string? HistoricalPlanetNameReset { get; set; }

    [Name(PlanetSheetFields.RingsOrGiant)]
    public bool HasRings { get; set; }

    [Name(PlanetSheetFields.RingsOrGiant)]
    public bool IsGasGiant { get; set; }

    [Name(PlanetSheetFields.IsInfected)]
    public bool IsInfected { get; set; }

    [Name(PlanetSheetFields.PlanetOrMoon)]
    public bool IsPlanet { get; set; }

    [Name(PlanetSheetFields.PlanetOrMoon)]
    public bool IsMoon { get; set; }

    [Name(PlanetSheetFields.LegacyPCDiscoveryDate)]
    public string? LegacyPCDiscoveryDate { get; set; }

    [Name(PlanetSheetFields.LegacyPCDiscoveryEra)]
    public string? LegacyPCDiscoveryEra { get; set; }

    [Name(PlanetSheetFields.LegacyPCDiscoverersGamerTagName)]
    public string? LegacyPCDiscoverersGamerTagName { get; set; }

    [Name(PlanetSheetFields.LegacyPCPlanetName)]
    public string? LegacyPCPlanetName { get; set; }

    [Name(PlanetSheetFields.LegacyPSDiscoveryDate)]
    public string? LegacyPSDiscoveryDate { get; set; }

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
    public string? LegacyXboxDiscoveryDate { get; set; }

    [Name(PlanetSheetFields.LegacyXboxPlanetName)]
    public string? LegacyXboxPlanetName { get; set; }

    [Name(PlanetSheetFields.GameModeType)]
    public GameModeTypes? GameModeType { get; set; }

    [Name(PlanetSheetFields.Name)]
    public string? Name { get; set; }

    [Name(PlanetSheetFields.NightStormTemp)]
    public float? NightStormTemp { get; set; }

    [Name(PlanetSheetFields.NightTemp)]
    public float? NightTemp { get; set; }

    [Name(PlanetSheetFields.NumberOfFauna)]
    public string? NumberOfFauna { get; set; }

    [Name(PlanetSheetFields.OriginalPlanetName)]
    public string? OriginalPlanetName { get; set; }

    [Name(PlanetSheetFields.OtherNotes)]
    public string? OtherNotes { get; set; }

    [Name(PlanetSheetFields.PlanetGlyphs)]
    public string? PlanetGlyphs { get; set; }

    [Name(PlanetSheetFields.PlanetIdInSystem)]
    public string? PlanetIdInSystem { get; set; }

    [Name(PlanetSheetFields.PlanetMoonMatch)]
    public string? PlanetMoonMatch { get; set; }

    [Name(PlanetSheetFields.PlanetNameAllPlatforms)]
    public string? PlanetNameAllPlatforms { get; set; }

    [Name(PlanetSheetFields.PlanetOrMoon)]
    public string? PlanetOrMoon { get; set; }

    [Name(PlanetSheetFields.PlanetOrMoonAddedInOrigins)]
    public string? PlanetOrMoonAddedInOrigins { get; set; }

    [Name(PlanetSheetFields.PortalRepository)]
    public string? PortalRepository { get; set; }

    [Name(PlanetSheetFields.PrimaryCoreElement)]
    public string? PrimaryCoreElement { get; set; }

    [Name(PlanetSheetFields.PrimaryResource1)]
    public ExoticMaterialTypes? PrimaryResource1 { get; set; }

    [Name(PlanetSheetFields.PrimaryResource2)]
    public ExoticMaterialTypes? PrimaryResource2 { get; set; }

    [Name(PlanetSheetFields.PrimaryResource3)]
    public ExoticMaterialTypes? PrimaryResource3 { get; set; }

    [Name(PlanetSheetFields.RawIngredients)]
    public HashSet<string> RawIngredients { get; set; } = [];

    [Name(PlanetSheetFields.Region)]
    public string? Region { get; set; }

    [Name(PlanetSheetFields.RegionName)]
    public string? RegionName { get; set; }

    [Name(PlanetSheetFields.ResearchTeam)]
    public string? ResearchTeam { get; set; }

    [Name(PlanetSheetFields.RingsOrGiant)]
    public string? RingsOrGiant { get; set; }

    [Name(PlanetSheetFields.Sentinel)]
    public string? Sentinel { get; set; }

    [Name(PlanetSheetFields.SpecialA)]
    public string? SpecialA { get; set; }

    [Name(PlanetSheetFields.StarSystemName)]
    public string? StarSystemName { get; set; }

    [Name(PlanetSheetFields.SummaryInfo)]
    public string? SummaryInfo { get; set; }

    [Name(PlanetSheetFields.SurveyDate)]
    public string? SurveyDate { get; set; }

    [Name(PlanetSheetFields.SurveyReleaseEra)]
    public string? SurveyReleaseEra { get; set; }

    [Name(PlanetSheetFields.SurveyorGamertag)]
    public string? SurveyorGamertag { get; set; }

    [Name(PlanetSheetFields.System)]
    public string? System { get; set; }

    [Name(PlanetSheetFields.Terrain)]
    public TerrainTypes? PlanetTerrain { get; set; }

    [Name(PlanetSheetFields.LandType)]
    public LandTypes? PlanetLandType { get; set; }

    [Name(PlanetSheetFields.UndergroundDayRadiation)]
    public string? UndergroundDayRadiation { get; set; }

    [Name(PlanetSheetFields.UndergroundDayStormRadiation)]
    public string? UndergroundDayStormRadiation { get; set; }

    [Name(PlanetSheetFields.UndergroundDayStormTemp)]
    public string? UndergroundDayStormTemp { get; set; }

    [Name(PlanetSheetFields.UndergroundDayStormToxic)]
    public string? UndergroundDayStormToxic { get; set; }

    [Name(PlanetSheetFields.UndergroundDayTemp)]
    public string? UndergroundDayTemp { get; set; }

    [Name(PlanetSheetFields.UndergroundDayToxic)]
    public string? UndergroundDayToxic { get; set; }

    [Name(PlanetSheetFields.UndergroundNightStormTemp)]
    public string? UndergroundNightStormTemp { get; set; }

    [Name(PlanetSheetFields.UndergroundNightTemp)]
    public string? UndergroundNightTemp { get; set; }

    [Name(PlanetSheetFields.UnderwaterDayRadiation)]
    public string? UnderwaterDayRadiation { get; set; }

    [Name(PlanetSheetFields.UnderwaterDayStormRadiation)]
    public string? UnderwaterDayStormRadiation { get; set; }

    [Name(PlanetSheetFields.UnderwaterDayStormTemp)]
    public string? UnderwaterDayStormTemp { get; set; }

    [Name(PlanetSheetFields.UnderwaterDayStormToxic)]
    public string? UnderwaterDayStormToxic { get; set; }

    [Name(PlanetSheetFields.UnderwaterDayTemp)]
    public string? UnderwaterDayTemp { get; set; }

    [Name(PlanetSheetFields.UnderwaterDayToxic)]
    public string? UnderwaterDayToxic { get; set; }

    [Name(PlanetSheetFields.UnderwaterNightStormTemp)]
    public string? UnderwaterNightStormTemp { get; set; }

    [Name(PlanetSheetFields.UnderwaterNightTemp)]
    public string? UnderwaterNightTemp { get; set; }

    [Name(PlanetSheetFields.Weather)]
    public PlanetWeatherTypes? PlanetWeather { get; set; }

    [Name(PlanetSheetFields.WikiLink)]
    public string? WikiLink { get; set; }
}