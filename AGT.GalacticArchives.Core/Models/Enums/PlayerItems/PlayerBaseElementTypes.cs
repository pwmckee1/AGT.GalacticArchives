using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

public enum PlayerBaseElementTypes
{
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.AgriculturalTerminal))]
    AgriculturalTerminal = 1,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.AntimatterReactor))]
    AntimatterReactor,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.AppearanceModifier))]
    AppearanceModifier,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.AtmosphereHarvester))]
    AtmosphereHarvester,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.AutomatedFeeder))]
    AutomatedFeeder,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.AutonomousMiningUnit))]
    AutonomousMiningUnit,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.AutomatedTrap))]
    AutomatedTrap,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.BarrelFabricator))]
    BarrelFabricator,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.BaseSalvageCapsule))]
    BaseSalvageCapsule,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.BaseTeleportModule))]
    BaseTeleportModule,
    Battery,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.BioDome))]
    BioDome,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.BiofuelReactor))]
    BiofuelReactor,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.BytebeatDevice))]
    BytebeatDevice,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.ColossusGeobay))]
    ColossusGeobay,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.ConstructionResearchUnit))]
    ConstructionResearchUnit,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.ConstructionTerminal))]
    ConstructionTerminal,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.CrateFabricator))]
    CrateFabricator,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.DeepwaterChamber))]
    DeepwaterChamber,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.ElectricalCloakingUnit))]
    ElectricalCloakingUnit,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.ElectromagneticGenerator))]
    ElectromagneticGenerator,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.EmergencyHeater))]
    EmergencyHeater,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.ExocraftSummoningStation))]
    ExocraftSummoningStation,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.ExocraftTerminal))]
    ExocraftTerminal,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.FossilDisplay))]
    FossilDisplay,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.GalacticTradeTerminal))]
    GalacticTradeTerminal,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.HazardProtectionUnitBaseBuilding))]
    HazardProtectionUnitBaseBuilding,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.HealthStation))]
    HealthStation,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.HolographicChartProjector))]
    HolographicChartProjector,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.HolographicGlobeGadget))]
    HolographicGlobeGadget,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.HydroponicTray))]
    HydroponicTray,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.LandingPad))]
    LandingPad,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.LargeRefiner))]
    LargeRefiner,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.LivestockUnit))]
    LivestockUnit,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.MarineShelter))]
    MarineShelter,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.MediumRefiner))]
    MediumRefiner,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.MessageModule))]
    MessageModule,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.MinotaurGeobay))]
    MinotaurGeobay,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.MoonPoolFloor))]
    MoonPoolFloor,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.NautilonChamber))]
    NautilonChamber,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.NoiseBox))]
    NoiseBox,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.NomadGeobay))]
    NomadGeobay,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.NutrientProcessor))]
    NutrientProcessor,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.OxygenHarvester))]
    OxygenHarvester,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.PilgrimGeobay))]
    PilgrimGeobay,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.PlanetaryGlobe))]
    PlanetaryGlobe,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.PocketRealityGenerator))]
    PocketRealityGenerator,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.PortableRefiner))]
    PortableRefiner,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.RaceForceAmplifier))]
    RaceForceAmplifier,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.RaceInitiator))]
    RaceInitiator,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.RaceObstacle))]
    RaceObstacle,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.RoamerGeobay))]
    RoamerGeobay,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.SavePoint))]
    SavePoint,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.ScienceTerminal))]
    ScienceTerminal,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.ShieldStation))]
    ShieldStation,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.ShortRangeTeleporter))]
    ShortRangeTeleporter,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.SignalBooster))]
    SignalBooster,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.SmallAquarium))]
    SmallAquarium,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.SolarPanel))]
    SolarPanel,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.SphereCreator))]
    SphereCreator,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.StandingPlanter))]
    StandingPlanter,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.StorageContainer))]
    StorageContainer,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.SupplyDepot))]
    SupplyDepot,
    Terrarium,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.WeaponsTerminal))]
    WeaponsTerminal,
    [Display(
        ResourceType = typeof(PlayerBaseElementTypeResource),
        Description = nameof(PlayerBaseElementTypeResource.WonderProjector))]
    WonderProjector,
}