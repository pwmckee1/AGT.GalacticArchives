using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum FloraFaunaLevelTypes
{
    Absent,
    Abundant,
    Ample,
    Average,
    Barren,

    [Display(
        ResourceType = typeof(FloraFaunaLevelTypeResource),
        Description = nameof(FloraFaunaLevelTypeResource.BetweenWorlds))]
    BetweenWorlds,
    Bountiful,
    Common,
    Copious,
    Deficient,
    Devoid,
    Diseased,
    Displaced,
    Empty,
    Fair,
    Few,
    Forfeited,
    Frequent,

    [Display(
        ResourceType = typeof(FloraFaunaLevelTypeResource),
        Description = nameof(FloraFaunaLevelTypeResource.FromElsewhere))]
    FromElsewhere,
    Full,
    Generous,
    High,
    Infected,
    Infrequent,
    Intermittent,
    Invasive,
    Lacking,
    Limited,
    Lost,
    Low,
    Medium,
    Misplaced,
    Moderate,
    None,
    NonExistent,

    [Display(
        ResourceType = typeof(FloraFaunaLevelTypeResource),
        Description = nameof(FloraFaunaLevelTypeResource.NotPresent))]
    NotPresent,
    Numerous,
    Occasional,
    Ordinary,
    Rare,
    Regular,
    Rich,
    Scarce,
    Screaming,
    Sparse,
    Sporadic,
    Twisted,
    Typical,
    Uncommon,
    Undetected,
    Unusual,
    Uprooted,
    Viral,
}