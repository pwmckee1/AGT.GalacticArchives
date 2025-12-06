using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum StarshipModelTypes
{
    Exotic = 1,
    Explorer,
    Fighter,
    Freighter,
    Frigate,
    Hauler,
    Interceptor,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.LivingShip))]
    LivingShip,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.OrganicFrigates))]
    OrganicFrigates,
    Shuttle,
    Solar,
}