using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum ExoSuitUpgradeTypes
{
    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.DefenceSystemsUpgrade))]
    DefenceSystemsUpgrade = 1,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.LifeSupportUpgrade))]
    LifeSupportUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.MovementSystemUpgrade))]
    MovementSystemUpgrade,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.RadiationProtectionModule))]
    RadiationProtectionModule,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.ThermalProtectionModuleCold))]
    ThermalProtectionModuleCold,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.ThermalProtectionModuleHeat))]
    ThermalProtectionModuleHeat,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.ToxicProtectionModule))]
    ToxicProtectionModule,

    [Display(
        ResourceType = typeof(StarSystemResource),
        Description = nameof(StarSystemResource.UnderwaterProtectionModule))]
    UnderwaterProtectionModule,
}