using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum PlanetPropertyTypes
{
    [Display(ResourceType = typeof(ApplicationResources), Description = nameof(ApplicationResources.NotApplicable))]
    NotApplicable,

    [Display(
        ResourceType = typeof(PlanetPropertyTypeResource),
        Description = nameof(PlanetPropertyTypeResource.AncientBones))]
    AncientBones,

    [Display(
        ResourceType = typeof(PlanetPropertyTypeResource),
        Description = nameof(PlanetPropertyTypeResource.SalvageableScrap))]
    SalvageableScrap,

    [Display(
        ResourceType = typeof(PlanetPropertyTypeResource),
        Description = nameof(PlanetPropertyTypeResource.VileBrood))]
    VileBrood,
    Dissonance,
}