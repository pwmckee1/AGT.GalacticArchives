using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;

namespace AGT.GalacticArchives.Core.Models.Responses;

public class GameEntityResponse
{
    public Guid? EntityId { get; set; }

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public int? DocumentSequence { get; set; }

    public GalaxyTypes? Galaxy { get; set; }

    public int? GalaxySequence { get; set; }

    public Guid? RegionId { get; set; }

    public string? RegionName { get; set; }

    public RegionResponse? Region { get; set; }

    public Guid? StarSystemId { get; set; }

    public string? StarSystemName { get; set; }

    public StarSystemResponse? StarSystem { get; set; }

    public Guid? PlanetId { get; set; }

    public string? PlanetName { get; set; }

    public PlanetResponse? Planet { get; set; }

    public string? GalacticCoordinates { get; set; }

    public string? GlyphHexCode { get; set; }

    /// <summary>
    /// First coordinate number when viewed in game Y.Y/X.X format
    /// </summary>
    public float? YAxisPlanetCoordinate { get; set; }

    /// <summary>
    /// Second coordinate number when viewed in game Y.Y/X.X format
    /// </summary>
    public float? XAxisPlanetCoordinate { get; set; }

    public string? XXHex { get; set; }

    public string? YYHex { get; set; }

    public string? ZZHex { get; set; }

    public string? SSHex { get; set; }

    public int? XXDec { get; set; }

    public int? YYDec { get; set; }

    public int? ZZDec { get; set; }

    public int? SSDec { get; set; }

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

    public string? Description { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? WikiLink { get; set; }

    public string? DiscoveredLinkOnWiki { get; set; }
}