using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum EdibleMaterialTypes
{
    [Display(ResourceType = typeof(EdiblePlantResource), Description = nameof(EdiblePlantResource.AloeFlesh))]
    AloeFlesh,
    Hexaberry,

    [Display(ResourceType = typeof(EdiblePlantResource), Description = nameof(EdiblePlantResource.FrozenTubers))]
    FrozenTubers,
    Grahberry,

    [Display(ResourceType = typeof(EdiblePlantResource), Description = nameof(EdiblePlantResource.ImpulseBeans))]
    ImpulseBeans,
    Fireberry,

    [Display(ResourceType = typeof(EdiblePlantResource), Description = nameof(EdiblePlantResource.JadePeas))]
    JadePeas,
}