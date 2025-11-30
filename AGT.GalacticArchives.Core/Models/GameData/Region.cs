using System.Reflection;
using AGT.GalacticArchives.Core.Extensions;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class Region : GameData
{
    private string? _coordinates;

    public override Guid EntityId => RegionId;

    public Guid RegionId { get; set; } = Guid.NewGuid();

    public required string Name { get; set; }

    public string NormalizedName => Name.ToUpperInvariant();

    public Guid? GalaxyId { get; set; }

    public string? CivilizedBy { get; set; }

    public string? Coordinates
    {
        get => _coordinates;
        set => _coordinates = value.GetValidatedCoordinates();
    }

    public string? Quadrant { get; set; }

    public string XX => !string.IsNullOrEmpty(_coordinates) ? _coordinates.Split(':')[0] : string.Empty;

    public string YY => !string.IsNullOrEmpty(_coordinates) ? _coordinates.Split(':')[1] : string.Empty;

    public string ZZ => !string.IsNullOrEmpty(_coordinates) ? _coordinates.Split(':')[2] : string.Empty;

    public int DocSequence { get; set; }

    public string? GameRelease { get; set; }

    public string? EarliestKnownSurveyorId { get; set; }

    public string? LatestKnownSurveyorId { get; set; }

    public string? AutoLatestSurvey { get; set; }

    public string? SummaryNotes { get; set; }

    public string? LocationNotes { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? CivilizedSpaceNotes { get; set; }

    public float? RegionAge { get; set; }

    public string? LowestKnownPhantomSystem { get; set; }

    public string? WikiLink { get; set; }

    public string?  ExternalLink1 { get; set; }

    public string? VideoLink1 { get; set; }

    public int? LightYearsFromCenter { get; set; }

    public string? EarliestSystemDiscovery { get; set; }

    public string? BaseCoord { get; set; }

    public string? EarliestSurveyorWikiUser { get; set; }

    public string? LatestSurveyorWikiUser { get; set; }

    public string? AdminNotes { get; set; }

    public string? LegacyName { get; set; }

    public string? LegacyWikilink { get; set; }

    public string? XXdec { get; set; }

    public string? YYdec { get; set; }

    public string? ZZdec { get; set; }

    public string? Glylphs { get; set; }

    public string? Version { get; set; }

    public HashSet<StarSystem> Systems { get; set; } = [];

    public Galaxy? Galaxy { get; set; }

    public override Dictionary<string, object?> ToDictionary(
        GameData gameData = null!,
        PropertyInfo[] properties1 = null!,
        HashSet<string> excludedProperties = null!)
    {
        var properties = typeof(Region).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        excludedProperties =
        [
            nameof(EntityId),
            nameof(Systems),
            nameof(Galaxy),
        ];

        return base.ToDictionary(this, properties, excludedProperties);
    }
}