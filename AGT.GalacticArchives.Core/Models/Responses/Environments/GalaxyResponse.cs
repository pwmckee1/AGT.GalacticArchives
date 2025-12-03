namespace AGT.GalacticArchives.Core.Models.Responses.Environments;

public class GalaxyResponse
{
    public Guid? GalaxyId { get; set; }

    public string? Name { get; set; }

    public required int Sequence { get; set; }
}