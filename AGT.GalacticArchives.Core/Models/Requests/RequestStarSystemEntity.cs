namespace AGT.GalacticArchives.Core.Models.Requests;

public class RequestStarSystemEntity : RequestRegionEntity
{
    public Guid? StarSystemId { get; set; }

    public StarSystemRequest? StarSystem { get; set; }
}