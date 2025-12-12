using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.StarSystem;

public enum ConflictTypes
{
    Aggressive = 1,
    Alarming,

    [Display(ResourceType = typeof(ConflictTypeResource), Description = nameof(ConflictTypeResource.AtWar))]
    AtWar,
    Belligerent,
    Boisterous,
    Critical,
    Dangerous,

    [Display(ResourceType = typeof(ConflictTypeResource), Description = nameof(ConflictTypeResource.DataUnavailable))]
    DataUnavailable,
    Destructive,
    Formidable,
    Fractious,
    Gentle,
    High,
    Intermittent,
    Lawless,
    Low,
    Medium,
    Mild,

    Peaceful,
    Perilous,

    [Display(ResourceType = typeof(ConflictTypeResource), Description = nameof(ConflictTypeResource.PirateControlled))]
    PirateControlled,
    Relaxed,
    Rowdy,
    Sporadic,
    Stable,
    Testy,
    Tranquil,
    Trivial,
    Unruly,
    Unstable,
    Unthreatening,
    Untroubled,
}