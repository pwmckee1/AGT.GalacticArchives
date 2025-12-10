using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class PlanetSubmissionRequest : BaseSubmissionRequest
{
    public string? OriginalPlanetName { get; set; }

    public string? DiscoverersName { get; set; }

    public bool? IsPlanet { get; set; }

    public string? PlanetThatItOrbits { get; set; }

    // Hexadecimal value of the first glyph in planet coordinates
    public string? PlanetGlyph { get; set; }

    public BiomeTypes Biome { get; set; }

    public BiomeSubTypes? BiomeSubType { get; set; }

    public TerrainTypes? PlanetTerrain { get; set; }

    public LandTypes? TypeOfLand { get; set; }

    public TerrainArchetypes? TerrainArchetypes { get; set; }

    public WeatherTypes? PlanetWeather { get; set; }

    public HashSet<ExoticMaterialTypes> Resources { get; set; } = [];

    public HashSet<PlanetPropertyTypes> SpecialResources { get; set; } = [];

    public HashSet<UniqueMaterialTypes> SpecialItems { get; set; } = [];

    public AtmosphereColorTypes? AtmosphereDaytimeColor { get; set; }

    public GlitchMaterialTypes? ExoticCollectibles { get; set; }

    public SentinelActivityTypes? SentinelActivity { get; set; }

    public PlanetBiotaLevelTypes? FloraLevels { get; set; }

    public PlanetBiotaLevelTypes? FaunaLevels { get; set; }

    public int? FaunaTypeQty { get; set; }

    public bool? HasSandworms { get; set; }

    public float? PlanetAge { get; set; }

    public AtmosphereMaterialTypes? AtmosphereGas { get; set; }

    public float? AtmosphereGasComposition { get; set; }

    public PlanetaryCoreTypes? PrimaryCoreElement { get; set; }

    public GeologyTypes? Geology { get; set; }

    public string? OtherNotes { get; set; }

    public string? PortalCoords { get; set; }

    public string? NotesAboutTheDiscovery { get; set; }

    public string? DiscoveryScreen { get; set; }

    public string? PlanetSurfaceScan { get; set; }
}