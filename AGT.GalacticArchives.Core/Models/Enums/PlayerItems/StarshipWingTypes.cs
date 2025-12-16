using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization.PlayerItems;

namespace AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

public enum StarshipWingTypes
{
    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExoticMosquitoFin))]
    ExoticMosquitoFin = 1,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExoticRoyalFin))]
    ExoticRoyalFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExoticVWing))]
    ExoticVWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExoticSideBooster))]
    ExoticSideBooster,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExoticSideWing))]
    ExoticSideWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerArcfoil))]
    ExplorerArcfoil,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerAxial))]
    ExplorerAxial,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerDragonfly))]
    ExplorerDragonfly,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerDrum))]
    ExplorerDrum,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerDrumObelisk))]
    ExplorerDrumObelisk,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerDrumOverseer))]
    ExplorerDrumOverseer,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerDrumShortwave))]
    ExplorerDrumShortwave,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerFireflyWing))]
    ExplorerFireflyWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerGlider))]
    ExplorerGlider,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerLongwave))]
    ExplorerLongwave,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerObelisk))]
    ExplorerObelisk,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerObserver))]
    ExplorerObserver,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerPlanar))]
    ExplorerPlanar,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerPrismatic))]
    ExplorerPrismatic,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerPulsarSplit))]
    ExplorerPulsarSplit,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerPulsarStub))]
    ExplorerPulsarStub,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerPulsar))]
    ExplorerPulsar,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerShortwave))]
    ExplorerShortwave,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerSkylance))]
    ExplorerSkylance,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerSkywave))]
    ExplorerSkywave,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerSolarFlare))]
    ExplorerSolarFlare,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerSolarPulse))]
    ExplorerSolarPulse,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerSolarWing))]
    ExplorerSolarWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerSunspot))]
    ExplorerSunspot,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerSunspotSplitWing))]
    ExplorerSunspotSplitWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerSunspotStubWing))]
    ExplorerSunspotStubWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerSuperfoil))]
    ExplorerSuperfoil,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerVortex))]
    ExplorerVortex,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerWingCapRound))]
    ExplorerWingCapRound,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerWingCapVertical))]
    ExplorerWingCapVertical,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ExplorerWingStub))]
    ExplorerWingStub,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterAferburnerCWing))]
    FighterAferburnerCWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterAfterburner))]
    FighterAfterburner,

    [Display(
        ResourceType = typeof(StarshipResource),
        Description = nameof(StarshipResource.FighterAfterburnerCWingFin))]
    FighterAfterburnerCWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterAfterburnerEWing))]
    FighterAfterburnerEWing,

    [Display(
        ResourceType = typeof(StarshipResource),
        Description = nameof(StarshipResource.FighterAfterburnerEWingFin))]
    FighterAfterburnerEWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterAfterburnerFin))]
    FighterAfterburnerFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterAfterburnerVWing))]
    FighterAfterburnerVWing,

    [Display(
        ResourceType = typeof(StarshipResource),
        Description = nameof(StarshipResource.FighterAfterburnerVWingFin))]
    FighterAfterburnerVWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterCondor))]
    FighterCondor,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterCondorFin))]
    FighterCondorFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterDroidCWing))]
    FighterDroidCWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterDroidCWingFin))]
    FighterDroidCWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterDroidEWing))]
    FighterDroidEWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterDroidEWingFin))]
    FighterDroidEWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterDroidSWing))]
    FighterDroidSWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterDroidSWingFin))]
    FighterDroidSWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterDroidVWing))]
    FighterDroidVWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterDroidVWingFin))]
    FighterDroidVWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterDroidWing))]
    FighterDroidWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterDroidWingFin))]
    FighterDroidWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterGullWing))]
    FighterGullWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterHalo))]
    FighterHalo,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterHardframeCWing))]
    FighterHardframeCWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterHardframeCWingFin))]
    FighterHardframeCWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterHardframeEWing))]
    FighterHardframeEWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterHardframeEWingFin))]
    FighterHardframeEWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterHardframeSWing))]
    FighterHardframeSWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterHardframeSWingFin))]
    FighterHardframeSWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterHardframeVWing))]
    FighterHardframeVWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterHardframeVWingFin))]
    FighterHardframeVWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterHardframeWing))]
    FighterHardframeWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterHardframeWingFin))]
    FighterHardframeWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterHorizonWing))]
    FighterHorizonWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterHorizonWingFin))]
    FighterHorizonWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterPalisadeWing))]
    FighterPalisadeWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterPalisadeWingFin))]
    FighterPalisadeWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterQuasarWing))]
    FighterQuasarWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterQuasarWingFin))]
    FighterQuasarWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterRadiantWing))]
    FighterRadiantWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterRadiantWingFin))]
    FighterRadiantWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterStardancerWing))]
    FighterStardancerWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterStardancerWingFin))]
    FighterStardancerWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterSweptWingFull))]
    FighterSweptWingFull,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterSweptWingLow))]
    FighterSweptWingLow,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterSweptWingMid))]
    FighterSweptWingMid,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterVectorWing))]
    FighterVectorWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterVectorWingFin))]
    FighterVectorWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterVesperWing))]
    FighterVesperWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterVesperWingFin))]
    FighterVesperWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterVesperWingSwept))]
    FighterVesperWingSwept,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterVigilWing))]
    FighterVigilWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterVultureWing))]
    FighterVultureWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.FighterVultureWingFin))]
    FighterVultureWingFin,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerAviatorWing))]
    HaulerAviatorWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulkerAWing))]
    HaulerBulkerAWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulkerDWing))]
    HaulerBulkerDWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulkerFWing))]
    HaulerBulkerFWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulkerSWing))]
    HaulerBulkerSWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulkerWing))]
    HaulerBulkerWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulwarkAWing))]
    HaulerBulwarkAWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulwarkCWing))]
    HaulerBulwarkCWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulwarkDWing))]
    HaulerBulwarkDWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulwarkFWing))]
    HaulerBulwarkFWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulwarkFanWing))]
    HaulerBulwarkFanWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulwarkSWing))]
    HaulerBulwarkSWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulwarkSplitWing))]
    HaulerBulwarkSplitWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulwarkVWing))]
    HaulerBulwarkVWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulwarkWWing))]
    HaulerBulwarkWWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerBulwarkWing))]
    HaulerBulwarkWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerEWingHeavy))]
    HaulerEWingHeavy,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerEmptyWingPanel))]
    HaulerEmptyWingPanel,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerFireboxAWing))]
    HaulerFireboxAWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerFireboxCWing))]
    HaulerFireboxCWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerFireboxDWing))]
    HaulerFireboxDWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerFireboxFWing))]
    HaulerFireboxFWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerFireboxSWing))]
    HaulerFireboxSWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerFireboxSplitWing))]
    HaulerFireboxSplitWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerFireboxVWing))]
    HaulerFireboxVWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerFireboxWWing))]
    HaulerFireboxWWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerFireboxWing))]
    HaulerFireboxWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerFuselageArmour))]
    HaulerFuselageArmour,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerHeavy22AWing))]
    HaulerHeavy22AWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerHeavy22FWing))]
    HaulerHeavy22FWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerHeavy22SWing))]
    HaulerHeavy22SWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerHeavy22SplitWing))]
    HaulerHeavy22SplitWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerHeavy22VWing))]
    HaulerHeavy22VWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerHeavy22WWing))]
    HaulerHeavy22WWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerHeavy22Wing))]
    HaulerHeavy22Wing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerHiRocLauncher))]
    HaulerHiRocLauncher,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerImpulseAWing))]
    HaulerImpulseAWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerImpulseCWing))]
    HaulerImpulseCWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerImpulseDWing))]
    HaulerImpulseDWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerImpulseFWing))]
    HaulerImpulseFWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerImpulseLauncher))]
    HaulerImpulseLauncher,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerImpulseSWing))]
    HaulerImpulseSWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerImpulseSplitWing))]
    HaulerImpulseSplitWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerImpulseVWing))]
    HaulerImpulseVWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerImpulseWWing))]
    HaulerImpulseWWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerImpulseWing))]
    HaulerImpulseWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerIonBladeWing))]
    HaulerIonBladeWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerIonFlareAWing))]
    HaulerIonFlareAWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerIonFlareCWing))]
    HaulerIonFlareCWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerIonFlareDWing))]
    HaulerIonFlareDWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerIonFlareFWing))]
    HaulerIonFlareFWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerIonFlareSWing))]
    HaulerIonFlareSWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerIonFlareSplitWing))]
    HaulerIonFlareSplitWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerIonFlareVWing))]
    HaulerIonFlareVWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerIonFlareWWing))]
    HaulerIonFlareWWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerIonFlareWing))]
    HaulerIonFlareWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerIronVultureWing))]
    HaulerIronVultureWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerLongshoreAWing))]
    HaulerLongshoreAWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerLongshoreCWing))]
    HaulerLongshoreCWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerLongshoreDWing))]
    HaulerLongshoreDWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerLongshoreFWing))]
    HaulerLongshoreFWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerLongshoreFanWing))]
    HaulerLongshoreFanWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerLongshoreSWing))]
    HaulerLongshoreSWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerLongshoreSplitWing))]
    HaulerLongshoreSplitWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerLongshoreVWing))]
    HaulerLongshoreVWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerLongshoreWWing))]
    HaulerLongshoreWWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerLongshoreWing))]
    HaulerLongshoreWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerMegalithAWing))]
    HaulerMegalithAWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerMegalithDWing))]
    HaulerMegalithDWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerMegalithFWing))]
    HaulerMegalithFWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerMegalithSWing))]
    HaulerMegalithSWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerMegalithWing))]
    HaulerMegalithWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerRamjetAWing))]
    HaulerRamjetAWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerRamjetCWing))]
    HaulerRamjetCWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerRamjetDWing))]
    HaulerRamjetDWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerRamjetFWing))]
    HaulerRamjetFWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerRamjetSWing))]
    HaulerRamjetSWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerRamjetSplitWing))]
    HaulerRamjetSplitWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerRamjetVWing))]
    HaulerRamjetVWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerRamjetWWing))]
    HaulerRamjetWWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerRamjetWing))]
    HaulerRamjetWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerStratopulseAWing))]
    HaulerStratopulseAWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerStratopulseCWing))]
    HaulerStratopulseCWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerStratopulseDWing))]
    HaulerStratopulseDWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerStratopulseFWing))]
    HaulerStratopulseFWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerStratopulseFanWing))]
    HaulerStratopulseFanWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerStratopulseSWing))]
    HaulerStratopulseSWing,

    [Display(
        ResourceType = typeof(StarshipResource),
        Description = nameof(StarshipResource.HaulerStratopulseSplitWing))]
    HaulerStratopulseSplitWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerStratopulseVWing))]
    HaulerStratopulseVWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerStratopulseWWing))]
    HaulerStratopulseWWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerStratopulseWing))]
    HaulerStratopulseWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerSupercondorWing))]
    HaulerSupercondorWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerSupercruiseAWing))]
    HaulerSupercruiseAWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerSupercruiseCWing))]
    HaulerSupercruiseCWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerSupercruiseDWing))]
    HaulerSupercruiseDWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerSupercruiseFWing))]
    HaulerSupercruiseFWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerSupercruiseFanWing))]
    HaulerSupercruiseFanWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerSupercruiseSWing))]
    HaulerSupercruiseSWing,

    [Display(
        ResourceType = typeof(StarshipResource),
        Description = nameof(StarshipResource.HaulerSupercruiseSplitWing))]
    HaulerSupercruiseSplitWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerSupercruiseVWing))]
    HaulerSupercruiseVWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerSupercruiseWWing))]
    HaulerSupercruiseWWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerSupercruiseWing))]
    HaulerSupercruiseWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerTitanAWing))]
    HaulerTitanAWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerTitanDWing))]
    HaulerTitanDWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerTitanFWing))]
    HaulerTitanFWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerTitanSWing))]
    HaulerTitanSWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerTitanWing))]
    HaulerTitanWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerTurbineWing))]
    HaulerTurbineWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerUltralithWing))]
    HaulerUltralithWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerWidebodyAWing))]
    HaulerWidebodyAWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerWidebodyCWing))]
    HaulerWidebodyCWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerWidebodyDWing))]
    HaulerWidebodyDWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerWidebodyFWing))]
    HaulerWidebodyFWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerWidebodyFanWing))]
    HaulerWidebodyFanWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerWidebodySWing))]
    HaulerWidebodySWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerWidebodySplitWing))]
    HaulerWidebodySplitWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerWidebodyVWing))]
    HaulerWidebodyVWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerWidebodyWWing))]
    HaulerWidebodyWWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.HaulerWidebodyWing))]
    HaulerWidebodyWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorHilt))]
    InterceptorHilt,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorGuard))]
    InterceptorGuard,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorPommel))]
    InterceptorPommel,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorHiltElytra))]
    InterceptorHiltElytra,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorGuardElytra))]
    InterceptorGuardElytra,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.InterceptorPommelElytra))]
    InterceptorPommelElytra,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarCutlassWingDrill))]
    SolarCutlassWingDrill,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarCutlassWingHBlade))]
    SolarCutlassWingHBlade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarCutlassWingSleek))]
    SolarCutlassWingSleek,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarCutlassWingTristar))]
    SolarCutlassWingTristar,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarCutlassWingVBlade))]
    SolarCutlassWingVBlade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarRazorWingDrill))]
    SolarRazorWingDrill,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarRazorWingHBlade))]
    SolarRazorWingHBlade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarRazorWingSleek))]
    SolarRazorWingSleek,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarRazorWingTristar))]
    SolarRazorWingTristar,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarRazorWingVBlade))]
    SolarRazorWingVBlade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarSabreWingDrill))]
    SolarSabreWingDrill,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarSabreWingHBlade))]
    SolarSabreWingHBlade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarSabreWingSleek))]
    SolarSabreWingSleek,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarSabreWingTristar))]
    SolarSabreWingTristar,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarSabreWingVBlade))]
    SolarSabreWingVBlade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarScimitarWingDrill))]
    SolarScimitarWingDrill,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarScimitarWingHBlade))]
    SolarScimitarWingHBlade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarScimitarWingSleek))]
    SolarScimitarWingSleek,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarScimitarWingTristar))]
    SolarScimitarWingTristar,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarScimitarWingVBlade))]
    SolarScimitarWingVBlade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarShieldedWingDrill))]
    SolarShieldedWingDrill,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarShieldedWingHBlade))]
    SolarShieldedWingHBlade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarShieldedWingSleek))]
    SolarShieldedWingSleek,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarShieldedWingTristar))]
    SolarShieldedWingTristar,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarShieldedWingVBlade))]
    SolarShieldedWingVBlade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarTalonWingDrill))]
    SolarTalonWingDrill,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarTalonWingHBlade))]
    SolarTalonWingHBlade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarTalonWingSleek))]
    SolarTalonWingSleek,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarTalonWingTristar))]
    SolarTalonWingTristar,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.SolarTalonWingVBlade))]
    SolarTalonWingVBlade,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleVWing))]
    ShuttleVWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleGrillWing))]
    ShuttleGrillWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleVoyager))]
    ShuttleVoyager,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleXWing))]
    ShuttleXWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleYWing))]
    ShuttleYWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleDropWing))]
    ShuttleDropWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleBentWing))]
    ShuttleBentWing,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleGlider))]
    ShuttleGlider,

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.ShuttleLowWing))]
    ShuttleLowWing,
}