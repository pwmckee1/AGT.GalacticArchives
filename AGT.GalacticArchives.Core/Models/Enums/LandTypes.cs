using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum LandTypes
{
    [Display(ResourceType = typeof(LandResource), Description = nameof(LandResource.RockyHilly))]
    RockyHilly = 1,

    [Display(ResourceType = typeof(LandResource), Description = nameof(LandResource.Hilly))]
    Hilly,

    [Display(ResourceType = typeof(LandResource), Description = nameof(LandResource.HillyMountainous))]
    HillyMountainous,

    [Display(ResourceType = typeof(LandResource), Description = nameof(LandResource.RoughHills))]
    RoughHills,

    [Display(ResourceType = typeof(LandResource), Description = nameof(LandResource.AlpineMountainous))]
    AlpineMountainous,

    [Display(ResourceType = typeof(LandResource), Description = nameof(LandResource.Mountainous))]
    Mountainous,

    [Display(ResourceType = typeof(LandResource), Description = nameof(LandResource.FlatPlains))]
    FlatPlains,

    [Display(ResourceType = typeof(LandResource), Description = nameof(LandResource.FlatPlainsHilly))]
    FlatPlainsHilly,

    [Display(ResourceType = typeof(LandResource), Description = nameof(LandResource.FlatPlainsRocky))]
    FlatPlainsRocky,

    [Display(ResourceType = typeof(LandResource), Description = nameof(LandResource.Waterworld))]
    Waterworld,

    [Display(ResourceType = typeof(LandResource), Description = nameof(LandResource.FlatPlainsOcean))]
    FlatPlainsOcean,

    [Display(ResourceType = typeof(LandResource), Description = nameof(LandResource.SmallIslandsOcean))]
    SmallIslandsOcean,
}