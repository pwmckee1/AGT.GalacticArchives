using AGT.GalacticArchives.Core.Models.Requests.BaseRequests;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class PointOfInterestRequest : InnerSystemRequestEntity
{
    public string? Type { get; set; }

    public string? YYFirstCoordinate { get; set; }

    public string? XXSecondCoordinate { get; set; }

    public string? NotesOrDescription { get; set; }

    public string? DateOfSurvey { get; set; }

    public string? Surveyor { get; set; }

    public string? Release { get; set; }
}