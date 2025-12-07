using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum GamePlatform
{
    [Display(ResourceType = typeof(ApplicationResources), Description = nameof(ApplicationResources.NotApplicable))]
    NotApplicable,
    All,
    Mac,
    PC,
    PS,
    PS4,
    PS5,
    Switch,
    Xbox,
}