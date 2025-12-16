using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum SettlementBuildingTypes
{
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.AgriculturalUnit))]
    AgriculturalUnit = 1,
    Bar,
    Bazaar,
    Cantina,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.CommercialExchange))]
    CommercialExchange,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.CommercialRepository))]
    CommercialRepository,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.CoolantMill))]
    CoolantMill,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.DanceHall))]
    DanceHall,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.DockingArea))]
    DockingArea,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.EnvironmentalControlUnit))]
    EnvironmentalControlUnit,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.GeneratorRoom))]
    GeneratorRoom,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.HazardControlUnit))]
    HazardControlUnit,

    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.MultiBarn))]
    HydraulicWirings,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.HydroSilo))]
    HydroSilo,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.InsalubriousDen))]
    InsalubriousDen,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.LandingArea))]
    LandingArea,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.LargeHouse))]
    LargeHouse,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.MachineryUnit))]
    MachineryUnit,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.ManufacturingUnit))]
    ManufacturingUnit,
    Market,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.MediumDwelling))]
    MediumDwelling,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.MultiBarn))]
    MultiBarn,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.PowerGenerator))]
    PowerGenerator,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.ProcessingTower))]
    ProcessingTower,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.ProductionFacility))]
    ProductionFacility,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.PumpingTower))]
    PumpingTower,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.RetailForum))]
    RetailForum,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.RetailZone))]
    RetailZone,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.StandardDwelling))]
    StandardDwelling,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.StarshipHub))]
    StarshipHub,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.StorageUnit))]
    StorageUnit,
    Storeroom,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.SubstantialDwelling))]
    SubstantialDwelling,
    [Display(
        ResourceType = typeof(SettlementBuildingTypeResource),
        Description = nameof(SettlementBuildingTypeResource.WaterTower))]
    WaterTower,
}