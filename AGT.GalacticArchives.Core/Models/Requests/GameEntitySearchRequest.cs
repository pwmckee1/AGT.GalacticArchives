using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class GameEntitySearchRequest : BaseSearchRequest
{
    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public int? DocumentSequence { get; set; }

    public GalaxyTypes? Galaxy { get; set; }

    public int? GalaxySequence { get; set; }

    public Guid? RegionId { get; set; }

    public string? RegionName { get; set; }

    public Guid? StarSystemId { get; set; }

    public string? StarSystemName { get; set; }

    public Guid? PlanetId { get; set; }

    public string? PlanetName { get; set; }

    public string? GalacticCoordinates { get; set; }

    public string? GlyphHexCode { get; set; }

    public string? SurveyedBy { get; set; }

    public DateTimeOffset? SurveyDate { get; set; }

    public string? DiscoveredBy { get; set; }

    public DateTimeOffset? DiscoveryDate { get; set; }

    public string? Civilization { get; set; }

    public GameModeTypes? GameModeType { get; set; }

    public GamePlatformTypes? GamePlatformType { get; set; }

    public string? GameReleaseVersionNumber { get; set; }

    public string? GameRelease { get; set; }

    public DateTimeOffset? GameReleaseDate { get; set; }
}