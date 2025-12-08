using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum PlayerBaseClassificationTypes
{
    Artistic = 1,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.CivHq))]
    CivHq,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.CompanyHq))]
    CompanyHq,
    Embassy,
    Farm,
    Industrial,
    Memorial,
    Monument,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.MixedUse))]
    MixedUse,
    Ordinary,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.PortalAccess))]
    PortalAccess,
    Puzzle,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.RaceTrack))]
    RaceTrack,
}