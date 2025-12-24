using AGT.GalacticArchives.Core.Models.Enums.StarSystem;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class RegionRequest : GameEntityRequest
{
    public GalacticQuadrantTypes? GalacticQuadrant { get; set; }

    public string? EarliestKnownSurveyor { get; set; }

    public string? LatestKnownSurveyor { get; set; }

    public string? SummaryNotes { get; set; }

    public string? LocationNotes { get; set; }

    public string? CivilizedSpaceNotes { get; set; }

    public float? RegionAge { get; set; }

    public string? LowestKnownPhantomSystem { get; set; }

    public string? ExternalLink1 { get; set; }

    public string? VideoLink1 { get; set; }

    public int? LightYearsFromCenter { get; set; }

    public string? EarliestSystemDiscovery { get; set; }

    public string? BaseCoordinates { get; set; }

    public string? EarliestSurveyorWikiUser { get; set; }

    public string? LatestSurveyorWikiUser { get; set; }

    public string? AdminNotes { get; set; }

    public string? LegacyName { get; set; }

    public string? LegacyWikilink { get; set; }
}