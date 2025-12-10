using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum SpaceStationTradeItemTypes
{
    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.AutonomousPositioningUnit))]
    AutonomousPositioningUnit = 1,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.BannedWeapons))]
    BannedWeapons,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.BloodSalt))]
    BloodSalt,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.BromideSalt))]
    BromideSalt,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.CarbonNanotubes))]
    CarbonNanotubes,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.CometDroplets))]
    CometDroplets,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.CounterfeitCircuits))]
    CounterfeitCircuits,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.DecommissionedCircuitBoard))]
    DecommissionedCircuitBoard,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.DecommissionedCircuits))]
    DecommissionedCircuits,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.DecryptedUserData))]
    DecryptedUserData,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.DeScentedBottles))]
    DeScentedBottles,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.DeScentedPheromoneBottle))]
    DeScentedPheromoneBottle,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.Dirt))]
    Dirt,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.EnormousMetalCog))]
    EnormousMetalCog,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.ExperimentalPowerFluid))]
    ExperimentalPowerFluid,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.FirstSpawnRelics))]
    FirstSpawnRelics,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.FiveDimensionalTorus))]
    FiveDimensionalTorus,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.FiveDTorus))]
    FiveDTorus,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.FusionCore))]
    FusionCore,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.GrahGrah))]
    GrahGrah,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.HighCapacityVectorCompressor))]
    HighCapacityVectorCompressor,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.HolographicCrankshaft))]
    HolographicCrankshaft,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.IndustrialGradeBattery))]
    IndustrialGradeBattery,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.InstabilityInjector))]
    InstabilityInjector,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.IonCapacitor))]
    IonCapacitor,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.IonSphere))]
    IonSphere,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.MeshDecouplers))]
    MeshDecouplers,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.MoonEther))]
    MoonEther,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.NanotubeCrate))]
    NanotubeCrate,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.NeuralDuct))]
    NeuralDuct,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.NeutronMicroscope))]
    NeutronMicroscope,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.NipNipBuds))]
    NipNipBuds,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.NonStickPiston))]
    NonStickPiston,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.OhmicGel))]
    OhmicGel,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.OpticalSolvent))]
    OpticalSolvent,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.OrganicPiping))]
    OrganicPiping,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.PolychromaticZirconium))]
    PolychromaticZirconium,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.PrismaticFeathers))]
    PrismaticFeathers,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.QuantumAccelerator))]
    QuantumAccelerator,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.RelatticedArcCrystal))]
    RelatticedArcCrystal,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.SelfRepairingHeridium))]
    SelfRepairingHeridium,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.SixProngedMeshDecoupler))]
    SixProngedMeshDecoupler,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.SparkCanister))]
    SparkCanister,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.StarSilk))]
    StarSilk,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.StolenDNASamples))]
    StolenDNASamples,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.SuperconductingFibre))]
    SuperconductingFibre,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.SuspiciousPacketGoods))]
    SuspiciousPacketGoods,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.SuspiciousPacketTechnology))]
    SuspiciousPacketTechnology,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.SuspiciousPacketWeaponry))]
    SuspiciousPacketWeaponry,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.TeleportCoordinators))]
    TeleportCoordinators,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.UnrefinedPyriteGrease))]
    UnrefinedPyriteGrease,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.VectorCompressors))]
    VectorCompressors,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.WeldingSoap))]
    WeldingSoap,
}