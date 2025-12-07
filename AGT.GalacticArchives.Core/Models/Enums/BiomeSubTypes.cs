using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum BiomeSubTypes
{
    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.TheNest))]
    TheNest,
    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.TheReliquary))]
    TheReliquary,
    Thirsty,
    Torrid,
    Toxic,
    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ToxicAnomaly))]
    ToxicAnomaly,
    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.ToxicHorror))]
    ToxicHorror,
    Tropical,
    Ultramarine,
    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.UltramarineGiant))]
    UltramarineGiant,
    Unstable,
    Vapour,
    Verdant,
    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.VermillionGlobe))]
    VermillionGlobe,
    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.VileAnomaly))]
    VileAnomaly,
    Violent,
    Viridescent,
    Volcanic,
    Waterlocked,
    Waterworld,
    Webbed,
    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.WindSwept))]
    WindSwept,
    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.WineDark))]
    WineDark,
    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.WormRidden))]
    WormRidden,
    [Display(ResourceType = typeof(BiomeSubTypeResource), Description = nameof(BiomeSubTypeResource.XenoColony))]
    XenoColony,
}