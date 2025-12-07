using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum PlanetResourceTypes
{
    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.ActivatedCadmium))]
    ActivatedCadmium = 1,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.ActivatedCopper))]
    ActivatedCopper,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.ActivatedEmeril))]
    ActivatedEmeril,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.ActivatedIndium))]
    ActivatedIndium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.ActivatedQuartzite))]
    ActivatedQuartzite,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Aluminium))]
    Aluminium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Ammonia))]
    Ammonia,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Basalt))]
    Basalt,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.CactusFlesh))]
    CactusFlesh,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Cadmium))]
    Cadmium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Carbon))]
    Carbon,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Chlorine))]
    Chlorine,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.ChromaticMetal))]
    ChromaticMetal,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Cobalt))]
    Cobalt,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.CondensedCarbon))]
    CondensedCarbon,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Copper))]
    Copper,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.CrystallisedHelium))]
    CrystallisedHelium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.CursedDust))]
    CursedDust,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.CytoPhosphate))]
    CytoPhosphate,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Deuterium))]
    Deuterium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Dihydrogen))]
    Dihydrogen,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Dioxite))]
    Dioxite,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Emeril))]
    Emeril,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Faecium))]
    Faecium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.FerriteDust))]
    FerriteDust,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.FrostCrystal))]
    FrostCrystal,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.FungalMould))]
    FungalMould,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.GammaRoot))]
    GammaRoot,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Gold))]
    Gold,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Heridium))]
    Heridium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Hexite))]
    Hexite,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Indium))]
    Indium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.IonisedCobalt))]
    IonisedCobalt,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Iridium))]
    Iridium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.KelpSac))]
    KelpSac,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Lithium))]
    Lithium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.LivingSlime))]
    LivingSlime,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.MagnetisedFerrite))]
    MagnetisedFerrite,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.MarrowBulb))]
    MarrowBulb,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Mordite))]
    Mordite,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Nickel))]
    Nickel,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Nitrogen))]
    Nitrogen,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Oxygen))]
    Oxygen,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Paraffinium))]
    Paraffinium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Phosphorus))]
    Phosphorus,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Platinum))]
    Platinum,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Pugneum))]
    Pugneum,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.PureFerrite))]
    PureFerrite,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Pyrite))]
    Pyrite,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Quartzite))]
    Quartzite,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Radon))]
    Radon,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.ResidualGoop))]
    ResidualGoop,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.RunawayMould))]
    RunawayMould,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.RustedMetal))]
    RustedMetal,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Salt))]
    Salt,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.SilicatePowder))]
    SilicatePowder,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Silver))]
    Silver,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Sodium))]
    Sodium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.SodiumNitrate))]
    SodiumNitrate,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Solanium))]
    Solanium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.StarBulb))]
    StarBulb,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Sulphurine))]
    Sulphurine,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Tritium))]
    Tritium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.Uranium))]
    Uranium,

    [Display(
        ResourceType = typeof(PlanetResourceItemsResource),
        Description = nameof(PlanetResourceItemsResource.ViscousFluids))]
    ViscousFluids,
}