using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum TerrainTypes
{
    Archipelago,
    Continental,

    [Display(ResourceType = typeof(TerrainTypeResource), Description = nameof(TerrainTypeResource.IslandChains))]
    IslandChains,
    Oceanic,
    Waterworld,
    Pangean,

    [Display(ResourceType = typeof(TerrainTypeResource), Description = nameof(TerrainTypeResource.RiverlandTerrain))]
    RiverlandTerrain,
    Swamp,
    Reef,
}