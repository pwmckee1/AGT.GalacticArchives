using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Core.Models.Metadata;

namespace AGT.GalacticArchives.Core.Models.Requests;

public abstract class BaseSubmissionRequest
{
    public string? Username { get; set; }

    public string? GamerTagHandle { get; set; }

    public GalaxyTypes? GalaxyName { get; set; }

    public string? RegionName { get; set; }

    public string? PlanetName { get; set; }

    public string? StarSystemName { get; set; }

    public string? GalacticCoordinates { get; set; }

    public string? SurveyorName { get; set; }

    public DateTime? DateOfSurvey { get; set; }

    public string? DiscoveredBy { get; set; }

    public DateTime? DiscoveryDate { get; set; }

    public DateTime? RegionDiscoveryDate { get; set; }

    public DateTime? StarSystemDiscoveryDate { get; set; }

    public DateTime? PlanetDiscoveryDate { get; set; }

    public string? StarSystemDiscovererName { get; set; }

    public string? PlanetDiscovererName { get; set; }

    public float? Latitude { get; set; }

    public float? Longitude { get; set; }

    public GamePlatformTypes? PlatformType { get; set; }

    public GameRelease? GameRelease { get; set; }

    public GameModeTypes? GameMode { get; set; }

    public string? CivilizationName { get; set; }

    public string? Discord { get; set; }

    public string? Email { get; set; }

    public string? NmsFriendCode { get; set; }

    public string? RedditName { get; set; }

    public string? TwitterName { get; set; }

    public string? AdditionalNotes { get; set; }

    public HashSet<string> WebLinks { get; set; } = [];
}