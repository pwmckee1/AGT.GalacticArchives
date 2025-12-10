using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum FaunaDietTypes
{
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.AbsorbedNutrients))]
    AbsorbedNutrients = 1,
    Algae,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.AlgalParticulates))]
    AlgalParticulates,
    Anything,
    Birds,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.BloodDrinker))]
    BloodDrinker,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.BoiledMeat))]
    BoiledMeat,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.BrainMatter))]
    BrainMatter,
    Cadmium,
    Cannibal,
    Carnivore,
    Carnivorous,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.CaveMarrow))]
    CaveMarrow,
    Chemosynthesis,
    CoagulatedBlood,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.CollectsSeeds))]
    CollectsSeeds,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.CondensedCarbon))]
    CondensedCarbon,
    Coprite,
    Coral,
    Corpses,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.CosmicRays))]
    CosmicRays,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.CrunchesBones))]
    CrunchesBones,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.DecayingAtoms))]
    DecayingAtoms,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.DecayingPlantLife))]
    DecayingPlantLife,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.DeepwaterAlgae))]
    DeepwaterAlgae,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.DeepwaterSpores))]
    DeepwaterSpores,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.DiHydrogenCrystals))]
    DiHydrogenCrystals,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.DigsForTubers))]
    DigsForTubers,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.DriftingPlants))]
    DriftingPlants,
    Echinocactus,
    Eggs,
    Emeril,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.ExtractsBoneMarrow))]
    ExtractsBoneMarrow,
    Faeces,
    Faecium,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.FetidMeat))]
    FetidMeat,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.FleshChunks))]
    FleshChunks,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.FleshEater))]
    FleshEater,
    Flowers,
    Foliage,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.ForagedLeftovers))]
    ForagedLeftovers,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.ForagedNuts))]
    ForagedNuts,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.FreshLeaves))]
    FreshLeaves,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.FreshMeat))]
    FreshMeat,
    Frostwort,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.FrozenMeat))]
    FrozenMeat,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.FungalCluster))]
    FungalCluster,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.GammaWeed))]
    GammaWeed,
    Grass,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.GravitinoBalls))]
    GravitinoBalls,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.GrazingCreature))]
    GrazingCreature,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.GroundMeat))]
    GroundMeat,
    Herbivore,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.HighInCalcium))]
    HighInCalcium,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.HuntsSquid))]
    HuntsSquid,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.HydrothermalMinerals))]
    HydrothermalMinerals,
    Hypercarnivore,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.HypnotisesPrey))]
    HypnotisesPrey,
    Indium,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.InsectEater))]
    InsectEater,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.InsectsAndGrubs))]
    InsectsAndGrubs,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.KelpSacs))]
    KelpSacs,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.LargeMammals))]
    LargeMammals,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.LiquidisedOrgans))]
    LiquidisedOrgans,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.LivingSponges))]
    LivingSponges,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.MarineDetritus))]
    MarineDetritus,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.MarineSnow))]
    MarineSnow,
    Meat,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.MeatChunks))]
    MeatChunks,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.MeatEater))]
    MeatEater,
    Mordite,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.MorditeRoot))]
    MorditeRoot,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.MostlyRocks))]
    MostlyRocks,
    Nectar,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.NibblesAtMoss))]
    NibblesAtMoss,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.NibblesAtShoots))]
    NibblesAtShoots,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.NipnipBuds))]
    NipnipBuds,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.NitrousOxide))]
    NitrousOxide,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.NutritiousWaterWeeds))]
    NutritiousWaterWeeds,
    Offal,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.OldBones))]
    OldBones,
    Organs,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.OtherCarnivores))]
    OtherCarnivores,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.OtherFish))]
    OtherFish,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.OxideElements))]
    OxideElements,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.PartiallyDigestedMeat))]
    PartiallyDigestedMeat,
    Petals,
    Plankton,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.PlantRoots))]
    PlantRoots,
    Pollen,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.PreservedMeat))]
    PreservedMeat,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.ProcessesDirt))]
    ProcessesDirt,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.PutrefiedMeat))]
    PutrefiedMeat,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.RadioactiveMeat))]
    RadioactiveMeat,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.RawMeat))]
    RawMeat,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.RemovedHearts))]
    RemovedHearts,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.RottenMeat))]
    RottenMeat,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.RottenWood))]
    RottenWood,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.RottingFruit))]
    RottingFruit,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.ScavengedRemains))]
    ScavengedRemains,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.ScavengedScraps))]
    ScavengedScraps,
    Scavenger,
    Seaweed,
    Silicates,
    Sinew,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.SmallAnimals))]
    SmallAnimals,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.SmallCrustaceans))]
    SmallCrustaceans,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.SmallFruit))]
    SmallFruit,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.SmallTrees))]
    SmallTrees,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.SolarVine))]
    SolarVine,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.StarBramble))]
    StarBramble,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.StealsFromOthers))]
    StealsFromOthers,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.StingingLeaves))]
    StingingLeaves,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.TallGrasses))]
    TallGrasses,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.ToxicMeat))]
    ToxicMeat,
    Vegetation,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.VenomUrchins))]
    VenomUrchins,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.VentedMinerals))]
    VentedMinerals,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.WaterFiltration))]
    WaterFiltration,
    [Display(
        ResourceType = typeof(FaunaDietResource),
        Description = nameof(FaunaDietResource.WaterVines))]
    WaterVines,
    Worms,
}