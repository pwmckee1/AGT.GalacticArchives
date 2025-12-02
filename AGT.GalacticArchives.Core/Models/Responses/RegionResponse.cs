using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Models.Responses;

public class RegionResponse
{
    public Guid RegionId { get; set; }

    public string Name { get; set; } = null!;

    public Guid GalaxyId { get; set; }

    public HashSet<StarSystem> StarSystems { get; set; } = [];

    public Galaxy? Galaxy { get; set; }

    public string? CivilizedBy { get; set; }

    public string? Coordinates { get; set; }

    public string? Quadrant { get; set; }

    public string? XX { get; set; }

    public string? YY { get; set; }

    public string? ZZ { get; set; }

    public int? DocSequence { get; set; }

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
}