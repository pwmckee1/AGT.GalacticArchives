using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

namespace AGT.GalacticArchives.Core.Models.GameEntities;

public class Planet : DatabaseGameEntity
{
    public override Guid? PlanetId { get; set; } = Guid.NewGuid();

    public override Guid EntityId => PlanetId ?? Guid.NewGuid();

    public override string? PlanetName { get; set; }

    public string? PlanetNameAllPlatforms { get; set; }

    public string? AdminNotes { get; set; }

    public string? DataQualityCheck { get; set; }

    public string? OriginalPlanetName { get; set; }

    public string? PlanetMoonMatch { get; set; }

    public bool? IsPlanet { get; set; }

    public bool? IsMoon { get; set; }

    public bool? HasRings { get; set; }

    public bool? IsGasGiant { get; set; }

    public int? PlanetIdInSystem { get; set; }

    public BiomeTypes? PlanetBiomeType { get; set; }

    public BiomeSubTypes? PlanetBiomeDescription { get; set; }

    public bool? IsInfected { get; set; }

    public TerrainTypes? PlanetTerrain { get; set; }

    public LandTypes? PlanetLandType { get; set; }

    public LandArchetypes? ArchetypeOfLand { get; set; }

    public WeatherTypes? PlanetWeather { get; set; }

    public PlanetExtremeWeatherTypes? ExtremeWeatherExcludingMegaExotic { get; set; }

    public PlanetExtremeWeatherTypes? ExtremeWeatherIncludingMegaExotic { get; set; }

    public bool? HasMegaExoticExtremeWeather { get; set; }

    public HashSet<HarvestedMaterialTypes> PrimaryResources { get; set; } = [];

    public HarvestedMaterialTypes? BiomeResource { get; set; }

    public HarvestedMaterialTypes? AtmosphereResource { get; set; }

    public AtmosphereColorTypes? AtmosphereDaytimeColor { get; set; }

    public HashSet<PlanetPropertyTypes> SpecialResources { get; set; } = [];

    public HashSet<UniqueMaterialTypes> Extras { get; set; } = [];

    public GlitchMaterialTypes? Glitches { get; set; }

    public EdibleMaterialTypes? AssignedRawIngredient { get; set; }

    public HashSet<EdibleRawMaterialTypes> RawIngredients { get; set; } = [];

    public SentinelActivityTypes? SentinelActivity { get; set; }

    public PlanetBiotaLevelTypes? FloraLevelCategory { get; set; }

    public PlanetBiotaLevelTypes? FaunaLevelCategory { get; set; }

    public int? NumberOfFauna { get; set; }

    public string? SummaryInfo { get; set; }

    public float? DayTemp { get; set; }

    public float? DayRadiation { get; set; }

    public float? DayToxic { get; set; }

    public float? NightTemp { get; set; }

    public float? DayStormTemp { get; set; }

    public float? DayStormRadiation { get; set; }

    public float? DayStormToxic { get; set; }

    public float? NightStormTemp { get; set; }

    public float? UndergroundDayTemp { get; set; }

    public float? UndergroundDayRadiation { get; set; }

    public float? UndergroundDayToxic { get; set; }

    public float? UndergroundNightTemp { get; set; }

    public float? UnderwaterDayTemp { get; set; }

    public float? UnderwaterDayRadiation { get; set; }

    public float? UnderwaterDayToxic { get; set; }

    public float? UnderwaterNightTemp { get; set; }

    public float? UnderwaterDayStormTemp { get; set; }

    public float? UnderwaterDayStormRadiation { get; set; }

    public float? UnderwaterDayStormToxic { get; set; }

    public float? UnderwaterNightStormTemp { get; set; }

    public float? UndergroundDayStormTemp { get; set; }

    public float? UndergroundDayStormRadiation { get; set; }

    public float? UndergroundDayStormToxic { get; set; }

    public float? UndergroundNightStormTemp { get; set; }

    public int? AgeOfPlanetInBillionsOfYears { get; set; }

    public AtmosphereGasTypes? AtmosphereGas1 { get; set; }

    public float? AtmosphereGasPercentage1 { get; set; }

    public AtmosphereGasTypes? AtmosphereGas2 { get; set; }

    public float? AtmosphereGasPercentage2 { get; set; }

    public PlanetaryCoreTypes? PrimaryCoreElement { get; set; }

    public GeologyTypes? Geology { get; set; }

    public string? OtherNotes { get; set; }

    public bool? HasSandworms { get; set; }

    public bool? HasGarden { get; set; }

    public string? PortalRepository { get; set; }

    public string? ExternalLink1 { get; set; }

    public string? ExternalLink2 { get; set; }

    public string? Garden { get; set; }

    public string? ResearchTeam { get; set; }

    public bool? PlanetOrMoonAddedInOrigins { get; set; }

    public string? LegacyPCPlanetName { get; set; }

    public string? LegacyPCDiscoveryEra { get; set; }

    public string? LegacyPCDiscoverersGamerTagName { get; set; }

    public DateTimeOffset? LegacyPCDiscoveryDate { get; set; }

    public string? LegacyPSPlanetName { get; set; }

    public string? LegacyPSDiscoveryEra { get; set; }

    public string? LegacyPSDiscoverersGamerTagName { get; set; }

    public DateTimeOffset? LegacyPSDiscoveryDate { get; set; }

    public string? LegacyXboxPlanetName { get; set; }

    public string? LegacyXboxDiscoveryEra { get; set; }

    public string? LegacyXboxDiscoverersGamerTagName { get; set; }

    public DateTimeOffset? LegacyXboxDiscoveryDate { get; set; }

    public string? HistoricalPlanetNameReset { get; set; }

    public string? HistoricalPlanetNamePlatform { get; set; }

    public string? HistoricalPlanetNameLastKnownEra { get; set; }

    public string? HistoricalPlanetDiscoverCreditBeforeReset { get; set; }

    public string? LegacyWikiLinkPC { get; set; }

    public string? LegacyWikiLinkPS { get; set; }

    public string? LegacyWikiLinkXbox { get; set; }

    public string? LegacyWikiLinkOther { get; set; }
}