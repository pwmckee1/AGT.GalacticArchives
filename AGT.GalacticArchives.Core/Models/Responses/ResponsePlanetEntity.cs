namespace AGT.GalacticArchives.Core.Models.Responses;

public class ResponsePlanetEntity : ResponseStarSystemEntity
{
    public required Guid PlanetId { get; set; }

    public required PlanetResponse Planet { get; set; }
}