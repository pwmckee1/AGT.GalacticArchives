using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;

namespace AGT.GalacticArchives.Core.Models.Responses;

public class GameEntityResponse
{
    public string? NormalizedName { get; set; }

    public int? DocumentSequence { get; set; }

    public GalaxyTypes? Galaxy { get; set; }

    public int? GalaxySequence { get; set; }

    public virtual Guid? RegionId { get; set; }

    public RegionResponse? Region { get; set; }

    public virtual Guid? StarSystemId { get; set; }

    public StarSystemResponse? StarSystem { get; set; }

    public virtual Guid? PlanetId { get; set; }

    public PlanetResponse? Planet { get; set; }

    public string? GalacticCoordinates { get; set; }

    public string? GlyphHexCode { get; set; }

    public virtual string? RegionName { get; set; }

    public virtual string? StarSystemName { get; set; }

    public virtual string? PlanetName { get; set; }

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

    public DateTime? SurveyDate { get; set; }

    public string? DiscoveredBy { get; set; }

    public DateTime? DiscoveryDate { get; set; }

    public GameModeTypes? GameModeType { get; set; }

    public GamePlatformTypes? Platform { get; set; }

    public string? Civilization { get; set; }

    public string? GameRelease { get; set; }

    public string? GameReleaseVersionNumber { get; set; }

    public string? Description { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? WikiLink { get; set; }
}