using AGT.GalacticArchives.Core.Models.Enums;

namespace AGT.GalacticArchives.Core.Models.Requests.Entities.UserSubmissions;

public class NaturalWonderSubmissionRequest
{
    public string Username { get; set; } = null!;

    public string GamerTagHandle { get; set; } = null!;

    public GalaxyTypes? Galaxy { get; set; }

    public string GalacticCoordinates { get; set; } = null!;

    public string PlanetName { get; set; } = null!;

    public float? Latitude { get; set; }

    public float? Longitude { get; set; }

    public DateTime? StarSystemDiscoveryDate { get; set; }

    public string StarSystemDiscovererName { get; set; } = null!;

    public DateTime? PlanetDiscoveryDate { get; set; }

    public string? PlanetDiscovererName { get; set; }

    public string ReasonForStatus { get; set; } = null!;

    public string ContactInformation { get; set; } = null!;

    public string WebLink { get; set; } = null!;
}