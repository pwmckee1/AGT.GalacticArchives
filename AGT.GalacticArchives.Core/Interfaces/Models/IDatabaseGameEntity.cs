using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Core.Models.InGame.Locations;

namespace AGT.GalacticArchives.Core.Interfaces.Models;

public interface IDatabaseGameEntity : IDatabaseEntity
{
    GalaxyTypes? Galaxy { get; set; }

    Guid? RegionId { get; set; }

    Region? Region { get; set; }

    string? GalacticCoordinates { get; set; }

    string? GlyphHexCode { get; }

    Guid? StarSystemId { get; set; }

    StarSystem? StarSystem { get; set; }

    Guid? PlanetId { get; set; }

    Planet? Planet { get; set; }

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

    DateTime? SurveyDate { get; set; }

    string? DiscoveredBy { get; set; }

    DateTime? DiscoveryDate { get; set; }

    GameModeTypes? GameModeType { get; set; }

    GamePlatformTypes? Platform { get; set; }

    string? Civilization { get; set; }

    string? GameRelease { get; set; }

    string? AdditionalNotes { get; set; }

    string? GameReleaseVersionNumber { get; set; }

    string? Description { get; set; }

    string? WikiLink { get; set; }

    int? GalaxySequence { get; set; }
}