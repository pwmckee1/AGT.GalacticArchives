using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum SentinelActivityTypes
{
    Absent = 1,
    Aggressive,
    [Display(
        ResourceType = typeof(SentinelActivityTypeResource),
        Description = nameof(SentinelActivityTypeResource.AnswerToNone))]
    AnswerToNone,
    Attentive,
    Average,
    Corrupted,
    [Display(
        ResourceType = typeof(SentinelActivityTypeResource),
        Description = nameof(SentinelActivityTypeResource.DeHarmonised))]
    DeHarmonised,
    Dissonant,
    Enforcing,
    [Display(
        ResourceType = typeof(SentinelActivityTypeResource),
        Description = nameof(SentinelActivityTypeResource.EverPresent))]
    Everpresent,
    Few,
    Forsaken,
    Frenzied,
    Frequent,
    Hateful,
    High,
    [Display(
        ResourceType = typeof(SentinelActivityTypeResource),
        Description = nameof(SentinelActivityTypeResource.HighSecurity))]
    HighSecurity,
    [Display(
        ResourceType = typeof(SentinelActivityTypeResource),
        Description = nameof(SentinelActivityTypeResource.HostilePatrols))]
    HostilePatrols,
    Inescapable,
    Infrequent,
    Intermittent,
    [Display(
        ResourceType = typeof(SentinelActivityTypeResource),
        Description = nameof(SentinelActivityTypeResource.IrregularPatrols))]
    IrregularPatrols,
    Isolated,
    Limited,
    Low,
    [Display(
        ResourceType = typeof(SentinelActivityTypeResource),
        Description = nameof(SentinelActivityTypeResource.LowSecurity))]
    LowSecurity,
    Malicious,
    Minimal,
    Missing,
    None,
    [Display(
        ResourceType = typeof(SentinelActivityTypeResource),
        Description = nameof(SentinelActivityTypeResource.NotPresent))]
    NotPresent,
    Observant,
    Passive,
    Rebellious,
    [Display(
        ResourceType = typeof(SentinelActivityTypeResource),
        Description = nameof(SentinelActivityTypeResource.RegularPatrols))]
    RegularPatrols,
    Relaxed,
    Remote,
    [Display(
        ResourceType = typeof(SentinelActivityTypeResource),
        Description = nameof(SentinelActivityTypeResource.RequireObedience))]
    RequireObedience,
    [Display(
        ResourceType = typeof(SentinelActivityTypeResource),
        Description = nameof(SentinelActivityTypeResource.RequireOrthodoxy))]
    RequireOrthodoxy,
    [Display(
        ResourceType = typeof(SentinelActivityTypeResource),
        Description = nameof(SentinelActivityTypeResource.ShardedFromTheAtlas))]
    ShardedFromTheAtlas,
    Sparse,
    [Display(
        ResourceType = typeof(SentinelActivityTypeResource),
        Description = nameof(SentinelActivityTypeResource.SpreadThin))]
    SpreadThin,
    Standard,
    Threatening,
    Typical,
    Unwavering,
    Zealous,
}