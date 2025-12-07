using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum BiomeTypes
{
    Barren,
    Dead,
    Exotic,
    Frozen,
    Irradiated,

    [Display(ResourceType = typeof(BiomeTypeResource), Description = nameof(BiomeTypeResource.GasGiant))]
    GasGiant,
    Lush,

    [Display(ResourceType = typeof(BiomeTypeResource), Description = nameof(BiomeTypeResource.MegaExotic))]
    MegaExotic,
    Scorched,
    Toxic,
    Marsh,
    Volcanic,
    Waterworld,
}