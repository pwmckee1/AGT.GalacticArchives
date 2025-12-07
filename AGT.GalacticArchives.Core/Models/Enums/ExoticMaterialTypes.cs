using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum ExoticMaterialTypes
{
    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.ActivatedCadmium))]
    ActivatedCadmium,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.ActivatedCopper))]
    ActivatedCopper,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.ActivatedEmeril))]
    ActivatedEmeril,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.ActivatedIndium))]
    ActivatedIndium,

    [Display(
        ResourceType = typeof(MaterialsResourceType),
        Description = nameof(MaterialsResourceType.ActivatedQuartzite))]
    ActivatedQuartzite,
    Aluminium,
    Ammonia,
    Basalt,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.CactusFlesh))]
    CactusFlesh,
    Cadmium,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.ChromaticMetal))]
    ChromaticMetal,

    Copper,

    [Display(
        ResourceType = typeof(MaterialsResourceType),
        Description = nameof(MaterialsResourceType.CrystallisedHelium))]
    CrystallisedHelium,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.CursedDust))]
    CursedDust,

    Dioxite,

    Emeril,

    Faecium,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.FrostCrystal))]
    FrostCrystal,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.FungalMould))]
    FungalMould,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.GammaRoot))]
    GammaRoot,

    Gold,

    Heridium,

    Hexite,

    Indium,

    Iridium,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.KelpSac))]
    KelpSac,

    Lithium,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.LivingSlime))]
    LivingSlime,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.MarrowBulb))]
    MarrowBulb,

    Mordite,

    Nickel,

    Nitrogen,

    Paraffinium,

    Phosphorus,

    Platinum,

    Pugneum,

    Pyrite,

    Quartzite,

    Radon,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.ResidualGoop))]
    ResidualGoop,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.RunawayMould))]
    RunawayMould,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.RustedMetal))]
    RustedMetal,

    Silver,

    Solanium,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.StarBulb))]
    StarBulb,
    Sulphurine,
    TaintedMetal,
    Uranium,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.ViscousFluids))]
    ViscousFluids,
}