using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.Meta;

namespace AGT.GalacticArchives.Core.Models.Requests.Entities;

public class SettlementSubmissionRequest
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

    public GameRelease? GameRelease { get; set; }
}