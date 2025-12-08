using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum BaseMaterialTypes
{
    Carbon,
    Chlorine,
    Cobalt,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.CytoPhosphate))]
    CytoPhosphate,

    [Display(
        ResourceType = typeof(MaterialsResourceType),
        Description = nameof(MaterialsResourceType.CondensedCarbon))]
    CondensedCarbon,
    Deuterium,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.Dihydrogen))]
    Dihydrogen,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.FerriteDust))]
    FerriteDust,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.IonisedCobalt))]
    IonisedCobalt,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.MagnetisedFerrite))]
    MagnetisedFerrite,
    Oxygen,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.PureFerrite))]
    PureFerrite,
    Salt,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.SilicatePowder))]
    SilicatePowder,
    Sodium,

    [Display(ResourceType = typeof(MaterialsResourceType), Description = nameof(MaterialsResourceType.SodiumNitrate))]
    SodiumNitrate,
    Tritium,
}