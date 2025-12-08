using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum AtmosphereColorTypes
{    Apricot,
    Black,
    Blue,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.BlueGreen))]
    Bluegreen,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Bluegrey))]
    Bluegrey,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Blueviolet))]
    Blueviolet,
    Brown,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.CarnationPink))]
    CarnationPink,
    Cerulean,
    Dandelion,
    Green,
    Greenyellow,
    Grey,
    Indigo,
    Monochrome,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.MonochromeBlue))]
    MonochromeBlue,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.MonochromeGreen))]
    MonochromeGreen,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.MonochromeOrange))]
    MonochromeOrange,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.MonochromeRed))]
    MonochromeRed,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.MonochromeYellow))]
    MonochromeYellow,
    Orange,
    Red,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.RedOrange))]
    RedOrange,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.RedViolet))]
    RedViolet,

    Scarlet,
    Violet,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.VioletRed))]
    VioletRed,
    White,
    Yellow,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.YellowGreen))]
    YellowGreen,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.YellowOrange))]
    YellowOrange,
}