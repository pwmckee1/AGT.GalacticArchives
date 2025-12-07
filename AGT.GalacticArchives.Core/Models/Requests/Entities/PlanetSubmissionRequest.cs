using AGT.GalacticArchives.Core.Models.Enums;

namespace AGT.GalacticArchives.Core.Models.Requests.Entities;

public class PlanetSubmissionRequest
{
    public required string Username { get; set; }

    public required string Platform { get; set; }

    public required string GameMode { get; set; }

    public required string GameRelease { get; set; }

    public required Galaxies Galaxy { get; set; }

    public required string RegionName { get; set; }

    public required string StarSystemName { get; set; }

    public required string GalacticCoordinates { get; set; }

    public required string PlanetName { get; set; }

    public string? OriginalPlanetName { get; set; }

    public string? DiscoverersName { get; set; }

    public required string SpecialAttributes { get; set; }

    public required bool IsPlanet { get; set; }

    public string? PlanetThatItOrbits { get; set; }

    // Hexadecimal value of the first glyph in planet coordinates
    public required string PlanetGlyph { get; set; }

    public required BiomeTypes Biome { get; set; }

    public BiomeSubTypes? BiomeSubType { get; set; }

    public TerrainTypes? PlanetTerrain { get; set; }

    public LandTypes? TypeOfLand { get; set; }

    public TerrainArchetypes? TerrainArchetypes { get; set; }

    public PlanetWeatherTypes? PlanetWeather { get; set; }

    public HashSet<ExoticMaterialTypes> Resources { get; set; } = [];

    public HashSet<PlanetPropertyTypes> SpecialResources { get; set; } = [];

    public HashSet<UniqueMaterialTypes> SpecialItems { get; set; } = [];

    public AtmosphereColorTypes? AtmosphereDaytimeColor { get; set; }

    public GlitchTypes? ExoticCollectibles { get; set; }

    public SentinelActivityTypes? SentinelActivity { get; set; }

    public FloraFaunaLevelTypes? FloraLevels { get; set; }

    public FloraFaunaLevelTypes? FaunaLevels { get; set; }

    public int? FaunaTypeQty { get; set; }

    public bool? HasSandworms { get; set; }

    public float? PlanetAge { get; set; }

    public AtmosphereGasTypes? AtmosphereGas { get; set; }

    public float? AtmosphereGasComposition { get; set; }

    public PlanetaryCoreTypes? PrimaryCoreElement { get; set; }

    public GeologyTypes? Geology { get; set; }

    public string? OtherNotes { get; set; }

    public string? DateOfDiscovery { get; set; }

    public required string DiscovererId { get; set; }

    public string? DateOfSurvey { get; set; }

    public string? PortalCoords { get; set; }

    public string? NotesAboutTheDiscovery { get; set; }

    public string? DiscoveryScreen { get; set; }

    public string? PlanetSurfaceScan { get; set; }

    public string? AdditionalPlanetImages { get; set; }

    public required string GamerTagHandle { get; set; }

    public string? Discord { get; set; }

    public string? Email { get; set; }

    public string? NmsFriendCode { get; set; }

    public string? RedditName { get; set; }

    public string? TwitterName { get; set; }
}