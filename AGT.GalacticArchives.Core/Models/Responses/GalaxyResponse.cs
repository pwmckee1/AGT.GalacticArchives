using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Models.Responses;

public class GalaxyResponse
{
    public Guid GalaxyId { get; set; }

    public string Name { get; set; } = null!;

    public int Sequence { get; set; }

    public HashSet<Region> Regions { get; set; } = [];
}