using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum WormHeadTypes
{
    Arrakis,
    Dragon,
    Fangs,
    Fish,
    Glowworm,
    Lips,
    [Display(ResourceType = typeof(FaunaResource), Description = nameof(FaunaResource.RoundMouth))]
    RoundMouth,
    Sarlacc,
    Stubby,
}