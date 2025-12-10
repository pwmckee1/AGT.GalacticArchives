using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum PlanetPropertyTypes
{
    [Display(
        ResourceType = typeof(PlanetPropertyTypeResource),
        Description = nameof(PlanetPropertyTypeResource.AncientBones))]
    AncientBones = 1,

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