using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum HarvestedMaterialTypes
{
    Carbon = 1,
    Chlorine,
    Cobalt,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.CytoPhosphate))]
    CytoPhosphate,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.CondensedCarbon))]
    CondensedCarbon,
    Deuterium,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.Dihydrogen))]
    Dihydrogen,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.FerriteDust))]
    FerriteDust,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.IonisedCobalt))]
    IonisedCobalt,

    [Display(
        ResourceType = typeof(MaterialsResourceType),
        Description = nameof(MaterialsResourceType.MagnetisedFerrite))]
    MagnetisedFerrite,
    Oxygen,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.PureFerrite))]
    PureFerrite,
    Salt,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.SilicatePowder))]
    SilicatePowder,
    Sodium,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.SodiumNitrate))]
    SodiumNitrate,
    Tritium,

    [Display(
        ResourceType = typeof(MaterialsResourceType),
        Description = nameof(MaterialsResourceType.ActivatedCadmium))]
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

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.VortexCube))]
    VortexCube,
    Argon,

    [Display(
        ResourceType = typeof(AtmosphereGasTypeResource),
        Description = nameof(AtmosphereGasTypeResource.CarbonDioxide))]
    CarbonDioxide,

    [Display(
        ResourceType = typeof(AtmosphereGasTypeResource),
        Description = nameof(AtmosphereGasTypeResource.CarbonMonoxide))]
    CarbonMonoxide,
    Chrysonite,
    DiHydrogen,
    Fluorine,
    Helium,
    Hyglese,
    Methane,
    Neon,

    [Display(
        ResourceType = typeof(AtmosphereGasTypeResource),
        Description = nameof(AtmosphereGasTypeResource.NotPresent))]
    NotPresent,
    Pxygen,
    Radnox,
    Thamium,
    Thamium9,

    [Display(ResourceType = typeof(EdiblePlantResource), Description = nameof(EdiblePlantResource.AloeFlesh))]
    AloeFlesh,
    Hexaberry,

    [Display(ResourceType = typeof(EdiblePlantResource), Description = nameof(EdiblePlantResource.FrozenTubers))]
    FrozenTubers,
    Grahberry,

    [Display(ResourceType = typeof(EdiblePlantResource), Description = nameof(EdiblePlantResource.ImpulseBeans))]
    ImpulseBeans,
    Fireberry,

    [Display(ResourceType = typeof(EdiblePlantResource), Description = nameof(EdiblePlantResource.JadePeas))]
    JadePeas,

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