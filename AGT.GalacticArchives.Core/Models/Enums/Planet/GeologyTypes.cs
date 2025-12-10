using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum GeologyTypes
{
    Aberrant = 1,
    Abhorrent,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.AlarminglySymmetric))]
    AlarminglySymmetric,
    Algebraic,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.AncientTunnels))]
    AncientTunnels,
    Animated,
    Anomalous,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.AntiGravitational))]
    AntiGravitational,

    [Display(
        ResourceType = typeof(GeologyTypeResource),
        Description = nameof(GeologyTypeResource.ArtificiallyStructured))]
    ArtificiallyStructured,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.BasaltPlumes))]
    BasaltPlumes,
    Bisected,
    Blistered,
    Bombarded,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.BoredOutInternals))]
    BoredOutInternals,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.BuriedRifts))]
    BuriedRifts,

    [Display(
        ResourceType = typeof(GeologyTypeResource),
        Description = nameof(GeologyTypeResource.CarvedByAncientRivers))]
    CarvedByAncientRivers,
    Cavernous,
    Computative,
    Craggy,
    Cratered,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.CreepingFissures))]
    CreepingFissures,
    Crystalline,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.CuriouslyRegular))]
    CuriouslyRegular,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.DeepChasm))]
    DeepChasm,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.DeepClefts))]
    DeepClefts,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.DeepHollows))]
    DeepHollows,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.DeepMagmaChambers))]
    DeepMagmaChambers,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.DeepSaltLayers))]
    DeepSaltLayers,
    Dense,
    Divergent,
    Dynamic,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.ElectroDynamic))]
    ElectroDynamic,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.ElectroMagnetic))]
    ElectroMagnetic,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.ErodedValleys))]
    ErodedValleys,
    Exotic,

    [Display(
        ResourceType = typeof(GeologyTypeResource),
        Description = nameof(GeologyTypeResource.ExtensiveMeteorImpacts))]
    ExtensiveMeteorImpacts,

    [Display(
        ResourceType = typeof(GeologyTypeResource),
        Description = nameof(GeologyTypeResource.ExtensiveMeteorImpacts))]
    ExtensiveUndergroundCaverns,
    Fabricated,
    Foliated,

    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.FrequentCalderas))]
    FrequentCalderas,
    Geometric,
    Gorged,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.HeavilyMetallic))]
    HeavilyMetallic,
    Heteroclite,
    Hilly,
    Igneous,
    Impermeable,
    Irregular,
    Kinematic,
    Limestone,
    Latticed,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.LurkingCapstones))]
    LurkingCapstones,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.LurkingVoids))]
    LurkingVoids,
    Mathematic,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.MeanderingFaults))]
    MeanderingFaults,
    Metallic,
    Metamorphic,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.MineralRich))]
    MineralRich,
    Monolithic,
    Montane,
    Mountainous,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.MultiDimensional))]
    MultiDimensional,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.NonPorous))]
    NonPorous,
    Oxidised,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.PartiallyOrganic))]
    PartiallyOrganic,
    Pillared,
    Polygonal,
    Porous,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.PostGlacial))]
    PostGlacial,
    Recycled,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.RiftValleys))]
    RiftValleys,
    Riven,
    Rocky,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.RockySpires))]
    RockySpires,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.RollingDowns))]
    RollingDowns,
    Rugged,
    Sedimentary,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.ShapedByComets))]
    ShapedByComets,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.ShapedByGiants))]
    ShapedByGiants,
    Sloping,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.SnakingProtusions))]
    SnakingProtusions,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.SpongeLike))]
    SpongeLike,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.StoneMonoliths))]
    StoneMonoliths,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.StructuralValleys))]
    StructuralValleys,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.SunkenColossi))]
    SunkenColossi,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.SunkenFissures))]
    SunkenFissures,
    Superconductive,
    Synthetic,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.TectonicCollisions))]
    TectonicCollisions,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.TectonicSkeletons))]
    TectonicSkeletons,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.ToweringUplands))]
    ToweringUplands,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.UltraMagnetic))]
    UltraMagnetic,
    Uncanny,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.UndergroundCaverns))]
    UndergroundCaverns,
    Undulating,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.UnevenMineralDistribution))]
    UnevenMineralDistribution,
    Unnatural,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.UnnaturalCrevasses))]
    UnnaturalCrevasses,
    Unorthodox,
    Unstable,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.UplandValleys))]
    UplandValleys,
    Vaulted,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.VeryThinMantle))]
    VeryThinMantle,
    Volcanic,
    [Display(ResourceType = typeof(GeologyTypeResource), Description = nameof(GeologyTypeResource.VolcanicStacks))]
    VolcanicStacks,
}