using System.Text.RegularExpressions;
using AGT.GalacticArchives.Core.Enums;
using AGT.GalacticArchives.Core.Interfaces.GameData;

namespace AGT.GalacticArchives.Core.Models.GameData;

public partial class Region : IGameData
{
    private string? _coordinates;
    private static readonly Regex CoordinatesPattern = CoordinateRegexPattern();

    public Guid EntityId => RegionId;

    public Guid RegionId { get; set; } = Guid.NewGuid();

    public required string Name { get; set; }

    public string NormalizedName => Name.ToUpperInvariant();

    public Guid? GalaxyId { get; set; }

    public string? CivilizedBy { get; set; }

    public string? Coordinates
    {
        get => _coordinates;
        set
        {
            value = value != null ? value.ToUpperInvariant() : value;
            if (!string.IsNullOrEmpty(value) && !CoordinatesPattern.IsMatch(value))
            {
                throw new ArgumentException(
                    "Coordinates must match pattern 'XXXX:XXXX:XXXX' where X is a hexadecimal digit",
                    nameof(value));
            }

            _coordinates = value;
        }
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

    public DateTimeOffset? EarliestSystemDiscovery { get; set; }

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

    public Dictionary<string, object?> ToDictionary()
    {
        return new Dictionary<string, object?>
        {
            { nameof(RegionId), RegionId.ToString() },
            { nameof(Name), Name },
            { nameof(NormalizedName), NormalizedName },
            { nameof(GalaxyId), GalaxyId.ToString() },
            { nameof(CivilizedBy), CivilizedBy },
            { nameof(Coordinates), Coordinates },
            { nameof(Quadrant), Quadrant },
            { nameof(XX), XX },
            { nameof(YY), YY },
            { nameof(ZZ), ZZ },
            { nameof(DocSequence), DocSequence },
            { nameof(GameRelease), GameRelease },
            { nameof(EarliestKnownSurveyorId), EarliestKnownSurveyorId },
            { nameof(LatestKnownSurveyorId), LatestKnownSurveyorId },
            { nameof(AutoLatestSurvey), AutoLatestSurvey },
            { nameof(SummaryNotes), SummaryNotes },
            { nameof(LocationNotes), LocationNotes },
            { nameof(AdditionalNotes), AdditionalNotes },
            { nameof(CivilizedSpaceNotes), CivilizedSpaceNotes },
            { nameof(RegionAge), RegionAge },
            { nameof(LowestKnownPhantomSystem), LowestKnownPhantomSystem },
            { nameof(WikiLink), WikiLink },
            { nameof(ExternalLink1), ExternalLink1 },
            { nameof(VideoLink1), VideoLink1 },
        };
    }

    [GeneratedRegex(@"^[0-9A-F]{4}:[0-9A-F]{4}:[0-9A-F]{4}:[0-9A-F|XXXX]{4}$", RegexOptions.IgnoreCase, "en-US")]
    private static partial Regex CoordinateRegexPattern();
}