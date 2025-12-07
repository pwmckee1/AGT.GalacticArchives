using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum StarshipSubtypes
{
    [Display(ResourceType = typeof(ApplicationResources), Description = nameof(ApplicationResources.NotApplicable))]
    NotApplicable,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExoticBall))]
    ExoticBall,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExoticGuppy))]
    ExoticGuppy,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExoticMosquito))]
    ExoticMosquito,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExoticRoyal))]
    ExoticRoyal,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExoticSquid))]
    ExoticSquid,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerDragonfly))]
    ExplorerDragonfly,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerDragonflyD))]
    ExplorerDragonflyD,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerDragonflyF))]
    ExplorerDragonflyF,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerDragonflyS))]
    ExplorerDragonflyS,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerEuclid))]
    ExplorerEuclid,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerFirefly))]
    ExplorerFirefly,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerFireflyD))]
    ExplorerFireflyD,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerFireflyF))]
    ExplorerFireflyF,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerFireflyS))]
    ExplorerFireflyS,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerHesperius))]
    ExplorerHesperius,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterAlpha))]
    FighterAlpha,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterHotrod))]
    FighterHotrod,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterNeedle))]
    FighterNeedle,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterOmega))]
    FighterOmega,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterRadiant))]
    FighterRadiant,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterSleek))]
    FighterSleek,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterSpeeder))]
    FighterSpeeder,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterTurbine))]
    FighterTurbine,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterVector))]
    FighterVector,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterBattleship))]
    FreighterBattleship,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterBlade))]
    FreighterBlade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterCargo))]
    FreighterCargo,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterCentrifuge))]
    FreighterCentrifuge,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterDerelict))]
    FreighterDerelict,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterDreadnought))]
    FreighterDreadnought,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterEnterprise))]
    FreighterEnterprise,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterGalleon))]
    FreighterGalleon,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterHammerhead))]
    FreighterHammerhead,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterImperial))]
    FreighterImperial,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterIris))]
    FreighterIris,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterOculus))]
    FreighterOculus,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterRegular))]
    FreighterRegular,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterResurgent))]
    FreighterResurgent,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterRevolver))]
    FreighterRevolver,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterSentinel))]
    FreighterSentinel,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FreighterVenator))]
    FreighterVenator,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FrigateCombat))]
    FrigateCombat,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FrigateEthereal))]
    FrigateEthereal,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FrigateExploration))]
    FrigateExploration,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FrigateGimp))]
    FrigateGimp,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FrigateIndustrial))]
    FrigateIndustrial,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FrigateLeviathan))]
    FrigateLeviathan,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FrigateMonoleviathan))]
    FrigateMonoleviathan,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FrigateRunt))]
    FrigateRunt,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FrigateSupport))]
    FrigateSupport,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FrigateTrade))]
    FrigateTrade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerAviator))]
    HaulerAviator,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulker))]
    HaulerBulker,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerHydraulic))]
    HaulerHydraulic,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerIronVulture))]
    HaulerIronVulture,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerLongshore))]
    HaulerLongshore,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerNegotiator))]
    HaulerNegotiator,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerStratoHaul))]
    HaulerStratoHaul,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerSupercruise))]
    HaulerSupercruise,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerType11))]
    HaulerType11,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorIWingMandible))]
    InterceptorIWingMandible,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorIWingPincer))]
    InterceptorIWingPincer,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorIWing))]
    InterceptorIWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorUWingMandible))]
    InterceptorUWingMandible,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorUWingPincer))]
    InterceptorUWingPincer,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorUWing))]
    InterceptorUWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorXWingMandible))]
    InterceptorXWingMandible,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorXWingPincer))]
    InterceptorXWingPincer,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorXWing))]
    InterceptorXWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.LivingShipAnvil))]
    LivingShipAnvil,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.LivingShipCompact))]
    LivingShipCompact,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.LivingShipHammerhead))]
    LivingShipHammerhead,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.LivingShipShark))]
    LivingShipShark,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.LivingShipTusked))]
    LivingShipTusked,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleBox))]
    ShuttleBox,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleDoubleTube))]
    ShuttleDoubleTube,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleTube))]
    ShuttleTube,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarArchanid))]
    SolarArchanid,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarExocet))]
    SolarExocet,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarFalcon))]
    SolarFalcon,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarRaven))]
    SolarRaven,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarStarwolf))]
    SolarStarwolf,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarTurbofan))]
    SolarTurbofan,
}