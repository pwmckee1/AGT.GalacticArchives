using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum WormStomachTypes
{
    Burrowing = 1,
    Large,
    [Display(ResourceType = typeof(FaunaResource), Description = nameof(FaunaResource.WraithLike))]
    WraithLike,
}