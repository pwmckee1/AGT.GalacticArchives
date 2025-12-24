using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Core.Interfaces.Models;

public interface IGameEntityResponse : IDatabaseEntityResponse
{
    GalaxyTypes? Galaxy { get; set; }

    int? GalaxySequence { get; set; }

    Guid? RegionId { get; set; }

    string? RegionName { get; set; }

    RegionResponse? Region { get; set; }

    Guid? StarSystemId { get; set; }

    string? StarSystemName { get; set; }

    StarSystemResponse? StarSystem { get; set; }

    Guid? PlanetId { get; set; }

    string? PlanetName { get; set; }

    PlanetResponse? Planet { get; set; }

    string? GalacticCoordinates { get; set; }

    string? GlyphHexCode { get; set; }

    /// <summary>
    /// First coordinate number when viewed in game Y.Y/X.X format
    /// </summary>
    float? YAxisPlanetCoordinate { get; set; }

    /// <summary>
    /// Second coordinate number when viewed in game Y.Y/X.X format
    /// </summary>
    float? XAxisPlanetCoordinate { get; set; }

    string? XXHex { get; set; }

    string? YYHex { get; set; }

    string? ZZHex { get; set; }

    string? SSHex { get; set; }

    int? XXDec { get; set; }

    int? YYDec { get; set; }

    int? ZZDec { get; set; }

    int? SSDec { get; set; }

    string? SurveyedBy { get; set; }

    DateTimeOffset? SurveyDate { get; set; }

    string? DiscoveredBy { get; set; }

    DateTimeOffset? DiscoveryDate { get; set; }

    GameModeTypes? GameModeType { get; set; }

    GamePlatformTypes? GamePlatformType { get; set; }

    string? Civilization { get; set; }

    string? GameRelease { get; set; }

    string? GameReleaseVersionNumber { get; set; }

    DateTimeOffset? GameReleaseDate { get; set; }

    string? Description { get; set; }

    string? AdditionalNotes { get; set; }

    string? WikiLink { get; set; }

    string? DiscoveredLinkOnWiki { get; set; }
}