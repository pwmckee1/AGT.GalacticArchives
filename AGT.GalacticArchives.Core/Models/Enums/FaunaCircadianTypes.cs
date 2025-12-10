using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum FaunaCircadianTypes
{
    [Display(ResourceType = typeof(FaunaBehaviorResource), Description = nameof(FaunaBehaviorResource.AlwaysActive))]
    AlwaysActive = 1,
    Diurnal,
    [Display(ResourceType = typeof(FaunaBehaviorResource), Description = nameof(FaunaBehaviorResource.MostlyDiurnal))]
    MostlyDiurnal,
    [Display(ResourceType = typeof(FaunaBehaviorResource), Description = nameof(FaunaBehaviorResource.MostlyNocturnal))]
    MostlyNocturnal,
    Nocturnal,
}