namespace AGT.GalacticArchives.Core.Models.Requests.BaseRequests;

public abstract class RegionRequestEntity : GalaxyRequestEntity
{
    public Guid? RegionId { get; set; }

    public RegionRequest? Region { get; set; }
}