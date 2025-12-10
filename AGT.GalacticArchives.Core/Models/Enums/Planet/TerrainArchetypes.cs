using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum TerrainArchetypes
{
    Craters = 1,
    [Display(ResourceType = typeof(TerrainTypeResource), Description = nameof(TerrainTypeResource.SpiresMountains))]
    SpiresMountains,
    Flatlands,
    [Display(ResourceType = typeof(TerrainTypeResource), Description = nameof(TerrainTypeResource.FlatTopsMountains))]
    FlatTopsMountains,
    [Display(ResourceType = typeof(TerrainTypeResource), Description = nameof(TerrainTypeResource.FloatingIslands))]
    FloatingIslands,
    [Display(ResourceType = typeof(TerrainTypeResource), Description = nameof(TerrainTypeResource.UplandsMountains))]
    UplandsMountains,
    Hills,
    [Display(ResourceType = typeof(TerrainTypeResource), Description = nameof(TerrainTypeResource.OverhangsMountains))]
    OverhangsMountains,
    Honeycomb,
    [Display(ResourceType = typeof(TerrainTypeResource), Description = nameof(TerrainTypeResource.RuggedMountains))]
    RuggedMountains,
    Mesa,
    [Display(ResourceType = typeof(TerrainTypeResource), Description = nameof(TerrainTypeResource.ChasmsMountains))]
    ChasmsMountains,
    Monoliths,
    [Display(ResourceType = typeof(TerrainTypeResource), Description = nameof(TerrainTypeResource.RollingMountains))]
    RollingMountains,
    Mountains,
    [Display(ResourceType = typeof(TerrainTypeResource), Description = nameof(TerrainTypeResource.TallMountains))]
    TallMountains,
    RockPillars,
    [Display(ResourceType = typeof(TerrainTypeResource), Description = nameof(TerrainTypeResource.RollingHillsMountains))]
    RollingHillsMountains,
    Stoneroot,
    [Display(ResourceType = typeof(TerrainTypeResource), Description = nameof(TerrainTypeResource.PeaksMountains))]
    PeaksMountains,
}