using AGT.GalacticArchives.Core.Models.Enums;

namespace AGT.GalacticArchives.Core.Models.Requests.Entities.UserSubmissions;

public class HistoricalEventSubmissionRequest
{
    public string Username { get; set; } = null!;

    public string CreditIdentification { get; set; } = null!;

    public string? ContactInformation { get; set; }

    public string EventTitle { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string Description { get; set; } = null!;

    public GalaxyTypes? Galaxy { get; set; }

    public string RegionName { get; set; } = null!;

    public string StarSystemName { get; set; } = null!;

    public string GalacticCoordinates { get; set; } = null!;

    public string PlanetName { get; set; } = null!;

    public float? Latitude { get; set; }

    public float? Longitude { get; set; }

    public DateTime? StarSystemDiscoveryDate { get; set; }

    public string StarSystemDiscovererName { get; set; } = null!;

    public DateTime? PlanetDiscoveryDate { get; set; }

    public string? PlanetDiscovererName { get; set; }

    public GamePlatformType? GamePlatform { get; set; }

    public GameModeTypes? GameMode { get; set; }

    public HashSet<string> WebLinks { get; set; } = [];
}