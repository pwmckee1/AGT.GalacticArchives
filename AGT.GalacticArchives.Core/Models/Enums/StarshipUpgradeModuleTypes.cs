using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum StarshipUpgradeModuleTypes
{
    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.CadmiumDrive))]
    CadmiumDrive = 1,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.CyclotronBallista))]
    CyclotronBallista,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.DeflectorShieldUpgrade))]
    DeflectorShieldUpgrade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.EfficientThrusters))]
    EfficientThrusters,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.EmergencyWarpUnit))]
    EmergencyWarpUnit,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.EmerilDrive))]
    EmerilDrive,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FourierDeLimiter))]
    FourierDeLimiter,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.GraftedEyes))]
    GraftedEyes,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HyperdriveUpgrade))]
    HyperdriveUpgrade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.IndiumDrive))]
    IndiumDrive,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InfraKnifeAccelerator))]
    InfraKnifeAccelerator,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.LaunchSystemRecharger))]
    LaunchSystemRecharger,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.LaunchThrusterUpgrade))]
    LaunchThrusterUpgrade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.NeuralAssembly))]
    NeuralAssembly,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.PhaseBeam))]
    PhaseBeam,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.PhotonCannon))]
    PhotonCannon,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.PositronEjector))]
    PositronEjector,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.PulseEngineUpgrades))]
    PulseEngineUpgrades,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.PulsingHeart))]
    PulsingHeart,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.RocketLauncher))]
    RocketLauncher,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ScreamSuppressor))]
    ScreamSuppressor,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SingularityCortex))]
    SingularityCortex,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SpewingVents))]
    SpewingVents,
}