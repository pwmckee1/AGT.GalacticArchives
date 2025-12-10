using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Application;

public enum GoogleSheetTypes
{
    [Display(ResourceType = typeof(GoogleSheetResource), Description = nameof(GoogleSheetResource.RegionSheetName))]
    Region = 1,

    [Display(ResourceType = typeof(GoogleSheetResource), Description = nameof(GoogleSheetResource.StarSystemSheetName))]
    StarSystem,

    [Display(ResourceType = typeof(GoogleSheetResource), Description = nameof(GoogleSheetResource.PlanetSheetName))]
    Planet,

    [Display(ResourceType = typeof(GoogleSheetResource), Description = nameof(GoogleSheetResource.FaunaSheetName))]
    Fauna,

    [Display(ResourceType = typeof(GoogleSheetResource), Description = nameof(GoogleSheetResource.MultiToolSheetName))]
    MultiTool,

    [Display(ResourceType = typeof(GoogleSheetResource), Description = nameof(GoogleSheetResource.PlayerBaseSheetName))]
    PlayerBase,

    [Display(
        ResourceType = typeof(GoogleSheetResource),
        Description = nameof(GoogleSheetResource.PointOfInterestSheetName))]
    POI,

    [Display(ResourceType = typeof(GoogleSheetResource), Description = nameof(GoogleSheetResource.SettlementSheetName))]
    Settlement,

    [Display(ResourceType = typeof(GoogleSheetResource), Description = nameof(GoogleSheetResource.StarshipSheetName))]
    Starship,
}