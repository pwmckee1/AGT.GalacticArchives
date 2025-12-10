using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum WormStomachTypes
{
    Burrowing,
    Large,
    [Display(ResourceType = typeof(FaunaResource), Description = nameof(FaunaResource.WraithLike))]
    WraithLike,
}