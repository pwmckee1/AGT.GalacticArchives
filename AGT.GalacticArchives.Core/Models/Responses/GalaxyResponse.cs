using AGT.GalacticArchives.Core.Models.Responses.BaseResponses;

namespace AGT.GalacticArchives.Core.Models.Responses;

public class GalaxyResponse : DatabaseResponseEntity
{
    public required int Sequence { get; set; }
}