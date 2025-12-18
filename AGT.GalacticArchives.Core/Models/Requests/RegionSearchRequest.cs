using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class RegionSearchRequest : BaseSearchRequest
{
    public Guid? RegionId { get; set; }

    public string? RegionName { get; set; }

    public GalaxyTypes? Galaxy { get; set; }

    public string? SurveyedBy { get; set; }

    public DateTimeOffset? SurveyDate { get; set; }

    public string? DiscoveredBy { get; set; }

    public DateTimeOffset? DiscoveryDate { get; set; }

    public GameModeTypes? GameModeType { get; set; }

    public GamePlatformTypes? GamePlatformType { get; set; }

    public string? Civilization { get; set; }

    public string? GameRelease { get; set; }

    public string? GameReleaseVersionNumber { get; set; }

    public DateTimeOffset? GameReleaseDate { get; set; }
}