using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum ExocraftUpgradeModuleTypes
{
    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.ExocraftAccelerationModuleUpgrade))]
    ExocraftAccelerationModuleUpgrade = 1,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.ExocraftEngineModule))]
    ExocraftEngineModule,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.ExocraftMiningLaserUpgrade))]
    ExocraftMiningLaserUpgrade,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.ExocraftMountedCannonUpgrade))]
    ExocraftMountedCannonUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.FusionEngineUpgrade))]
    FusionEngineUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.HumboldtDriveUpgrade))]
    HumboldtDriveUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.MinotaurCannonUpgrade))]
    MinotaurCannonUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.MinotaurEngineUpgrade))]
    MinotaurEngineUpgrade,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.MinotaurFlamethrowerUpgrade))]
    MinotaurFlamethrowerUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.MinotaurLaserUpgrade))]
    MinotaurLaserUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.NautilonCannonUpgrade))]
    NautilonCannonUpgrade,
}