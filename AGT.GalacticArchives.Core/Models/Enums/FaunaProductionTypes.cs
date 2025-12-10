
using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum FaunaProductionTypes
{
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.BoneNuggets))]
    BoneNuggets = 1,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.ChewyWires))]
    ChewyWires,
    Aggressive,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.CrabApple))]
    CrabApple,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.CrawMilk))]
    CrawMilk,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.CreatureEgg))]
    CreatureEgg,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.DirtyMeat))]
    DirtyMeat,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.FiendishRoe))]
    FiendishRoe,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.ForagedMushrooms))]
    ForagedMushrooms,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.FreshMilk))]
    FreshMilk,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.GiantEgg))]
    GiantEgg,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.LeopardFruit))]
    LeopardFruit,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.NourishingSlime))]
    NourishingSlime,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.RegisGrease))]
    RegisGrease,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.StickyHoney))]
    StickyHoney,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.TallEggs))]
    TallEggs,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.WarmProtoMilk))]
    WarmProtoMilk,
    [Display(
        ResourceType = typeof(FaunaResource),
        Description = nameof(FaunaResource.WildMilk))]
    WildMilk,
}