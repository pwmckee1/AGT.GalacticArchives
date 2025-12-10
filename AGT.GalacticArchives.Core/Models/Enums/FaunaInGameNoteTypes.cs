using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum FaunaInGameNoteTypes
{
    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.AbsorbsMoistureFromAir))]
    AbsorbsMoistureFromAir = 1,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.AcidicBlood))]
    AcidicBlood,
    Aggressive,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.AlluringPheromones))]
    AlluringPheromones,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.AlwaysWaiting))]
    AlwaysWaiting,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.AlwaysWatching))]
    AlwaysWatching,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ArmouredSkull))]
    ArmouredSkull,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.AsexualReproduction))]
    AsexualReproduction,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.AutonomousRegeneration))]
    AutonomousRegeneration,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.AwareOfItsFate))]
    AwareOfItsFate,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BarbedFeet))]
    BarbedFeet,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BelovedByTheGek))]
    BelovedByTheGek,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BioluminescentBlood))]
    BioluminescentBlood,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BioluminescentTeeth))]
    BioluminescentTeeth,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BlueBlood))]
    BlueBlood,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BondsWithVyKeen))]
    BondsWithVyKeen,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BornOnMeteors))]
    BornOnMeteors,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BothGillsAndLungs))]
    BothGillsAndLungs,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BrainHemispheresDoNotLink))]
    BrainHemispheresDoNotLink,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BrainHemispheresNotIdentical))]
    BrainHemispheresNotIdentical,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BreathesThroughMouth))]
    BreathesThroughMouth,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BrittleBones))]
    BrittleBones,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BruisableOrgans))]
    BruisableOrgans,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BuildsMetalNest))]
    BuildsMetalNest,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BuriesFoodSupplies))]
    BuriesFoodSupplies,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.BurnsInTheSun))]
    BurnsInTheSun,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CalcifiedClaws))]
    CalcifiedClaws,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CanChangeColour))]
    CanChangeColour,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CanDislocateJawbones))]
    CanDislocateJawbones,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CanFeelLove))]
    CanFeelLove,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CanSenseMagneticFields))]
    CanSenseMagneticFields,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CannotDigestStarch))]
    CannotDigestStarch,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CannotDrown))]
    CannotDrown,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CannotSeeColour))]
    CannotSeeColour,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CannotSweat))]
    CannotSweat,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CarbonBasedSkeleton))]
    CarbonBasedSkeleton,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CarriesBabiesInPouch))]
    CarriesBabiesInPouch,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CarriesSymbioticFungus))]
    CarriesSymbioticFungus,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CarriesSymbioticWorms))]
    CarriesSymbioticWorms,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CausticSkin))]
    CausticSkin,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ChangesGenderWhenCold))]
    ChangesGenderWhenCold,
    Chromatophore,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ClawsHarbourDisease))]
    ClawsHarbourDisease,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CompoundEyes))]
    CompoundEyes,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CoveredInTinyHairs))]
    CoveredInTinyHairs,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CoveredInToxicBristles))]
    CoveredInToxicBristles,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CreatesBeautifulWebs))]
    CreatesBeautifulWebs,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.CutaneousRespiration))]
    CutaneousRespiration,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.DecentralisedNervousSystem))]
    DecentralisedNervousSystem,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.DeceptivelyFast))]
    DeceptivelyFast,
    Delicious,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.DetachableTongue))]
    DetachableTongue,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.DigestsViaSymbiots))]
    DigestsViaSymbiots,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.DigsUndergroundNests))]
    DigsUndergroundNests,
    Diplosaur,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.DislikesBeingScanned))]
    DislikesBeingScanned,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.DislikesBrightColors))]
    DislikesBrightColors,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.DoesNotAge))]
    DoesNotAge,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.DoubleConedEyes))]
    DoubleConedEyes,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.DrinksBlood))]
    DrinksBlood,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.EasilyConfused))]
    EasilyConfused,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.EasilyTrained))]
    EasilyTrained,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.EcholocationGlands))]
    EcholocationGlands,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ElaborateMatingDisplays))]
    ElaborateMatingDisplays,
    Evil,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ExcellentNavigator))]
    ExcellentNavigator,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ExcellentSenseOfSmell))]
    ExcellentSenseOfSmell,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ExcessOfBile))]
    ExcessOfBile,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ExtensiveGutBacteria))]
    ExtensiveGutBacteria,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ExtremelyAggressive))]
    ExtremelyAggressive,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ExtremelyHeterozygous))]
    ExtremelyHeterozygous,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ExtremelyHomozygous))]
    ExtremelyHomozygous,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.EyesRegrowAfterDamage))]
    EyesRegrowAfterDamage,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.FearsTheRain))]
    FearsTheRain,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.FleesAnySignsOfDanger))]
    FleesAnySignsOfDanger,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.FleesInterlopers))]
    FleesInterlopers,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.FlexibleJoints))]
    FlexibleJoints,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.FormsColonies))]
    FormsColonies,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.FragileSkin))]
    FragileSkin,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.FragileSkull))]
    FragileSkull,
    Fragrant,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.FrequentlyLost))]
    FrequentlyLost,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.FrequentlyRegurgitates))]
    FrequentlyRegurgitates,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.GelatinousBones))]
    GelatinousBones,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.GeneticallyUnstable))]
    GeneticallyUnstable,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.GentleSoul))]
    GentleSoul,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.GetsColdEasily))]
    GetsColdEasily,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.GoesUndergroundToDie))]
    GoesUndergroundToDie,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.GoodParent))]
    GoodParent,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.GoodPollinator))]
    GoodPollinator,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.GreenBlood))]
    GreenBlood,
    GrowWingsBeforeDeath,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.GrowsLungsAfterBirth))]
    GrowsLungsAfterBirth,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.GrowsTeethEachDay))]
    GrowsTeethEachDay,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.GrowsWingsBeforeDeath))]
    GrowsWingsBeforeDeath,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.HasChlorophyllGlands))]
    HasChlorophyllGlands,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.HasNoBones))]
    HasNoBones,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.HatchedFromCocoons))]
    HatchedFromCocoons,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.HearsGroundVibrations))]
    HearsGroundVibrations,
    Hibernates,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.HiddenExtraClaws))]
    HiddenExtraClaws,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.HiddenExtraSkull))]
    HiddenExtraSkull,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.HiddenExtraTongue))]
    HiddenExtraTongue,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.HiddenStinger))]
    HiddenStinger,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.HighlyFertile))]
    HighlyFertile,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.HighlyIntelligent))]
    HighlyIntelligent,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.HighlySocial))]
    HighlySocial,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.HuntsSentinels))]
    HuntsSentinels,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.HybridSpecies))]
    HybridSpecies,
    Hydrophobic,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.InflatesWhenStressed))]
    InflatesWhenStressed,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.InvertedOrganSacs))]
    InvertedOrganSacs,
    Irritable,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.JenbenderWhenCold))]
    JenbenderWhenCold,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.LacksGallbladder))]
    LacksGallbladder,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.LadenWithNectar))]
    LadenWithNectar,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.LaysBeautifulEggs))]
    LaysBeautifulEggs,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.LimitedMindControl))]
    LimitedMindControl,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.LimitedSentience))]
    LimitedSentience,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.LivesInHerds))]
    LivesInHerds,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.LovelyEyes))]
    LovelyEyes,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.MadeOfStardust))]
    MadeOfStardust,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.MagneticTeeth))]
    MagneticTeeth,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.MakesArtWithSticks))]
    MakesArtWithSticks,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ManyHiddenToes))]
    ManyHiddenToes,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.MassiveTongue))]
    MassiveTongue,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.MatesForLife))]
    MatesForLife,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.MatriarchalSociety))]
    MatriarchalSociety,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.MetalBones))]
    MetalBones,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.MildlyRadioactive))]
    MildlyRadioactive,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.MonstrousTongue))]
    MonstrousTongue,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.MoonBaby))]
    MoonBaby,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.NestsInBlueFoliage))]
    NestsInBlueFoliage,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.NeverBlinks))]
    NeverBlinks,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.NightVision))]
    NightVision,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.NineAdditionalSenses))]
    NineAdditionalSenses,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.NitrogenRichBlood))]
    NitrogenRichBlood,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.NoStomach))]
    NoStomach,
    Nocturnal,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.NotCarbonBased))]
    NotCarbonBased,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.NutritiousFaeces))]
    NutritiousFaeces,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.OccasionallyEatsRocks))]
    OccasionallyEatsRocks,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.OccasionallyInvisible))]
    OccasionallyInvisible,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.OneExtendibleFinger))]
    OneExtendibleFinger,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ParasitesInBrain))]
    ParasitesInBrain,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.PartiallyDomesticated))]
    PartiallyDomesticated,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ParticularlyOily))]
    ParticularlyOily,
    Photosensitive,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.PoorHearing))]
    PoorHearing,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.PoorSenseOfDirection))]
    PoorSenseOfDirection,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.PorousSkin))]
    PorousSkin,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.PossessesLanguage))]
    PossessesLanguage,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.PowerfulDigestiveEnzymes))]
    PowerfulDigestiveEnzymes,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.PowerfulMandibles))]
    PowerfulMandibles,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ProducesVileStench))]
    ProducesVileStench,
    Promiscuous,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RapidSelfHealing))]
    RapidSelfHealing,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RecognisesOtherSpecies))]
    RecognisesOtherSpecies,
    Recycled,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RedundantInternalOrgans))]
    RedundantInternalOrgans,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RegrowsTeethEachDay))]
    RegrowsTeethEachDay,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RegularlyRegurgitates))]
    RegularlyRegurgitates,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RegularlyShedSkin))]
    RegularlyShedSkin,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RequiresDietaryIron))]
    RequiresDietaryIron,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RespiresAnaerobically))]
    RespiresAnaerobically,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RespiresInorganically))]
    RespiresInorganically,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RetractableAppendage))]
    RetractableAppendage,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RetractableEyeballs))]
    RetractableEyeballs,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RetractableEyestalks))]
    RetractableEyestalks,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RiddledWithPests))]
    RiddledWithPests,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RigidBones))]
    RigidBones,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.RubberSkull))]
    RubberSkull,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SalivaPh14))]
    SalivaPh14,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ScaredOfFire))]
    ScaredOfFire,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ScaredOfMirrors))]
    ScaredOfMirrors,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ScreamsWhenUpset))]
    ScreamsWhenUpset,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SecondarySkin))]
    SecondarySkin,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SecretesPhytotoxins))]
    SecretesPhytotoxins,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SecretesVenom))]
    SecretesVenom,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SeeksRedFlowers))]
    SeeksRedFlowers,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SelfAware))]
    SelfAware,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SenseOrgansInFeet))]
    SenseOrgansInFeet,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SensesAtlas))]
    SensesAtlas,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SensesOrgansInFeet))]
    SensesOrgansInFeet,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SharpClaws))]
    SharpClaws,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ShedsAndRegrowsBones))]
    ShedsAndRegrowsBones,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SingsBeautifully))]
    SingsBeautifully,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SixStomachs))]
    SixStomachs,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SkinFullOfHoles))]
    SkinFullOfHoles,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SkinParasites))]
    SkinParasites,
    Skittish,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SkullFullOfHoles))]
    SkullFullOfHoles,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SleepsStandingUp))]
    SleepsStandingUp,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SmellsWithTongue))]
    SmellsWithTongue,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SolarPowered))]
    SolarPowered,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SpawnsInWater))]
    SpawnsInWater,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SpraysInkWhenScared))]
    SpraysInkWhenScared,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.StomachInsideSkull))]
    StomachInsideSkull,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.StoresWaterInHiddenSacs))]
    StoresWaterInHiddenSacs,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.StrongBurrower))]
    StrongBurrower,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.StrongSwimmer))]
    StrongSwimmer,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.StronglyRadioactive))]
    StronglyRadioactive,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SuperheatedStomach))]
    SuperheatedStomach,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SweatsMilkForInfants))]
    SweatsMilkForInfants,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.SymmetricalInsides))]
    SymmetricalInsides,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.TapewormHost))]
    TapewormHost,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.TechnicallyImmortal))]
    TechnicallyImmortal,
    Telepathic,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ThickSkull))]
    ThickSkull,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ThreeHearts))]
    ThreeHearts,
    Ticklish,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.TinyBrain))]
    TinyBrain,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.TinyOrgans))]
    TinyOrgans,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.TongueParasites))]
    TongueParasites,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ToughenedSkin))]
    ToughenedSkin,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ToxicTongue))]
    ToxicTongue,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.TranslucentTeeth))]
    TranslucentTeeth,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.TwoLivers))]
    TwoLivers,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.UltrasonicRoar))]
    UltrasonicRoar,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.UnpleasantToEat))]
    UnpleasantToEat,
    Untameable,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.ValuableBlood))]
    ValuableBlood,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.VariedPhenotype))]
    VariedPhenotype,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.VenomLadenClaws))]
    VenomLadenClaws,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.VeryPredatory))]
    VeryPredatory,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.VerySkittish))]
    VerySkittish,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.VestigialUdders))]
    VestigialUdders,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.WaxyAllOver))]
    WaxyAllOver,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.WeakLungs))]
    WeakLungs,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.WellInsulated))]
    WellInsulated,

    [Display(
        ResourceType = typeof(FaunaInGameNoteTypeResource),
        Description = nameof(FaunaInGameNoteTypeResource.YellowBlood))]
    YellowBlood,
}