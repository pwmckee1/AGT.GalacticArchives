using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization.Planet;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum BiomeSubTypes
{
    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.TheNest))]
    TheNest = 1,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.TheReliquary))]
    TheReliquary,
    Thirsty,
    Torrid,
    Toxic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ToxicAnomaly))]
    ToxicAnomaly,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ToxicHorror))]
    ToxicHorror,
    Tropical,
    Ultramarine,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.UltramarineGiant))]
    UltramarineGiant,
    Unstable,
    Vapour,
    Verdant,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.VermillionGlobe))]
    VermillionGlobe,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.VileAnomaly))]
    VileAnomaly,
    Violent,
    Viridescent,
    Volcanic,
    Waterlocked,
    Waterworld,
    Webbed,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.WindSwept))]
    WindSwept,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.WineDark))]
    WineDark,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.WormRidden))]
    WormRidden,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.XenoColony))]
    XenoColony,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.TheReliquaryLush))]
    TheReliquaryLush,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.TropicalLush))]
    TropicalLush,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.VerdantLush))]
    VerdantLush,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ViridescentLush))]
    ViridescentLush,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.WormRiddenLush))]
    WormRiddenLush,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.XenoColonyLush))]
    XenoColonyLush,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.AquaticWaterworld))]
    AquaticWaterworld,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.EndlessSeasWaterworld))]
    EndlessSeasWaterworld,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.MarineWaterworld))]
    MarineWaterworld,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.UltramarineGiantWaterworld))]
    UltramarineGiantWaterworld,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.WaterlockedWaterworld))]
    WaterlockedWaterworld,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.WaterworldWaterworld))]
    WaterworldWaterworld,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.MemoryΒTitanGasGiant))]
    MemoryΒTitanGasGiant,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.PetrifiedGiantGasGiant))]
    PetrifiedGiantGasGiant,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.Tbd3GasGiant))]
    Tbd3GasGiant,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.Tbd4GasGiant))]
    Tbd4GasGiant,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.AbandonedBarren))]
    AbandonedBarren,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.BarrenBarren))]
    BarrenBarren,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.BleakBarren))]
    BleakBarren,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.DesertBarren))]
    DesertBarren,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.DesolateBarren))]
    DesolateBarren,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.DustyBarren))]
    DustyBarren,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ParchedBarren))]
    ParchedBarren,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.RockyBarren))]
    RockyBarren,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.RuinedDustbowlBarren))]
    RuinedDustbowlBarren,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.WindSweptBarren))]
    WindSweptBarren,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.InfestedBarren))]
    InfestedBarren,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.TerrorsphereBarren))]
    TerrorsphereBarren,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.InfectedDustbowlBarren))]
    InfectedDustbowlBarren,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.TaintedBarren))]
    TaintedBarren,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.AbandonedDead))]
    AbandonedDead,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.AirlessDead))]
    AirlessDead,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.DeadDead))]
    DeadDead,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.DesolateDead))]
    DesolateDead,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.EmptyDead))]
    EmptyDead,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ForsakenDead))]
    ForsakenDead,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.LifeIncompatibleDead))]
    LifeIncompatibleDead,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.LifelessDead))]
    LifelessDead,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.LowAtmosphereDead))]
    LowAtmosphereDead,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.TerraformingCatastropheDead))]
    TerraformingCatastropheDead,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.RedactedExotic))]
    RedactedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.BladedExotic))]
    BladedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.BreachedExotic))]
    BreachedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.BubblingExotic))]
    BubblingExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.CabledExotic))]
    CabledExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.CalcifiedExotic))]
    CalcifiedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.CappedExotic))]
    CappedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ColumnedExotic))]
    ColumnedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ContouredExotic))]
    ContouredExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.CorruptedExotic))]
    CorruptedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.CrimsonExotic))]
    CrimsonExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.DoomedExotic))]
    DoomedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ErasedExotic))]
    ErasedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.FinnedExotic))]
    FinnedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.FissuredExotic))]
    FissuredExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.FoamingExotic))]
    FoamingExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.FracturedExotic))]
    FracturedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.FragmentedExotic))]
    FragmentedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.FrothingExotic))]
    FrothingExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.FungalExotic))]
    FungalExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.GlassyExotic))]
    GlassyExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.HexagonalExotic))]
    HexagonalExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.InfectedExotic))]
    InfectedExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.MalfunctioningExotic))]
    MalfunctioningExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.MechanicalExotic))]
    MechanicalExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.MetallicExotic))]
    MetallicExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.MetallurgicExotic))]
    MetallurgicExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.MoonOfLightExotic))]
    MoonOfLightExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.PlanetOfLightExotic))]
    PlanetOfLightExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.OssifiedExotic))]
    OssifiedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.PetrifiedExotic))]
    PetrifiedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.PillaredExotic))]
    PillaredExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.PlanetaryAnomalyExotic))]
    PlanetaryAnomalyExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.PlatedExotic))]
    PlatedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.RattlingExotic))]
    RattlingExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ScalyExotic))]
    ScalyExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ShardedExotic))]
    ShardedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ShatteredExotic))]
    ShatteredExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ShellStrewnExotic))]
    ShellStrewnExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.SkeletalExotic))]
    SkeletalExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.SpinedExotic))]
    SpinedExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.SporalExotic))]
    SporalExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.TemporaryExotic))]
    TemporaryExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ThirstyExotic))]
    ThirstyExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.WebbedExotic))]
    WebbedExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.CloudsOfHauntedGreenExotic))]
    CloudsOfHauntedGreenExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.RedactedMegaExotic))]
    RedactedMegaExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.AzureMegaExotic))]
    AzureMegaExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.BloodMegaExotic))]
    BloodMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.CeruleanMegaExotic))]
    CeruleanMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.ChromaticFogMegaExotic))]
    ChromaticFogMegaExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.CrimsonMegaExotic))]
    CrimsonMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.DeathlyGreenAnomalyMegaExotic))]
    DeathlyGreenAnomalyMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.DoomedJadeMegaExotic))]
    DoomedJadeMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.FrozenAnomalyMegaExotic))]
    FrozenAnomalyMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.HarshBlueGlobeMegaExotic))]
    HarshBlueGlobeMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.HauntedEmerilMegaExotic))]
    HauntedEmerilMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.LostBlueMegaExotic))]
    LostBlueMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.LostGreenMegaExotic))]
    LostGreenMegaExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.LostRedMegaExotic))]
    LostRedMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.PlanetaryAnomalyMegaExotic))]
    PlanetaryAnomalyMegaExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ScarletMegaExotic))]
    ScarletMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.StellarCorruptionDetectedMegaExotic))]
    StellarCorruptionDetectedMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.ToxicAnomalyMegaExotic))]
    ToxicAnomalyMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.UltramarineMegaExotic))]
    UltramarineMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.VermillionGlobeMegaExotic))]
    VermillionGlobeMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.VileAnomalyMegaExotic))]
    VileAnomalyMegaExotic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.WineDarkMegaExotic))]
    WineDarkMegaExotic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.AridScorched))]
    AridScorched,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.BoilingScorched))]
    BoilingScorched,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.CharredScorched))]
    CharredScorched,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.FieryScorched))]
    FieryScorched,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.HighTemperatureScorched))]
    HighTemperatureScorched,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.HotScorched))]
    HotScorched,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.IncandescentScorched))]
    IncandescentScorched,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ScaldingScorched))]
    ScaldingScorched,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ScorchedScorched))]
    ScorchedScorched,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.TorridScorched))]
    TorridScorched,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.InfestedScorched))]
    InfestedScorched,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.BoilingDoomScorched))]
    BoilingDoomScorched,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.FieryDreadworldScorched))]
    FieryDreadworldScorched,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.ScorchedRelicScorched))]
    ScorchedRelicScorched,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.CorruptedScorched))]
    CorruptedScorched,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ArcticFrozen))]
    ArcticFrozen,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.FreezingFrozen))]
    FreezingFrozen,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.FrostboundFrozen))]
    FrostboundFrozen,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.FrozenFrozen))]
    FrozenFrozen,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.FrozenRelicFrozen))]
    FrozenRelicFrozen,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.GlacialFrozen))]
    GlacialFrozen,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.HiemalFrozen))]
    HiemalFrozen,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.HyperboreanFrozen))]
    HyperboreanFrozen,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.IceboundFrozen))]
    IceboundFrozen,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.IcyFrozen))]
    IcyFrozen,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.SubZeroFrozen))]
    SubZeroFrozen,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.InfestedFrozen))]
    InfestedFrozen,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.IcyAbhorrenceFrozen))]
    IcyAbhorrenceFrozen,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.FrozenHellFrozen))]
    FrozenHellFrozen,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.AcidicToxic))]
    AcidicToxic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.AcridToxic))]
    AcridToxic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.BlightedToxic))]
    BlightedToxic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.CausticToxic))]
    CausticToxic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.CausticNightmareToxic))]
    CausticNightmareToxic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.CorrosiveToxic))]
    CorrosiveToxic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.DecayingRuinToxic))]
    DecayingRuinToxic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.InfestedToxic))]
    InfestedToxic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.MiasmaticToxic))]
    MiasmaticToxic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.NoxiousToxic))]
    NoxiousToxic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.PoisonousToxic))]
    PoisonousToxic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.RottingToxic))]
    RottingToxic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ToxicToxic))]
    ToxicToxic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ToxicHorrorToxic))]
    ToxicHorrorToxic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.IrradiatedIrradiated))]
    IrradiatedIrradiated,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.RadioactiveIrradiated))]
    RadioactiveIrradiated,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.ContaminatedIrradiated))]
    ContaminatedIrradiated,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.NuclearIrradiated))]
    NuclearIrradiated,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.IsotopicIrradiated))]
    IsotopicIrradiated,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.DecayingNuclearIrradiated))]
    DecayingNuclearIrradiated,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.GammaIntensiveIrradiated))]
    GammaIntensiveIrradiated,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.HighRadioSourceIrradiated))]
    HighRadioSourceIrradiated,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.SupercriticalIrradiated))]
    SupercriticalIrradiated,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.HighEnergyIrradiated))]
    HighEnergyIrradiated,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.InfestedIrradiated))]
    InfestedIrradiated,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.RadioactiveAbominationIrradiated))]
    RadioactiveAbominationIrradiated,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.MutatedIrradiated))]
    MutatedIrradiated,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.MarshyMarsh))]
    MarshyMarsh,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.SwampMarsh))]
    SwampMarsh,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.TropicalMarsh))]
    TropicalMarsh,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.FoggyMarsh))]
    FoggyMarsh,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.MistyMarsh))]
    MistyMarsh,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.BoggyMarsh))]
    BoggyMarsh,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.EndlessMorassMarsh))]
    EndlessMorassMarsh,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.QuagmireMarsh))]
    QuagmireMarsh,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.HazyMarsh))]
    HazyMarsh,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.CloudyMarsh))]
    CloudyMarsh,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.VapourMarsh))]
    VapourMarsh,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ReekingMarsh))]
    ReekingMarsh,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.MurkyMarsh))]
    MurkyMarsh,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.DampMarsh))]
    DampMarsh,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.AshShroudedVolcanic))]
    AshShroudedVolcanic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.AshenVolcanic))]
    AshenVolcanic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.BasaltVolcanic))]
    BasaltVolcanic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.EruptingVolcanic))]
    EruptingVolcanic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.FlameRupturedVolcanic))]
    FlameRupturedVolcanic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.ImminentCoreDetonationVolcanic))]
    ImminentCoreDetonationVolcanic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.LavaVolcanic))]
    LavaVolcanic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.MagmaVolcanic))]
    MagmaVolcanic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.MoltenVolcanic))]
    MoltenVolcanic,

    [Display(
        ResourceType = typeof(BiomeSubTypeResource),
        Description = nameof(BiomeSubTypeResource.ObsidianBeadVolcanic))]
    ObsidianBeadVolcanic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.TectonicVolcanic))]
    TectonicVolcanic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.UnstableVolcanic))]
    UnstableVolcanic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ViolentVolcanic))]
    ViolentVolcanic,

    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.VolcanicVolcanic))]
    VolcanicVolcanic,
}