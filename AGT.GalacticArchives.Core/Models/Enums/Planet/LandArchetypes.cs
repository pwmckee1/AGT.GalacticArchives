using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum LandArchetypes
{
    [Display(
        ResourceType = typeof(LandArchetypesResource),
        Description = nameof(LandArchetypesResource.ChasmsMountains))]
    ChasmsMountains = 1,

    [Display(ResourceType = typeof(LandArchetypesResource), Description = nameof(LandArchetypesResource.Honeycomb))]
    Honeycomb,

    [Display(ResourceType = typeof(LandArchetypesResource), Description = nameof(LandArchetypesResource.Mesa))]
    Mesa,

    [Display(ResourceType = typeof(LandArchetypesResource), Description = nameof(LandArchetypesResource.Monoliths))]
    Monoliths,

    [Display(ResourceType = typeof(LandArchetypesResource), Description = nameof(LandArchetypesResource.Mountains))]
    Mountains,

    [Display(
        ResourceType = typeof(LandArchetypesResource),
        Description = nameof(LandArchetypesResource.PeaksMountains))]
    PeaksMountains,

    [Display(ResourceType = typeof(LandArchetypesResource), Description = nameof(LandArchetypesResource.RockPillars))]
    RockPillars,

    [Display(
        ResourceType = typeof(LandArchetypesResource),
        Description = nameof(LandArchetypesResource.RollingHillsMountains))]
    RollingHillsMountains,

    [Display(
        ResourceType = typeof(LandArchetypesResource),
        Description = nameof(LandArchetypesResource.RollingMountainsMountains))]
    RollingMountainsMountains,

    [Display(
        ResourceType = typeof(LandArchetypesResource),
        Description = nameof(LandArchetypesResource.RuggedMountainsMountains))]
    RuggedMountainsMountains,

    [Display(ResourceType = typeof(LandArchetypesResource), Description = nameof(LandArchetypesResource.Stoneroot))]
    Stoneroot,

    [Display(
        ResourceType = typeof(LandArchetypesResource),
        Description = nameof(LandArchetypesResource.TallMountainsMountains))]
    TallMountainsMountains,
}