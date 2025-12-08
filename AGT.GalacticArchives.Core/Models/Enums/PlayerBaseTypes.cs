using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum PlayerBaseTypes
{
    Aerial,
    Aquatic,
    Cave,
    Ground,
    Underground,

    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.UpperAtmosphere))]
    UpperAtmosphere,

    [Display(ResourceType = typeof(PlayerBaseResource), Description = nameof(PlayerBaseResource.WaterSurface))]
    WaterSurface,
}