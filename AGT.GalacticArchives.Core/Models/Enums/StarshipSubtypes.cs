using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum StarshipSubtypes
{
    [Display(ResourceType = typeof(StarshipSubtypeResource), Description = nameof(StarshipSubtypeResource.ExoticBall))]
    ExoticBall = 1,

    [Display(ResourceType = typeof(StarshipSubtypeResource), Description = nameof(StarshipSubtypeResource.ExoticGuppy))]
    ExoticGuppy,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.ExoticMosquito))]
    ExoticMosquito,

    [Display(ResourceType = typeof(StarshipSubtypeResource), Description = nameof(StarshipSubtypeResource.ExoticRoyal))]
    ExoticRoyal,

    [Display(ResourceType = typeof(StarshipSubtypeResource), Description = nameof(StarshipSubtypeResource.ExoticSquid))]
    ExoticSquid,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.ExplorerDragonfly))]
    ExplorerDragonfly,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.ExplorerDragonflyD))]
    ExplorerDragonflyD,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.ExplorerDragonflyF))]
    ExplorerDragonflyF,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.ExplorerDragonflyS))]
    ExplorerDragonflyS,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.ExplorerEuclid))]
    ExplorerEuclid,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.ExplorerFirefly))]
    ExplorerFirefly,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.ExplorerFireflyD))]
    ExplorerFireflyD,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.ExplorerFireflyF))]
    ExplorerFireflyF,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.ExplorerFireflyS))]
    ExplorerFireflyS,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.ExplorerHesperius))]
    ExplorerHesperius,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FighterAlpha))]
    FighterAlpha,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FighterHotrod))]
    FighterHotrod,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FighterNeedle))]
    FighterNeedle,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FighterOmega))]
    FighterOmega,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FighterRadiant))]
    FighterRadiant,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FighterSleek))]
    FighterSleek,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FighterSpeeder))]
    FighterSpeeder,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FighterTurbine))]
    FighterTurbine,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FighterVector))]
    FighterVector,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterBattleship))]
    FreighterBattleship,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterBlade))]
    FreighterBlade,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterCargo))]
    FreighterCargo,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterCentrifuge))]
    FreighterCentrifuge,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterDerelict))]
    FreighterDerelict,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterDreadnought))]
    FreighterDreadnought,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterEnterprise))]
    FreighterEnterprise,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterGalleon))]
    FreighterGalleon,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterHammerhead))]
    FreighterHammerhead,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterImperial))]
    FreighterImperial,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterIris))]
    FreighterIris,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterOculus))]
    FreighterOculus,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterRegular))]
    FreighterRegular,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterResurgent))]
    FreighterResurgent,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterRevolver))]
    FreighterRevolver,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterSentinel))]
    FreighterSentinel,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FreighterVenator))]
    FreighterVenator,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FrigateCombat))]
    FrigateCombat,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FrigateEthereal))]
    FrigateEthereal,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FrigateExploration))]
    FrigateExploration,

    [Display(ResourceType = typeof(StarshipSubtypeResource), Description = nameof(StarshipSubtypeResource.FrigateGimp))]
    FrigateGimp,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FrigateIndustrial))]
    FrigateIndustrial,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FrigateLeviathan))]
    FrigateLeviathan,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FrigateMonoLeviathan))]
    FrigateMonoLeviathan,

    [Display(ResourceType = typeof(StarshipSubtypeResource), Description = nameof(StarshipSubtypeResource.FrigateRunt))]
    FrigateRunt,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FrigateSupport))]
    FrigateSupport,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.FrigateTrade))]
    FrigateTrade,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.HaulerAviator))]
    HaulerAviator,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.HaulerBulker))]
    HaulerBulker,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.HaulerHydraulic))]
    HaulerHydraulic,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.HaulerIronVulture))]
    HaulerIronVulture,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.HaulerLongshore))]
    HaulerLongshore,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.HaulerNegotiator))]
    HaulerNegotiator,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.HaulerStratoHaul))]
    HaulerStratoHaul,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.HaulerSupercruise))]
    HaulerSupercruise,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.HaulerType11))]
    HaulerType11,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.InterceptorIWing))]
    InterceptorIWing,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.InterceptorIWingMandible))]
    InterceptorIWingMandible,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.InterceptorIWingPincer))]
    InterceptorIWingPincer,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.InterceptorUWing))]
    InterceptorUWing,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.InterceptorUWingMandible))]
    InterceptorUWingMandible,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.InterceptorUWingPincer))]
    InterceptorUWingPincer,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.InterceptorXWing))]
    InterceptorXWing,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.InterceptorXWingMandible))]
    InterceptorXWingMandible,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.InterceptorXWingPincer))]
    InterceptorXWingPincer,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.LivingShipAnvil))]
    LivingShipAnvil,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.LivingShipCompact))]
    LivingShipCompact,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.LivingShipHammerhead))]
    LivingShipHammerhead,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.LivingShipShark))]
    LivingShipShark,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.LivingShipTusked))]
    LivingShipTusked,

    [Display(ResourceType = typeof(StarshipSubtypeResource), Description = nameof(StarshipSubtypeResource.ShuttleBox))]
    ShuttleBox,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.ShuttleDoubleTube))]
    ShuttleDoubleTube,

    [Display(ResourceType = typeof(StarshipSubtypeResource), Description = nameof(StarshipSubtypeResource.ShuttleTube))]
    ShuttleTube,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.SolarArchanid))]
    SolarArchanid,

    [Display(ResourceType = typeof(StarshipSubtypeResource), Description = nameof(StarshipSubtypeResource.SolarExocet))]
    SolarExocet,

    [Display(ResourceType = typeof(StarshipSubtypeResource), Description = nameof(StarshipSubtypeResource.SolarFalcon))]
    SolarFalcon,

    [Display(ResourceType = typeof(StarshipSubtypeResource), Description = nameof(StarshipSubtypeResource.SolarRaven))]
    SolarRaven,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.SolarStarwolf))]
    SolarStarwolf,

    [Display(
        ResourceType = typeof(StarshipSubtypeResource),
        Description = nameof(StarshipSubtypeResource.SolarTurbofan))]
    SolarTurbofan,
}