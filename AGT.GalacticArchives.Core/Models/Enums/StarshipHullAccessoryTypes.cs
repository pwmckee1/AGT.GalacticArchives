using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum StarshipHullAccessoryTypes
{
    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleAfterburner))]
    ShuttleAfterburner = 1,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleAirFoil))]
    ShuttleAirFoil,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleAngledChin))]
    ShuttleAngledChin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleAngledRudder))]
    ShuttleAngledRudder,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleAngledVent))]
    ShuttleAngledVent,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleAntenna))]
    ShuttleAntenna,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleCargoVent))]
    ShuttleCargoVent,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleCoolantPorts))]
    ShuttleCoolantPorts,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleCoolingChannel))]
    ShuttleCoolingChannel,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleCowlLights))]
    ShuttleCowlLights,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleDeltaWing))]
    ShuttleDeltaWing,

    [Display(
        ResourceType = typeof(StarshipResource),
        Description = nameof(StarshipResource.ShuttleExhaustCoolingChannel))]
    ShuttleExhaustCoolingChannel,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleFatboy))]
    ShuttleFatboy,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleFiltrationNose))]
    ShuttleFiltrationNose,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleFork))]
    ShuttleFork,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleFuelCompressor))]
    ShuttleFuelCompressor,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleFuelPort))]
    ShuttleFuelPort,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleHoverFan))]
    ShuttleHoverFan,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleKeg))]
    ShuttleKeg,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleLunchBox))]
    ShuttleLunchBox,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleMagnatremeAdapter))]
    ShuttleMagnatremeAdapter,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleMagnatremeDome))]
    ShuttleMagnatremeDome,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleMagnatremeRing))]
    ShuttleMagnatremeRing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleMagnatremeShield))]
    ShuttleMagnatremeShield,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleMicroThruster))]
    ShuttleMicroThruster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleMrFusion))]
    ShuttleMrFusion,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleOmegaCap))]
    ShuttleOmegaCap,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleR2Unit))]
    ShuttleR2Unit,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleRetroBooster))]
    ShuttleRetroBooster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleRoundedChin))]
    ShuttleRoundedChin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleRudder))]
    ShuttleRudder,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleShield))]
    ShuttleShield,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleSolarPanel))]
    ShuttleSolarPanel,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleStabilizer))]
    ShuttleStabilizer,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleStraightTurbine))]
    ShuttleStraightTurbine,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleTaperedTurbine))]
    ShuttleTaperedTurbine,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleVerticalIntake))]
    ShuttleVerticalIntake,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleWingTurbine))]
    ShuttleWingTurbine,
}