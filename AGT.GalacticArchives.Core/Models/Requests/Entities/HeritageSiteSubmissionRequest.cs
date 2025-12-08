using AGT.GalacticArchives.Core.Models.Enums;

namespace AGT.GalacticArchives.Core.Models.Requests.Entities;

public class HeritageSiteSubmissionRequest
{
    public string Username { get; set; } = null!;

    public GalaxyTypes? Galaxy { get; set; }

    public string RegionName { get; set; } = null!;

    public string StarSystemName { get; set; } = null!;

    public string GalacticCoordinates { get; set; } = null!;

    public string PlanetName { get; set; } = null!;

    public float? Latitude { get; set; }

    public float? Longitude { get; set; }

    public string GamerTagHandle { get; set; } = null!;

    public string ReasonForHeritageStatus { get; set; } = null!;

    public string ContactInformation { get; set; } = null!;
}