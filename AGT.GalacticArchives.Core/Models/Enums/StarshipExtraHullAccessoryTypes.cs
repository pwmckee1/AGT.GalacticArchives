using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum StarshipExtraHullAccessoryTypes
{
    [Display(ResourceType = typeof(ApplicationResources), Description = nameof(ApplicationResources.NotApplicable))]
    NotApplicable,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleAfterburner))]
    ShuttleAfterburner,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleFatboy))]
    ShuttleFatboy,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleHoverFan))]
    ShuttleHoverFan,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleMagnatremeAdapter))]
    ShuttleMagnatremeAdapter,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleMagnatremeDome))]
    ShuttleMagnatremeDome,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleMagnatremeRing))]
    ShuttleMagnatremeRing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleMagnatremeShield))]
    ShuttleMagnatremeShield,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleOmegaCap))]
    ShuttleOmegaCap,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleRetroBooster))]
    ShuttleRetroBooster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleStraightTurbine))]
    ShuttleStraightTurbine,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleTaperedTurbine))]
    ShuttleTaperedTurbine,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleWingTurbine))]
    ShuttleWingTurbine,
}