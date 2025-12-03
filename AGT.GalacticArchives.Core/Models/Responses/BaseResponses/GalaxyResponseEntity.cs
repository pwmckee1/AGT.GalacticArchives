namespace AGT.GalacticArchives.Core.Models.Responses.BaseResponses;

public class GalaxyResponseEntity : DatabaseResponseEntity
{
    public required Guid GalaxyId { get; set; }

    public required GalaxyResponse Galaxy { get; set; }
}