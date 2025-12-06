using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum StarSystemFactionTypes
{
    Gek = 1,
    Korvax,
    [Display(ResourceType = typeof(FactionTypeResource), Description = nameof(FactionTypeResource.Vykeen))]
    Vykeen,
    Uncharted,
    [Display(ResourceType = typeof(FactionTypeResource), Description = nameof(FactionTypeResource.GekAbandoned))]
    GekAbandoned,
    [Display(ResourceType = typeof(FactionTypeResource), Description = nameof(FactionTypeResource.KorvaxAbandoned))]
    KorvaxAbandoned,
    [Display(ResourceType = typeof(FactionTypeResource), Description = nameof(FactionTypeResource.VykeenAbandoned))]
    VykeenAbandoned,
}