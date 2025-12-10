using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

public enum StarshipThrusterTypes
{
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.ExplorerSingleThruster))]
    ExplorerSingleThruster = 1,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.ExplorerSmallDoubleThruster))]
    ExplorerSmallDoubleThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.ExplorerLargeDoubleThruster))]
    ExplorerLargeDoubleThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.ExplorerTripleThruster))]
    ExplorerTripleThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.ExplorerQuadThruster))]
    ExplorerQuadThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.ExplorerQuintupleThruster))]
    ExplorerQuintupleThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.ExplorerSextupleThruster))]
    ExplorerSextupleThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.FighterMonoThruster))]
    FighterMonoThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.FighterTriBooster))]
    FighterTriBooster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.FighterVectorThruster))]
    FighterVectorThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.HaulerAirliftThruster))]
    HaulerAirliftThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.HaulerFWingAirliftThruster))]
    HaulerFWingAirliftThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.HaulerSWingAirliftThruster))]
    HaulerSWingAirliftThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.HaulerDuoMaxEngine))]
    HaulerDuoMaxEngine,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.HaulerFWingMegalithEngine))]
    HaulerFWingMegalithEngine,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.HaulerIronVultureEngine))]
    HaulerIronVultureEngine,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.HaulerMegalithEngine))]
    HaulerMegalithEngine,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.HaulerSWingMegalithEngine))]
    HaulerSWingMegalithEngine,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.InterceptorVented))]
    InterceptorVented,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.InterceptorWedged))]
    InterceptorWedged,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.InterceptorPointed))]
    InterceptorPointed,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.LivingShipSingleThruster))]
    LivingShipSingleThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.LivingShipDualThruster))]
    LivingShipDualThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.LivingShipTripleThruster))]
    LivingShipTripleThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.ShuttleSingleThruster))]
    ShuttleSingleThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.ShuttleSmallDoubleThruster))]
    ShuttleSmallDoubleThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.ShuttleLargeDoubleThruster))]
    ShuttleLargeDoubleThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.ShuttleTripleThruster))]
    ShuttleTripleThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.ShuttleQuadThruster))]
    ShuttleQuadThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.ShuttleQuintupleThruster))]
    ShuttleQuintupleThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.ShuttleSextupleThruster))]
    ShuttleSextupleThruster,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.SolarCrescentSolarSail))]
    SolarCrescentSolarSail,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.SolarHexSolarSail))]
    SolarHexSolarSail,
    [Display(
        ResourceType = typeof(StarshipThrusterTypeResource),
        Description = nameof(StarshipThrusterTypeResource.SolarSquareRigSolarSail))]
    SolarSquareRigSolarSail,
}