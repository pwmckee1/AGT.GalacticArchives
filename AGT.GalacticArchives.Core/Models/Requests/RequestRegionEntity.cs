namespace AGT.GalacticArchives.Core.Models.Requests;

public abstract class RequestRegionEntity : RequestGalaxyEntity
{
    public Guid? RegionId { get; set; }

    public RegionRequest? Region { get; set; }
}