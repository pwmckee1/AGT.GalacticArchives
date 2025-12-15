using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization.Planet;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum EdibleRawMaterialTypes
{
    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.CactusNectar))]
    CactusNectar = 1,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.CrabApple))]
    CrabApple,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.CreatureEgg))]
    CreatureEgg,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.DiploChunks))]
    DiploChunks,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.FelineLiver))]
    FelineLiver,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.FiendishRoe))]
    FiendishRoe,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.FreshMilk))]
    FreshMilk,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.GiantEgg))]
    GiantEgg,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.GlassGrains))]
    GlassGrains,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.HeptaploidWheat))]
    HeptaploidWheat,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.KelpRice))]
    KelpRice,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.LegMeat))]
    LegMeat,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.LeopardFruit))]
    LeopardFruit,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.MarrowFlesh))]
    MarrowFlesh,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.MeatFlakes))]
    MeatFlakes,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.MeatyChunks))]
    MeatyChunks,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.MeatyWings))]
    MeatyWings,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.NonToxicMushroom))]
    NonToxicMushroom,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.OffalSac))]
    OffalSac,

    Pilgrimberry,
    Protosausage,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.PulpyRoots))]
    PulpyRoots,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.RawSteak))]
    RawSteak,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.RegisGrease))]
    RegisGrease,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.SaltyFingers))]
    SaltyFingers,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.ScalyMeat))]
    ScalyMeat,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.SievertBeans))]
    SievertBeans,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.SiliconEgg))]
    SiliconEgg,

    Solartillo,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.SteamedVegetables))]
    SteamedVegetables,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.StickyHoney))]
    StickyHoney,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.StriderSausage))]
    StriderSausage,

    Sweetroot,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.TallEggs))]
    TallEggs,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.WarmProtoMilk))]
    WarmProtoMilk,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.WildMilk))]
    WildMilk,

    [Display(
        ResourceType = typeof(EdibleRawMaterialTypeResource),
        Description = nameof(EdibleRawMaterialTypeResource.WildYeast))]
    WildYeast,
}