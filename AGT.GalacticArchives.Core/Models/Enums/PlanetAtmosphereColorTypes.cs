using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum PlanetAtmosphereColorTypes
{
    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Apricot))]
    Apricot = 1,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Black))]
    Black,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Blue))]
    Blue,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Bluegreen))]
    Bluegreen,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Bluegrey))]
    Bluegrey,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Blueviolet))]
    Blueviolet,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Brown))]
    Brown,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Carnationpink))]
    Carnationpink,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Cerulean))]
    Cerulean,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Dandelion))]
    Dandelion,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Green))]
    Green,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Greenyellow))]
    Greenyellow,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Grey))]
    Grey,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Indigo))]
    Indigo,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Monochrome))]
    Monochrome,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Monochromeblue))]
    Monochromeblue,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Monochromegreen))]
    Monochromegreen,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Monochromeorange))]
    Monochromeorange,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Monochromered))]
    Monochromered,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Monochromeyellow))]
    Monochromeyellow,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Orange))]
    Orange,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Red))]
    Red,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Redorange))]
    Redorange,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Redviolet))]
    Redviolet,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Scarlet))]
    Scarlet,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Violet))]
    Violet,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Violetred))]
    Violetred,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.White))]
    White,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Yellow))]
    Yellow,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Yellowgreen))]
    Yellowgreen,

    [Display(
        ResourceType = typeof(PlanetAtmosphereColorResource),
        Description = nameof(PlanetAtmosphereColorResource.Yelloworange))]
    Yelloworange,
}