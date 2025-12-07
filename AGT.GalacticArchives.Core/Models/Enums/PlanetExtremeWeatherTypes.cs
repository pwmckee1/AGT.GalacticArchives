using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum PlanetExtremeWeatherTypes
{
    Clear,
    Normal,
    Extreme,
    Green,
    Red,
    Blue,
    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NotApplicable))]
    NotApplicable,
}