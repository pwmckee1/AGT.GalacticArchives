using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum FaunaBehaviorTypes
{
    Active = 1,
    Afraid,
    Aggressive,

    [Display(ResourceType = typeof(FaunaBehaviorResource), Description = nameof(FaunaBehaviorResource.AlwaysForaging))]
    AlwaysForaging,
    Ambulatory,
    Amenable,
    Angry,
    Anxious,

    [Display(ResourceType = typeof(FaunaBehaviorResource), Description = nameof(FaunaBehaviorResource.ApexPredator))]
    ApexPredator,
    Attentive,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.BioelectricDefenses))]
    BioelectricDefenses,
    Bold,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.BuildsLargeNests))]
    BuildsLargeNests,
    Calm,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.CanInflateQuickly))]
    CanInflateQuickly,
    Cannibal,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.CarefulHunter))]
    CarefulHunter,
    Cautious,
    Cheerful,
    Chromatophoric,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.ColdBlooded))]
    ColdBlooded,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.CollectsShinyObjects))]
    CollectsShinyObjects,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.ConstantlyMoving))]
    ConstantlyMoving,
    Cruel,
    Dangerous,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.DeepDiving))]
    DeepDiving,
    Defensive,
    Desperate,
    Distinctive,
    Docile,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.DoesNotFearDeath))]
    DoesNotFearDeath,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.DriftsOnCurrents))]
    DriftsOnCurrents,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.EasilyEnraged))]
    EasilyEnraged,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.EasilyScared))]
    EasilyScared,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.EasilyStartled))]
    EasilyStartled,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.EffectivelyBlind))]
    EffectivelyBlind,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.EnjoysTheHunt))]
    EnjoysTheHunt,
    Erratic,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.EverMoving))]
    EverMoving,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.ExcitedByViolence))]
    ExcitedByViolence,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.FarSighted))]
    FarSighted,
    Fearful,
    Fidgety,
    Flighty,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.FoodSeeking))]
    FoodSeeking,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.FormsSchools))]
    FormsSchools,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.FrequentShoaling))]
    FrequentShoaling,
    Friendly,
    Gentle,
    Gregarious,
    Hasty,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.HauntedByUnheardSound))]
    HauntedByUnheardSound,
    Hibernator,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.HighlyIntelligent))]
    HighlyIntelligent,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.HighlyObservant))]
    HighlyObservant,
    Hostile,
    Hungry,
    Hunting,
    Hyperviolent,
    Impulsive,
    Inattentive,
    Instinctive,
    Intelligent,
    Lonely,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.LongDistanceMigration))]
    LongDistanceMigration,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.LongSighted))]
    LongSighted,
    Lost,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.MateSeeking))]
    MateSeeking,
    Methodical,
    Migratory,
    Nervous,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.NeverSleeps))]
    NeverSleeps,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.NeverStopsMoving))]
    NeverStopsMoving,
    Nomadic,
    Observant,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.OnlySeesUp))]
    OnlySeesUp,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.PackHunter))]
    PackHunter,
    Passive,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.PatientHunter))]
    PatientHunter,
    Peaceful,
    Photophobic,
    Predator,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.PressureSensitive))]
    PressureSensitive,
    Prey,
    Prudent,
    Reckless,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.RemembersFaces))]
    RemembersFaces,
    Sedate,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.SeeksCold))]
    SeeksCold,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.SeeksCompany))]
    SeeksCompany,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.SeeksWarmth))]
    SeeksWarmth,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.SelfAware))]
    SelfAware,
    Shy,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.SilentStalker))]
    SilentStalker,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.SingsAtDusk))]
    SingsAtDusk,
    Skittish,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.SlowGrazer))]
    SlowGrazer,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.SmellsBlood))]
    SmellsBlood,
    Stalking,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.StalksPreyForDays))]
    StalksPreyForDays,
    Submissive,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.TendsPlants))]
    TendsPlants,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.TendsYoung))]
    TendsYoung,
    Timid,
    Transcendent,
    Unafraid,
    Unconcerned,
    Unintelligent,
    Unpredictable,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.UsesSonar))]
    UsesSonar,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.VeryCautious))]
    VeryCautious,
    Vicious,
    Vigilant,
    Violent,
    Volatile,
    Wary,
    Watchful,

    [Display(
        ResourceType = typeof(FaunaBehaviorResource),
        Description = nameof(FaunaBehaviorResource.WildlyAggressive))]
    WildlyAggressive,
    Wise,
}