using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum UniqueMaterialTypes
{
    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.AlbumenPearlOrb))]
    AlbumenPearlOrb,
    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.CreatureEgg))]
    CreatureEgg,
    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.CrystalSulphide))]
    CrystalSulphide,
    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.FloatingCrystal))]
    FloatingCrystal,
    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.GravitinoBall))]
    GravitinoBall,
    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.HummingSac))]
    HummingSac,
    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.LivingPearl))]
    LivingPearl,
    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.SacVenom))]
    SacVenom,
    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.SentientPlant))]
    SentientPlant,
    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.StormCrystal))]
    StormCrystal,
}