using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.Meta;

namespace AGT.GalacticArchives.Core.Models.Requests.Entities;

public class PlayerBaseSubmissionRequest
{
    public string Username { get; set; } = null!;

    public string PlayerBaseName { get; set; } = null!;

    public Communities? CivilizationClaim { get; set; }

    public PlayerBaseClassificationTypes? Classification { get; set; }

    public GamePlatformType? GamePlatform { get; set; }

    public GameModeTypes? GameMode { get; set; }

    public GameRelease? GameRelease { get; set; }

    public GalaxyTypes? Galaxy { get; set; }

    public string? RegionName { get; set; }

    public string? StarSystemName { get; set; }

    public string? GalacticCoordinates { get; set; }

    public string? PlanetName { get; set; }

    public string? PlanetGlyph { get; set; }

    public float? Latitude { get; set; }

    public float? Longitude { get; set; }

    public string? NameOfPlayerBaseBuilder { get; set; }

    public PlayerBaseTypes? BaseType { get; set; }

    public bool HasFarmProduction { get; set; }

    public bool HasGeobay { get; set; }

    public bool HasPvpArena { get; set; }

    public bool HasLandingPad { get; set; }

    public bool HasRaceTrack { get; set; }

    public bool HasTradeTerminal { get; set; }

    public PlayerBaseNearbyPOITypes NearbyPOITypes { get; set; }

    public DateTime? ConstructionStarted { get; set; }

    public DateTime? ConstructionEnded { get; set; }

    public DateTime? DateOfSurvey { get; set; }

    public string? SurveyorName { get; set; }

    public PlayerBasePowerTypes? PowerConditions { get; set; }

    public PlayerBaseTerrainTypes? TerrainSituation { get; set; }

    // Convert to MaterialType records
    public HashSet<string> MineralExtractorContents { get; set; } = [];

    public string? MineralExtractorCapacity { get; set; }

    public HashSet<AtmosphereGasTypes> GasExtractorContents { get; set; } = [];

    public string? GasExtractorCapacity { get; set; }

    public HashSet<PlayerBaseElementTypes> PlayerBaseElements { get; set; } = [];

    public string? GamerTagHandle { get; set; }

    public string? Discord { get; set; }

    public string? Email { get; set; }

    public string? NmsFriendCode { get; set; }

    public string? RedditName { get; set; }

    public string? TwitterName { get; set; }
}