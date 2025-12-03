using AGT.GalacticArchives.Core.Models.Responses.Entities;

namespace AGT.GalacticArchives.Core.Models.Responses.Environments;

public class PlanetResponse
{
    public Guid? PlanetId { get; set; }

    public string? Name { get; set; }

    public HashSet<FaunaResponse> Fauna { get; set; } = [];

    public HashSet<MultiToolResponse> MultiTools { get; set; } = [];

    public HashSet<PlayerBaseResponse> PlayerBases { get; set; } = [];

    public HashSet<PointOfInterestResponse> PointOfInterests { get; set; } = [];

    public HashSet<SettlementResponse> Settlements { get; set; } = [];

    public HashSet<StarshipResponse> Starships { get; set; } = [];

    public string? PlanetNameAllPlatforms { get; set; }

    public string? AdminNotes { get; set; }

    public string? DataQualityCheck { get; set; }

    public string? OriginalPlanetName { get; set; }

    public string? PlanetMoonMatch { get; set; }

    public string? PlanetOrMoon { get; set; }

    public string? RingsOrGiant { get; set; }

    public int? PlanetIdInSystem { get; set; }

    public string? BiomeType { get; set; }

    public string? BiomeDescription { get; set; }

    public bool? IsInfected { get; set; }

    public string? Terrain { get; set; }

    public string? TypeOfLand { get; set; }

    public string? ArchetypeOfLand { get; set; }

    public string? Weather { get; set; }

    public string? ExtremeWeatherExcludingMegaExotic { get; set; }

    public string? ExtremeWeatherInludingMegaExotic { get; set; }

    public string? PrimaryResource1 { get; set; }

    public string? PrimaryResource2 { get; set; }

    public string? PrimaryResource3 { get; set; }

    public string? BiomeResource { get; set; }

    public string? AtmosphereResource { get; set; }

    public string? AtmosphereDaytimeColor { get; set; }

    public string? SpecialA { get; set; }

    public string? ExtrasA { get; set; }

    public string? ExtrasB { get; set; }

    public string? ExtrasC { get; set; }

    public string? Glitches { get; set; }

    public string? AssignedRawIngredient { get; set; }

    public HashSet<string?> RawIngredients { get; set; } = [];

    public string? Sentinel { get; set; }

    public string? Flora { get; set; }

    public string? FaunaCategory { get; set; }

    public int? NumberOfFauna { get; set; }

    public string? Mode { get; set; }

    public string? CivilizedBy { get; set; }

    public string? DiscovererGamertag { get; set; }

    public string? DiscoveredLinkOnWiki { get; set; }

    public string? DiscoveryDate { get; set; }

    public string? SurveyorGamertag { get; set; }

    public string? SurveyDate { get; set; }

    public string? DiscoveryPlatform { get; set; }

    public string? SurveyReleaseEra { get; set; }

    public string? SummaryInfo { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? DayTemp { get; set; }

    public string? DayRadiation { get; set; }

    public string? DayToxic { get; set; }

    public string? NightTemp { get; set; }

    public string? DayStormTemp { get; set; }

    public string? DayStormRadiation { get; set; }

    public string? DayStormToxic { get; set; }

    public string? NightStormTemp { get; set; }

    public string? UndergroundDayTemp { get; set; }

    public string? UndergroundDayRadiation { get; set; }

    public string? UndergroundDayToxic { get; set; }

    public string? UndergroundNightTemp { get; set; }

    public string? UnderwaterDayTemp { get; set; }

    public string? UnderwaterDayRadiation { get; set; }

    public string? UnderwaterDayToxic { get; set; }

    public string? UnderwaterNightTemp { get; set; }

    public string? UnderwaterDayStormTemp { get; set; }

    public string? UnderwaterDayStormRadiation { get; set; }

    public string? UnderwaterDayStormToxic { get; set; }

    public string? UnderwaterNightStormTemp { get; set; }

    public string? UndergroundDayStormTemp { get; set; }

    public string? UndergroundDayStormRadiation { get; set; }

    public string? UndergroundDayStormToxic { get; set; }

    public string? UndergroundNightStormTemp { get; set; }

    public string? AgeOfPlanetInBillionsOfYears { get; set; }

    public string? AtmosphereGas1 { get; set; }

    public string? AtmosphereGasPercentage1 { get; set; }

    public string? AtmosphereGas2 { get; set; }

    public string? AtmosphereGasPercentage2 { get; set; }

    public string? PrimaryCoreElement { get; set; }

    public string? Geology { get; set; }

    public string? OtherNotes { get; set; }

    public bool? HasSandworms { get; set; }

    public string? WikiLink { get; set; }

    public string? PortalRepository { get; set; }

    public string? ExternalLink1 { get; set; }

    public string? ExternalLink2 { get; set; }

    public string? Garden { get; set; }

    public int? DocumentSequence { get; set; }

    public string? PlanetGlyphs { get; set; }

    public string? ResearchTeam { get; set; }

    public string? PlanetOrMoonAddedInOrigins { get; set; }

    public string? LegacyPCPlanetName { get; set; }

    public string? LegacyPCDiscoveryEra { get; set; }

    public string? LegacyPCDiscoverersGamerTagName { get; set; }

    public string? LegacyPCDiscoveryDate { get; set; }

    public string? LegacyPSPlanetName { get; set; }

    public string? LegacyPSDiscoveryEra { get; set; }

    public string? LegacyPSDiscoverersGamerTagName { get; set; }

    public string? LegacyPSDiscoveryDate { get; set; }

    public string? LegacyXboxPlanetName { get; set; }

    public string? LegacyXboxDiscoveryEra { get; set; }

    public string? LegacyXboxDiscoverersGamerTagName { get; set; }

    public string? LegacyXboxDiscoveryDate { get; set; }

    public string? HistoricalPlanetNameReset { get; set; }

    public string? HistoricalPlanetNamePlatform { get; set; }

    public string? HistoricalPlanetNameLastKnownEra { get; set; }

    public string? HistoricalPlanetDiscoverCreditBeforeReset { get; set; }

    public string? LegacyWikiLinkPC { get; set; }

    public string? LegacyWikiLinkPS { get; set; }

    public string? LegacyWikiLinkXbox { get; set; }

    public string? LegacyWikiLinkOther { get; set; }

    public string? GameVersionNumberForPage { get; set; }

    public int? DocSeqCheck { get; set; }
}