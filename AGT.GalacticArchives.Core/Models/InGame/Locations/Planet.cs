using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

namespace AGT.GalacticArchives.Core.Models.InGame.Locations;

public class Planet : DatabaseGameEntity
{
    public override Guid? PlanetId { get; set; } = Guid.NewGuid();

    public override Guid EntityId => PlanetId ?? Guid.NewGuid();

    public string? PlanetNameAllPlatforms { get; set; }

    public string? AdminNotes { get; set; }

    public string? DataQualityCheck { get; set; }

    public string? OriginalPlanetName { get; set; }

    public string? PlanetMoonMatch { get; set; }

    public string? PlanetOrMoon { get; set; }

    public string? RingsOrGiant { get; set; }

    public int? PlanetIdInSystem { get; set; }

    public BiomeTypes? BiomeType { get; set; }

    public BiomeSubTypes? BiomeDescription { get; set; }

    public bool? IsInfected { get; set; }

    public TerrainTypes? Terrain { get; set; }

    public LandTypes? TypeOfLand { get; set; }

    public LandArchetypes? LandArchetype { get; set; }

    public WeatherTypes? Weather { get; set; }

    public PlanetExtremeWeatherTypes? ExtremeWeatherExcludingMegaExotic { get; set; }

    public bool? HasMegaExoticExtremeWeather { get; set; }

    public HarvestedMaterialType? PrimaryResource1 { get; set; }

    public HarvestedMaterialType? PrimaryResource2 { get; set; }

    public HarvestedMaterialType? PrimaryResource3 { get; set; }

    public HarvestedMaterialType? BiomeResource { get; set; }

    public HarvestedMaterialType? AtmosphereResource { get; set; }

    public AtmosphereColorTypes? AtmosphereDaytimeColor { get; set; }

    public PlanetPropertyTypes? SpecialA { get; set; }

    public UniqueMaterialTypes? ExtrasA { get; set; }

    public UniqueMaterialTypes? ExtrasB { get; set; }

    public UniqueMaterialTypes? ExtrasC { get; set; }

    public GlitchMaterialTypes? Glitches { get; set; }

    public string? AssignedRawIngredient { get; set; }

    public HashSet<EdibleMaterialTypes?> RawIngredients { get; set; } = [];

    public SentinelActivityTypes? Sentinel { get; set; }

    public PlanetBiotaLevelTypes? Flora { get; set; }

    public PlanetBiotaLevelTypes? FaunaCategory { get; set; }

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

    public AtmosphereMaterialTypes? AtmosphereGas2 { get; set; }

    public float? AtmosphereGasPercentage2 { get; set; }

    public HarvestedMaterialType? PrimaryCoreElement { get; set; }

    public GeologyTypes? Geology { get; set; }

    public string? OtherNotes { get; set; }

    public bool? HasSandworms { get; set; }

    public string? PortalRepository { get; set; }

    public string? ExternalLink1 { get; set; }

    public string? ExternalLink2 { get; set; }

    public string? Garden { get; set; }

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
}