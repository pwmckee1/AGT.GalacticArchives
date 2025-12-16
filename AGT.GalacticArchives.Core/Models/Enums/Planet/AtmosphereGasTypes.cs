using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum AtmosphereGasTypes
{
    Argon,

    [Display(
        ResourceType = typeof(AtmosphereGasTypeResource),
        Description = nameof(AtmosphereGasTypeResource.CarbonDioxide))]
    CarbonDioxide,

    [Display(
        ResourceType = typeof(AtmosphereGasTypeResource),
        Description = nameof(AtmosphereGasTypeResource.CarbonMonoxide))]
    CarbonMonoxide,
    Chlorine,
    Chrysonite,
    DiHydrogen,
    Dioxite,
    Fluorine,
    Helium,
    Hyglese,
    Methane,
    Neon,
    Nitrogen,

    [Display(
        ResourceType = typeof(AtmosphereGasTypeResource),
        Description = nameof(AtmosphereGasTypeResource.NotPresent))]
    NotPresent,
    Oxygen,
    Pxygen,
    Radnox,
    Radon,
    Sulphurine,
    Thamium,
    Thamium9,
}