using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum PlanetaryCoreTypes
{
    Aluminium,
    Anomalous,
    Basalt,
    Cadmium,
    Calium,
    Cobalt,
    [Display(ResourceType = typeof(PlanetaryCoreTypeResource), Description = nameof(PlanetaryCoreTypeResource.CondensedCarbon))]
    CondensedCarbon,
    Copper,
    [Display(ResourceType = typeof(PlanetaryCoreTypeResource), Description = nameof(PlanetaryCoreTypeResource.CoreMissing))]
    CoreMissing,
    Deuterium,
    Emeril,
    Glass,
    Gold,
    Heridium,
    Indium,
    [Display(ResourceType = typeof(PlanetaryCoreTypeResource), Description = nameof(PlanetaryCoreTypeResource.MagnetisedFerrite))]
    MagnetisedFerrite,
    Murrine,
    Omegon,
    Platinum,
    Plutonium,
    Pugneum,
    PureFerrite,
    [Display(ResourceType = typeof(PlanetaryCoreTypeResource), Description = nameof(PlanetaryCoreTypeResource.ScreamingEchoes))]
    ScreamingEchoes,
    [Display(ResourceType = typeof(PlanetaryCoreTypeResource), Description = nameof(PlanetaryCoreTypeResource.SilicatePowder))]
    SilicatePowder,
    Silver,
    Uranium,
    Water,
    Zinc,
}