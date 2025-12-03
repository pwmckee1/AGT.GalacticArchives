namespace AGT.GalacticArchives.Core.Models.Responses.BaseResponses;

public class PlanetResponseEntity : StarSystemResponseEntity
{
    public required Guid PlanetId { get; set; }

    public required PlanetResponse Planet { get; set; }
}