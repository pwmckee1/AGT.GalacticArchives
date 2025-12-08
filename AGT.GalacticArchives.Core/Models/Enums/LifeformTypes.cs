using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum LifeformTypes
{
    Gek = 1,
    Korvax,

    [Display(ResourceType = typeof(LifeformTypeResource), Description = nameof(LifeformTypeResource.VyKeen))]
    VyKeen,
    Uncharted,

    [Display(ResourceType = typeof(LifeformTypeResource), Description = nameof(LifeformTypeResource.GekAbandoned))]
    GekAbandoned,

    [Display(ResourceType = typeof(LifeformTypeResource), Description = nameof(LifeformTypeResource.KorvaxAbandoned))]
    KorvaxAbandoned,

    [Display(ResourceType = typeof(LifeformTypeResource), Description = nameof(LifeformTypeResource.VyKeenAbandoned))]
    VyKeenAbandoned,
}