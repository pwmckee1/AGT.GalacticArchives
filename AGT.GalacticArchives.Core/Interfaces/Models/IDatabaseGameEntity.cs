using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Metadata;

namespace AGT.GalacticArchives.Core.Interfaces.Models;

public interface IDatabaseGameEntity : IDatabaseEntity
{
    GalaxyTypes? Galaxy { get; set; }

    Guid? RegionId { get; set; }

    Region? Region { get; set; }

    string? GalacticCoordinates { get; set; }

    string? GlyphCode { get; }

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

    string? SurveyedBy { get; set; }

    DateTime? SurveyDate { get; set; }

    string? DiscoveredBy { get; set; }

    DateTime? DiscoveryDate { get; set; }

    GameModeTypes? GameMode { get; set; }

    GamePlatformTypes? Platform { get; set; }

    Civilization? Civilization { get; set; }

    GameRelease GameRelease { get; set; }

    string? AdditionalNotes { get; set; }
}