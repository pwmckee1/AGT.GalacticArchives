using AGT.GalacticArchives.Core.Models.Responses.BaseResponses;

namespace AGT.GalacticArchives.Core.Models.Responses;

public class PointOfInterestResponse : StarSystemResponseEntity
{
    public string? Type { get; set; }

    public string? YYFirstCoordinate { get; set; }

    public string? XXSecondCoordinate { get; set; }

    public string? NotesOrDescription { get; set; }

    public string? DateOfSurvey { get; set; }

    public string? Surveyor { get; set; }

    public string? Release { get; set; }
}