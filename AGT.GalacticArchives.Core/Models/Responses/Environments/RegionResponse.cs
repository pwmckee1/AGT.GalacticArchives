namespace AGT.GalacticArchives.Core.Models.Responses.Environments;

public class RegionResponse
{
    public Guid? RegionId { get; set; }

    public string? Name { get; set; }

    public HashSet<StarSystemResponse> StarSystems { get; set; } = [];

    public string? CivilizedBy { get; set; }

    public string? Coordinates { get; set; }

    public string? Quadrant { get; set; }

    public string? XX { get; set; }

    public string? YY { get; set; }

    public string? ZZ { get; set; }

    public int? DocSequence { get; set; }

    public string? GameRelease { get; set; }

    public string? EarliestKnownSurveyor { get; set; }

    public string? LatestKnownSurveyor { get; set; }

    public string? SurveyDate { get; set; }

    public string? SummaryNotes { get; set; }

    public string? LocationNotes { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? CivilizedSpaceNotes { get; set; }

    public float? RegionAge { get; set; }

    public string? LowestKnownPhantomSystem { get; set; }

    public string? WikiLink { get; set; }

    public string? ExternalLink1 { get; set; }

    public string? VideoLink1 { get; set; }

    public int? LightYearsFromCenter { get; set; }

    public string? EarliestSystemDiscovery { get; set; }

    public string? BaseCoord { get; set; }

    public string? EarliestSurveyorWikiUser { get; set; }

    public string? LatestSurveyorWikiUser { get; set; }

    public string? AdminNotes { get; set; }

    public string? LegacyName { get; set; }

    public string? LegacyWikilink { get; set; }

    public float? XXdec { get; set; }

    public float? YYdec { get; set; }

    public float? ZZdec { get; set; }

    public string? Glylphs { get; set; }

    public string? Version { get; set; }
}