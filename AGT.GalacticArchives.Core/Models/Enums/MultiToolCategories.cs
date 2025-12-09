using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum MultiToolCategories
{
    Alien,

    [Display(
        ResourceType = typeof(MultiToolCategoriesResource),
        Description = nameof(MultiToolCategoriesResource.AngleMuzzle))]
    AngleMuzzle,

    [Display(
        ResourceType = typeof(MultiToolCategoriesResource),
        Description = nameof(MultiToolCategoriesResource.CircleBlaze))]
    CircleBlaze,
    Compact,

    [Display(
        ResourceType = typeof(MultiToolCategoriesResource),
        Description = nameof(MultiToolCategoriesResource.HoseMuzzle))]
    HoseMuzzle,
    Other,

    [Display(
        ResourceType = typeof(MultiToolCategoriesResource),
        Description = nameof(MultiToolCategoriesResource.RailGun))]
    RailGun,
    Scrimshaw,

    [Display(
        ResourceType = typeof(MultiToolCategoriesResource),
        Description = nameof(MultiToolCategoriesResource.StarterPistol))]
    StarterPistol,
    Smg,
}