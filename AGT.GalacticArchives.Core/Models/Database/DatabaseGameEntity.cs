using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.GameMetaData;
using AGT.GalacticArchives.Core.Models.InGame.Locations;

namespace AGT.GalacticArchives.Core.Models.Database;

public abstract class DatabaseGameEntity : DatabaseEntity, IDatabaseGameEntity
{
    public GalaxyTypes? Galaxy { get; set; }

    public Guid? RegionId { get; set; }

    public Region? Region { get; set; }

    public Guid? StarSystemId { get; set; }

    public StarSystem? StarSystem { get; set; }

    public Guid? PlanetId { get; set; }

    public Planet? Planet { get; set; }

    public string? GalacticCoordinates { get; set; }

    public string? GlyphCode { get; set; }

    /// <summary>
    /// First coordinate number when viewed in game Y.Y/X.X format
    /// </summary>
    public float? YAxisPlanetCoordinate { get; set; }

    /// <summary>
    /// Second coordinate number when viewed in game Y.Y/X.X format
    /// </summary>
    public float? XAxisPlanetCoordinate { get; set; }

    public string? SurveyedBy { get; set; }

    public DateTime? SurveyDate { get; set; }

    public string? DiscoveredBy { get; set; }

    public DateTime? DiscoveryDate { get; set; }

    public GameModeTypes? GameMode { get; set; }

    public GamePlatformType? Platform { get; set; }

    public Civilization? Civilization { get; set; }

    public GameRelease GameRelease { get; set; } = new();

    public string? Description { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? WikiLink { get; set; }
}