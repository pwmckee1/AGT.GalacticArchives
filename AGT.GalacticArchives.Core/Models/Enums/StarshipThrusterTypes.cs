using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum StarshipThrusterTypes
{
    [Display(
        ResourceType = typeof(StarshipResource),
        Description = nameof(StarshipResource.ExplorerLargeDoubleThruster))]
    ExplorerLargeDoubleThruster = 1,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerQuadThruster))]
    ExplorerQuadThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerQuintupleThruster))]
    ExplorerQuintupleThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerSextupleThruster))]
    ExplorerSextupleThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerSingleThruster))]
    ExplorerSingleThruster,

    [Display(
        ResourceType = typeof(StarshipResource),
        Description = nameof(StarshipResource.ExplorerSmallDoubleThruster))]
    ExplorerSmallDoubleThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerTripleThruster))]
    ExplorerTripleThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterMonoThruster))]
    FighterMonoThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterTriBooster))]
    FighterTriBooster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterVectorThruster))]
    FighterVectorThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerAirliftThruster))]
    HaulerAirliftThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerDuoMaxEngine))]
    HaulerDuoMaxEngine,

    [Display(
        ResourceType = typeof(StarshipResource),
        Description = nameof(StarshipResource.HaulerFWingAirliftThruster))]
    HaulerFWingAirliftThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerFWingMegalithEngine))]
    HaulerFWingMegalithEngine,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerIronVultureEngine))]
    HaulerIronVultureEngine,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerMegalithEngine))]
    HaulerMegalithEngine,

    [Display(
        ResourceType = typeof(StarshipResource),
        Description = nameof(StarshipResource.HaulerSWingAirliftThruster))]
    HaulerSWingAirliftThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerSWingMegalithEngine))]
    HaulerSWingMegalithEngine,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorPointed))]
    InterceptorPointed,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorVented))]
    InterceptorVented,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorWedged))]
    InterceptorWedged,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.LivingShipDualThruster))]
    LivingShipDualThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.LivingShipSingleThruster))]
    LivingShipSingleThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.LivingShipTripleThruster))]
    LivingShipTripleThruster,

    [Display(
        ResourceType = typeof(StarshipResource),
        Description = nameof(StarshipResource.ShuttleLargeDoubleThruster))]
    ShuttleLargeDoubleThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleQuadThruster))]
    ShuttleQuadThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleQuintupleThruster))]
    ShuttleQuintupleThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleSextupleThruster))]
    ShuttleSextupleThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleSingleThruster))]
    ShuttleSingleThruster,

    [Display(
        ResourceType = typeof(StarshipResource),
        Description = nameof(StarshipResource.ShuttleSmallDoubleThruster))]
    ShuttleSmallDoubleThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleTripleThruster))]
    ShuttleTripleThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarCrescentSolarSail))]
    SolarCrescentSolarSail,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarHexSolarSail))]
    SolarHexSolarSail,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarSquareRigSolarSail))]
    SolarSquareRigSolarSail,
}