using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Attributes;

public class Biome
{
    [Display(ResourceType = typeof(BiomeResource), Description = nameof(BiomeResource.BiomeName))]
    public string Name { get; set; } = null!;

    public BiomeTypes Type { get; set; }
}