using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum StarshipLocationTypes
{
    [Display(
        ResourceType = typeof(StarshipLocationTypeResource),
        Description = nameof(StarshipLocationTypeResource.ColossalArchive))]
    ColossalArchive = 1,
    [Display(
        ResourceType = typeof(StarshipLocationTypeResource),
        Description = nameof(StarshipLocationTypeResource.CrashedShip))]
    CrashedShip,
    [Display(
        ResourceType = typeof(StarshipLocationTypeResource),
        Description = nameof(StarshipLocationTypeResource.FreighterBay))]
    FreighterBay,
    [Display(
        ResourceType = typeof(StarshipLocationTypeResource),
        Description = nameof(StarshipLocationTypeResource.HabitableBase))]
    HabitableBase,
    [Display(
        ResourceType = typeof(StarshipLocationTypeResource),
        Description = nameof(StarshipLocationTypeResource.MinorSettlement))]
    MinorSettlement,
    Planetside,
    Space,
    [Display(
        ResourceType = typeof(StarshipLocationTypeResource),
        Description = nameof(StarshipLocationTypeResource.SpaceAnomaly))]
    SpaceAnomaly,
    [Display(
        ResourceType = typeof(StarshipLocationTypeResource),
        Description = nameof(StarshipLocationTypeResource.SpaceBattle))]
    SpaceBattle,
    [Display(
        ResourceType = typeof(StarshipLocationTypeResource),
        Description = nameof(StarshipLocationTypeResource.SpaceStation))]
    SpaceStation,
    [Display(
        ResourceType = typeof(StarshipLocationTypeResource),
        Description = nameof(StarshipLocationTypeResource.TradingPost))]
    TradingPost,
}