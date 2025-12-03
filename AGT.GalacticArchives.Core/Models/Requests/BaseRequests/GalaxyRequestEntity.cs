namespace AGT.GalacticArchives.Core.Models.Requests.BaseRequests;

public abstract class GalaxyRequestEntity : DatabaseEntityRequest
{
    public Guid? GalaxyId { get; set; }

    public GalaxyRequest? Galaxy { get; set; }
}