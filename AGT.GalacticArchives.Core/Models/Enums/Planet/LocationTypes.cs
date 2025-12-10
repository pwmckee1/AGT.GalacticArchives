using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum LocationTypes
{
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.AbandonedBuilding))]
    AbandonedBuilding = 1,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.AncientDataStructure))]
    AncientDataStructure,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.BeaconBuilding))]
    BeaconBuilding,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.BlackMarketTerminal))]
    BlackMarketTerminal,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.BoundaryFailure))]
    BoundaryFailure,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.ColossalArchive))]
    ColossalArchive,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.ColossalStoneEffigy))]
    ColossalStoneEffigy,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.CrashedFreighter))]
    CrashedFreighter,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.CrashedShip))]
    CrashedShip,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.CuriousDeposit))]
    CuriousDeposit,
    Debris,
    Depot,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.DropPod))]
    DropPod,
    Echinocactus,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.FloatingCrystal))]
    FloatingCrystal,
    Frostwort,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.FungalCluster))]
    FungalCluster,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.GalacticTradeTerminal))]
    GalacticTradeTerminal,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.GammaWeed))]
    GammaWeed,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.GeographicPoi))]
    GeographicPoi,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.GravitinoBall))]
    GravitinoBall,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.HabitableBase))]
    HabitableBase,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.HarmonicCamp))]
    HarmonicCamp,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.HolographicCommsTower))]
    HolographicCommsTower,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.HummingSac))]
    HummingSac,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.ManufacturingFacility))]
    ManufacturingFacility,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MetalFingers))]
    MetalFingers,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MinorSettlement))]
    MinorSettlement,
    Monolith,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType01))]
    MonolithType01,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType02))]
    MonolithType02,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType03))]
    MonolithType03,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType04))]
    MonolithType04,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType05))]
    MonolithType05,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType06))]
    MonolithType06,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType07))]
    MonolithType07,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType08))]
    MonolithType08,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType09))]
    MonolithType09,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType10))]
    MonolithType10,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType11))]
    MonolithType11,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType12))]
    MonolithType12,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType13))]
    MonolithType13,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType14))]
    MonolithType14,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType15))]
    MonolithType15,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType16))]
    MonolithType16,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MonolithType17))]
    MonolithType17,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MutantPlant))]
    MutantPlant,
    Observatory,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.OperationsCentre))]
    OperationsCentre,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.OrganicRock))]
    OrganicRock,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.PalaeontologicalDig))]
    PalaeontologicalDig,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.PlanetarySentinelPillar))]
    PlanetarySentinelPillar,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.PlanetarySettlement))]
    PlanetarySettlement,
    Plaque,
    Portal,
    Ruin,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.SacVenom))]
    SacVenom,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.SentientPlant))]
    SentientPlant,
    Shelter,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.SolarVine))]
    SolarVine,
    [Display(
        ResourceType = typeof(StarshipLocationTypeResource),
        Description = nameof(StarshipLocationTypeResource.SpaceAnomaly))]
    SpaceAnomaly,
    [Display(
        ResourceType = typeof(StarshipLocationTypeResource),
        Description = nameof(StarshipLocationTypeResource.SpaceStation))]
    SpaceStation,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.StarBramble))]
    StarBramble,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.SubterraneanRelic))]
    SubterraneanRelic,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.SunkenBuilding))]
    SunkenBuilding,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.TradingPost))]
    TradingPost,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.TransmissionTower))]
    TransmissionTower,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.TravellerGrave))]
    TravellerGrave,
    Waypoints,
}