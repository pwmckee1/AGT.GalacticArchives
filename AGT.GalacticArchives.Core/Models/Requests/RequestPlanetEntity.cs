namespace AGT.GalacticArchives.Core.Models.Requests;

public abstract class RequestPlanetEntity : RequestStarSystemEntity
{
    public Guid? PlanetId { get; set; }

    public PlanetRequest? Planet { get; set; }
}