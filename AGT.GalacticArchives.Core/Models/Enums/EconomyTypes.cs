using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum EconomyTypes
{
    Alchemical = 1,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.AdvancedMaterials))]
    AdvancedMaterials,
    Commercial,
    Construction,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.DataUnavailable))]
    DataUnavailable,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.EnergySupply))]
    EnergySupply,
    Engineering,
    Experimental,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.FuelGeneration))]
    FuelGeneration,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.HighElectric))]
    HighElectric,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.HighTech))]
    HighTech,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.HighVoltage))]
    HighVoltage,
    Industrial,
    Manufacturing,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.MassProduction))]
    MassProduction,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.MaterialFusion))]
    MaterialFusion,
    Mathematical,
    Mercantile,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.MetalProcessing))]
    MetalProcessing,
    Minerals,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.MineralExtraction))]
    MineralExtraction,
    Mining,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.NanoConstruction))]
    NanoConstruction,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.OreExtraction))]
    OreExtraction,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.OreExtraction))]
    OreProcessing,

    [Display(ResourceType = typeof(EconomyTypeResource), Description = nameof(EconomyTypeResource.PowerGeneration))]
    PowerGeneration,
    Prospecting,
    Research,
    Scientific,
    Shipping,
    Technology,
    Trading,
}