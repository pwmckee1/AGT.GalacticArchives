using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Models.Responses;

public class PointOfInterestResponse
{
    public Guid PointOfInterestId { get; set; }

    public string Name { get; set; } = null!;

    public Guid PlanetId { get; set; }

    public Planet? Planet { get; set; }

    public string? Type { get; set; }

    public string? YYFirstCoordinate { get; set; }

    public string? XXSecondCoordinate { get; set; }

    public string? NotesOrDescription { get; set; }

    public string? DateOfSurvey { get; set; }

    public string? Surveyor { get; set; }

    public string? Release { get; set; }
}