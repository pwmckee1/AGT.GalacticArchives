using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

public enum MultiToolCategories
{
    Alien,

    [Display(
        ResourceType = typeof(MultiToolResource),
        Description = nameof(MultiToolResource.AngleMuzzle))]
    AngleMuzzle,

    [Display(
        ResourceType = typeof(MultiToolResource),
        Description = nameof(MultiToolResource.CircleBlaze))]
    CircleBlaze,
    Compact,

    [Display(
        ResourceType = typeof(MultiToolResource),
        Description = nameof(MultiToolResource.HoseMuzzle))]
    HoseMuzzle,
    Other,

    [Display(
        ResourceType = typeof(MultiToolResource),
        Description = nameof(MultiToolResource.RailGun))]
    RailGun,
    Scrimshaw,

    [Display(
        ResourceType = typeof(MultiToolResource),
        Description = nameof(MultiToolResource.StarterPistol))]
    StarterPistol,
    Smg,
}