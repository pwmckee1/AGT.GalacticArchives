using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum MultiToolLocationTypes
{
    [Display(
        ResourceType = typeof(MultiToolLocationResource),
        Description = nameof(MultiToolLocationResource.ColossalArchive))]
    ColossalArchive,
    [Display(
        ResourceType = typeof(MultiToolLocationResource),
        Description = nameof(MultiToolLocationResource.CrashedShip))]
    CrashedShip,
    [Display(
        ResourceType = typeof(MultiToolLocationResource),
        Description = nameof(MultiToolLocationResource.HarmonicCamp))]
    HarmonicCamp,
    [Display(
        ResourceType = typeof(MultiToolLocationResource),
        Description = nameof(MultiToolLocationResource.ManufacturingFacility))]
    ManufacturingFacility,
    [Display(
        ResourceType = typeof(MultiToolLocationResource),
        Description = nameof(MultiToolLocationResource.MinorSettlement))]
    MinorSettlement,
    Monolith,
    [Display(
        ResourceType = typeof(MultiToolLocationResource),
        Description = nameof(MultiToolLocationResource.SentinelPillar))]
    SentinelPillar,
    [Display(
        ResourceType = typeof(MultiToolLocationResource),
        Description = nameof(MultiToolLocationResource.SpaceAnomaly))]
    SpaceAnomaly,
    [Display(
        ResourceType = typeof(MultiToolLocationResource),
        Description = nameof(MultiToolLocationResource.SpaceStation))]
    SpaceStation,
}