using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum WormVariantTypes
{
    Arrakis = 1,
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