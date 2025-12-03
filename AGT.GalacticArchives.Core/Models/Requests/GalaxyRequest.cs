namespace AGT.GalacticArchives.Core.Models.Requests;

public class GalaxyRequest : DatabaseEntityRequest
{
    public Guid? GalaxyId { get; set; }

    public GalaxyRequest? Galaxy { get; set; }

    public int? Sequence { get; set; }
}