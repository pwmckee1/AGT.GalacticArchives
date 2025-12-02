namespace AGT.GalacticArchives.Core.Models.Requests;

public abstract class RequestGalaxyEntity : RequestGameDataEntity
{
    public Guid? GalaxyId { get; set; }

    public GalaxyRequest? Galaxy { get; set; }
}