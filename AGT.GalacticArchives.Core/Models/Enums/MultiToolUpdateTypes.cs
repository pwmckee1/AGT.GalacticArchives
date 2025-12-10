using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum MultiToolUpdateTypes
{
    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.AdvancedMiningLaser))]
    AdvancedMiningLaser = 1,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.AnalysisVisorUpgrade))]
    AnalysisVisorUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.BlazeJavelinUpgrade))]
    BlazeJavelinUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.BoltcasterUpgrade))]
    BoltcasterUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.GeologyCannonUpgrade))]
    GeologyCannonUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.MiningBeamUpgrade))]
    MiningBeamUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.NeutronCannonUpgrade))]
    NeutronCannonUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.PlasmaLauncherUpgrade))]
    PlasmaLauncherUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.PlasmaResonator))]
    PlasmaResonator,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.PulseSpitterUpgrade))]
    PulseSpitterUpgrade,

    [Display(ResourceType = typeof(StarSystemResource), Description = nameof(StarSystemResource.ScatterBlasterUpgrade))]
    ScatterBlasterUpgrade,
}