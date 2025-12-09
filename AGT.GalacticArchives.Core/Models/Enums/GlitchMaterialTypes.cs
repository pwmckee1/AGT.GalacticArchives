using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum GlitchMaterialTypes
{
    [Display(ResourceType = typeof(GlitchTypeResource), Description = nameof(GlitchTypeResource.CablePod))]
    CablePod,

    [Display(ResourceType = typeof(GlitchTypeResource), Description = nameof(GlitchTypeResource.Calcishroom))]
    Calcishroom,

    [Display(ResourceType = typeof(GlitchTypeResource), Description = nameof(GlitchTypeResource.CapilliaryShell))]
    CapilliaryShell,

    [Display(ResourceType = typeof(GlitchTypeResource), Description = nameof(GlitchTypeResource.ElectricCube))]
    ElectricCube,

    [Display(ResourceType = typeof(GlitchTypeResource), Description = nameof(GlitchTypeResource.GlitchingSeparator))]
    GlitchingSeparator,

    [Display(ResourceType = typeof(GlitchTypeResource), Description = nameof(GlitchTypeResource.HexplateBush))]
    HexplateBush,

    [Display(ResourceType = typeof(GlitchTypeResource), Description = nameof(GlitchTypeResource.LightFissure))]
    LightFissure,

    [Display(ResourceType = typeof(GlitchTypeResource), Description = nameof(GlitchTypeResource.OssifiedStar))]
    OssifiedStar,

    [Display(ResourceType = typeof(GlitchTypeResource), Description = nameof(GlitchTypeResource.RattleSpine))]
    RattleSpine,

    [Display(ResourceType = typeof(GlitchTypeResource), Description = nameof(GlitchTypeResource.TerbiumGrowth))]
    TerbiumGrowth,
}