namespace AGT.GalacticArchives.Core.Models.Requests.BaseRequests;

public class InnerSystemRequestEntity : RegionRequestEntity
{
    public Guid? StarSystemId { get; set; }

    public StarSystemRequest? StarSystem { get; set; }

    public Guid? PlanetId { get; set; }

    public PlanetRequest? Planet { get; set; }
}