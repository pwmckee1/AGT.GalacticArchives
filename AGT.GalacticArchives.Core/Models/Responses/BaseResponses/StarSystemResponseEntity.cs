namespace AGT.GalacticArchives.Core.Models.Responses.BaseResponses;

public class StarSystemResponseEntity : RegionResponseEntity
{
    public required Guid StarSystemId { get; set; }

    public required StarSystemResponse StarSystem { get; set; }
}