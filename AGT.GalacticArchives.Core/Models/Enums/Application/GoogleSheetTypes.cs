using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Application;

public enum GoogleSheetTypes
{
    [Display(ResourceType = typeof(ImportResource), Description = nameof(ImportResource.RegionSheetName))]
    Region = 1,

    [Display(ResourceType = typeof(ImportResource), Description = nameof(ImportResource.StarSystemSheetName))]
    StarSystem,

    [Display(ResourceType = typeof(ImportResource), Description = nameof(ImportResource.PlanetSheetName))]
    Planet,

    [Display(ResourceType = typeof(ImportResource), Description = nameof(ImportResource.FaunaSheetName))]
    Fauna,

    [Display(ResourceType = typeof(ImportResource), Description = nameof(ImportResource.MultiToolSheetName))]
    MultiTool,

    [Display(ResourceType = typeof(ImportResource), Description = nameof(ImportResource.PlayerBaseSheetName))]
    PlayerBase,

    [Display(
        ResourceType = typeof(ImportResource),
        Description = nameof(ImportResource.PointOfInterestSheetName))]
    POI,

    [Display(ResourceType = typeof(ImportResource), Description = nameof(ImportResource.SettlementSheetName))]
    Settlement,

    [Display(ResourceType = typeof(ImportResource), Description = nameof(ImportResource.StarshipSheetName))]
    Starship,
}