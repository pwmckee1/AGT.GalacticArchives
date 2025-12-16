using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum PlanetBiotaLevelTypes
{
    Absent = 1,
    Abundant,
    Ample,
    Average,
    Barren,

    [Display(
        ResourceType = typeof(PlanetBiotaLevelTypeResource),
        Description = nameof(PlanetBiotaLevelTypeResource.BetweenWorlds))]
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
        ResourceType = typeof(PlanetBiotaLevelTypeResource),
        Description = nameof(PlanetBiotaLevelTypeResource.FromElsewhere))]
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
        ResourceType = typeof(PlanetBiotaLevelTypeResource),
        Description = nameof(PlanetBiotaLevelTypeResource.NotPresent))]
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