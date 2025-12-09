using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum StarshipUpgradeTypes
{
    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.CyclotronBallistaUpgrade))]
    CyclotronBallistaUpgrade = 1,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.DeflectorShieldUpgrade))]
    DeflectorShieldUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.HyperdriveUpgrade))]
    HyperdriveUpgrade,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.InfraKnifeAcceleratorUpgrade))]
    InfraKnifeAcceleratorUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.LaunchThrusterUpgrade))]
    LaunchThrusterUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.PhaseBeamUpgrade))]
    PhaseBeamUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.PhotonCannonUpgrade))]
    PhotonCannonUpgrade,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.PositronEjectorUpgrade))]
    PositronEjectorUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.PulseEngineUpgrade))]
    PulseEngineUpgrade,
}