using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class PointOfInterestRequest : GameDataRequest
{
    public Guid? PointOfInterestId { get; set; }

    public string? PointOfInterestName { get; set; }

    public Guid? PlanetId { get; set; }

    public Planet? Planet { get; set; }

    public string? Type { get; set; }

    public string? YYFirstCoordinate { get; set; }

    public string? XXSecondCoordinate { get; set; }

    public string? NotesOrDescription { get; set; }

    public string? DateOfSurvey { get; set; }

    public string? Surveyor { get; set; }

    public string? Release { get; set; }
}