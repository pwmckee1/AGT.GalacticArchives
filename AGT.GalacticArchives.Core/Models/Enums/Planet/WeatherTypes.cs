using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum WeatherTypes
{
    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.BlueAllConsumingCold))]
    BlueAllConsumingCold = 1,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.BlueAzureStorms))]
    BlueAzureStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.BlueElectricRain))]
    BlueElectricRain,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.BlueExtremeLowPressure))]
    BlueExtremeLowPressure,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.BlueFrozenMists))]
    BlueFrozenMists,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.BlueInvertedSuperstorms))]
    BlueInvertedSuperstorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.BlueUltramarineWind))]
    BlueUltramarineWind,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.BlueUnfathomableStorms))]
    BlueUnfathomableStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.BlueUnimaginableBlue))]
    BlueUnimaginableBlue,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.BlueWindsfromBeyond))]
    BlueWindsfromBeyond,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearAbsent))]
    ClearAbsent,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearAcidRain))]
    ClearAcidRain,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearAirless))]
    ClearAirless,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearAnomalous))]
    ClearAnomalous,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearAshenWinds))]
    ClearAshenWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearAshPlumes))]
    ClearAshPlumes,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearAshWisps))]
    ClearAshWisps,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearBaked))]
    ClearBaked,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearBalmy))]
    ClearBalmy,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearBeautiful))]
    ClearBeautiful,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearBlissful))]
    ClearBlissful,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearBurningMists))]
    ClearBurningMists,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearCausticMoisture))]
    ClearCausticMoisture,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearChokingAsh))]
    ClearChokingAsh,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearChokingClouds))]
    ClearChokingClouds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearCinderfalls))]
    ClearCinderfalls,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearClear))]
    ClearClear,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearCloudsofHauntedGreen))]
    ClearCloudsofHauntedGreen,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearContaminatedPuddles))]
    ClearContaminatedPuddles,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearCorrosiveDamp))]
    ClearCorrosiveDamp,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearCorruptedBlood))]
    ClearCorruptedBlood,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearCrimsonHeat))]
    ClearCrimsonHeat,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearCrisp))]
    ClearCrisp,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.ClearDeadlyPressureVariations))]
    ClearDeadlyPressureVariations,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearDehydrated))]
    ClearDehydrated,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearDirectSunlight))]
    ClearDirectSunlight,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearDriftingSmog))]
    ClearDriftingSmog,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearDryGusts))]
    ClearDryGusts,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearEchoesofAcid))]
    ClearEchoesofAcid,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearEerilyCalm))]
    ClearEerilyCalm,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearEmollient))]
    ClearEmollient,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearEnvelopingAsh))]
    ClearEnvelopingAsh,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearFair))]
    ClearFair,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearFine))]
    ClearFine,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearFreezing))]
    ClearFreezing,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearFrost))]
    ClearFrost,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearGammaDust))]
    ClearGammaDust,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearGentleMist))]
    ClearGentleMist,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearHauntedFrost))]
    ClearHauntedFrost,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearHeatedAtmosphere))]
    ClearHeatedAtmosphere,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearHumid))]
    ClearHumid,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearIcy))]
    ClearIcy,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearIcyNights))]
    ClearIcyNights,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearIndetectableBurning))]
    ClearIndetectableBurning,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearInert))]
    ClearInert,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearInescapableToxins))]
    ClearInescapableToxins,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearInfiniteToxicMist))]
    ClearInfiniteToxicMist,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearInternalRain))]
    ClearInternalRain,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearInvisibleJadeWinds))]
    ClearInvisibleJadeWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearInvisibleMist))]
    ClearInvisibleMist,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearIrradiatedWinds))]
    ClearIrradiatedWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearLightShowers))]
    ClearLightShowers,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearLostClouds))]
    ClearLostClouds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearMellow))]
    ClearMellow,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearMemoriesofFrost))]
    ClearMemoriesofFrost,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearMildDamp))]
    ClearMildDamp,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearMildRain))]
    ClearMildRain,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearModerate))]
    ClearModerate,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearMoistureless))]
    ClearMoistureless,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearMuggyHaze))]
    ClearMuggyHaze,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearNoAtmosphere))]
    ClearNoAtmosphere,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearNuclidicAtmosphere))]
    ClearNuclidicAtmosphere,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearObsidianHeat))]
    ClearObsidianHeat,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearOverlyWarm))]
    ClearOverlyWarm,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearParched))]
    ClearParched,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearPeaceful))]
    ClearPeaceful,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearPeacefulClimate))]
    ClearPeacefulClimate,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearPerfectlyClear))]
    ClearPerfectlyClear,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearPermafrost))]
    ClearPermafrost,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearPleasant))]
    ClearPleasant,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearPoisonousGas))]
    ClearPoisonousGas,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearPoisonRain))]
    ClearPoisonRain,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearPowderSnow))]
    ClearPowderSnow,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearRadioactiveDamp))]
    ClearRadioactiveDamp,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearRadioactiveHumidity))]
    ClearRadioactiveHumidity,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearRedacted))]
    ClearRedacted,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearRefreshingBreeze))]
    ClearRefreshingBreeze,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearSilent))]
    ClearSilent,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearSmotheringAsh))]
    ClearSmotheringAsh,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearSnowy))]
    ClearSnowy,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearSterile))]
    ClearSterile,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearStingingAtmosphere))]
    ClearStingingAtmosphere,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearStingingPuddles))]
    ClearStingingPuddles,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearSulfurFumes))]
    ClearSulfurFumes,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearSulphurousHaze))]
    ClearSulphurousHaze,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearSunny))]
    ClearSunny,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearSweatyDrizzle))]
    ClearSweatyDrizzle,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearSweltering))]
    ClearSweltering,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearTemperate))]
    ClearTemperate,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearTemperateMurk))]
    ClearTemperateMurk,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearTempered))]
    ClearTempered,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearTepidDamp))]
    ClearTepidDamp,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearThirstyClouds))]
    ClearThirstyClouds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearToxicClouds))]
    ClearToxicClouds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearToxicDamp))]
    ClearToxicDamp,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearTropicalWinds))]
    ClearTropicalWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearUncloudedSkies))]
    ClearUncloudedSkies,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearUnendingSunlight))]
    ClearUnendingSunlight,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearUnstableAtmosphere))]
    ClearUnstableAtmosphere,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearUtterlyStill))]
    ClearUtterlyStill,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearVolatileWinds))]
    ClearVolatileWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearWarmDewdrops))]
    ClearWarmDewdrops,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearWarmFog))]
    ClearWarmFog,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearWindsofGlass))]
    ClearWindsofGlass,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearWintry))]
    ClearWintry,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ClearWithered))]
    ClearWithered,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeAcidicDeluges))]
    ExtremeAcidicDeluges,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeAcidicDustPockets))]
    ExtremeAcidicDustPockets,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeAllConsumingFog))]
    ExtremeAllConsumingFog,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeAshenDestruction))]
    ExtremeAshenDestruction,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeBasaltHail))]
    ExtremeBasaltHail,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeBillowingDustStorms))]
    ExtremeBillowingDustStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeBlastedAtmosphere))]
    ExtremeBlastedAtmosphere,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeBlisteringFloods))]
    ExtremeBlisteringFloods,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeBoilingCatastrophe))]
    ExtremeBoilingCatastrophe,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeBoilingMonsoons))]
    ExtremeBoilingMonsoons,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeBoilingSuperstorms))]
    ExtremeBoilingSuperstorms,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.ExtremeBoneStrippingAcidStorms))]
    ExtremeBoneStrippingAcidStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeBroilingHumidity))]
    ExtremeBroilingHumidity,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeBurningGasClouds))]
    ExtremeBurningGasClouds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeCataclysmicMonsoons))]
    ExtremeCataclysmicMonsoons,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeCausticFloods))]
    ExtremeCausticFloods,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeChokingSandstorms))]
    ExtremeChokingSandstorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeCloudsofFire))]
    ExtremeCloudsofFire,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeColossalFirestorms))]
    ExtremeColossalFirestorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeCombustibleDust))]
    ExtremeCombustibleDust,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.ExtremeConstantPressureStorms))]
    ExtremeConstantPressureStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeContaminatedSqualls))]
    ExtremeContaminatedSqualls,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeCorrosiveCyclones))]
    ExtremeCorrosiveCyclones,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeCorrosiveRainstorms))]
    ExtremeCorrosiveRainstorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeCorrosiveStorms))]
    ExtremeCorrosiveStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeDampMisery))]
    ExtremeDampMisery,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeDeadWastes))]
    ExtremeDeadWastes,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeDeathFog))]
    ExtremeDeathFog,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeDeepFreeze))]
    ExtremeDeepFreeze,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.ExtremeEnormousNuclearStorms))]
    ExtremeEnormousNuclearStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeEternalCyclones))]
    ExtremeEternalCyclones,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.ExtremeExplosiveGasEruptions))]
    ExtremeExplosiveGasEruptions,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.ExtremeExtremeAtmosphericDecay))]
    ExtremeExtremeAtmosphericDecay,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeExtremeHeat))]
    ExtremeExtremeHeat,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeExtremeRadioactivity))]
    ExtremeExtremeRadioactivity,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.ExtremeExtremeThermonuclearFog))]
    ExtremeExtremeThermonuclearFog,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeExtremeWindBlasting))]
    ExtremeExtremeWindBlasting,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeFirestorms))]
    ExtremeFirestorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeFrequentBlizzards))]
    ExtremeFrequentBlizzards,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeFrequentFirestorms))]
    ExtremeFrequentFirestorms,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.ExtremeFrequentParticleEruptions))]
    ExtremeFrequentParticleEruptions,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeFrequentToxicFloods))]
    ExtremeFrequentToxicFloods,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeGammaCyclones))]
    ExtremeGammaCyclones,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeGasStorms))]
    ExtremeGasStorms,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.ExtremeHazardousTemperatureExtremes))]
    ExtremeHazardousTemperatureExtremes,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeHazardousWhiteouts))]
    ExtremeHazardousWhiteouts,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeHowlingBlizzards))]
    ExtremeHowlingBlizzards,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeHowlingGales))]
    ExtremeHowlingGales,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeIceStorms))]
    ExtremeIceStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeIcyTempests))]
    ExtremeIcyTempests,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeIncendiaryDust))]
    ExtremeIncendiaryDust,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeInescapableToxins))]
    ExtremeInescapableToxins,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeInfernoWinds))]
    ExtremeInfernoWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeIntenseCold))]
    ExtremeIntenseCold,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeIntenseHeat))]
    ExtremeIntenseHeat,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeIntenseHeatbursts))]
    ExtremeIntenseHeatbursts,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.ExtremeIrradiatedThunderstorms))]
    ExtremeIrradiatedThunderstorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeLethalAshStorms))]
    ExtremeLethalAshStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeLiquidHell))]
    ExtremeLiquidHell,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeLungBurningNightWind))]
    ExtremeLungBurningNightWind,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeMagmaRain))]
    ExtremeMagmaRain,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeMeltingDeluges))]
    ExtremeMeltingDeluges,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeMistsofAnnihilation))]
    ExtremeMistsofAnnihilation,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeNoxiousGasStorms))]
    ExtremeNoxiousGasStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremePainfullyHotRain))]
    ExtremePainfullyHotRain,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.ExtremePlanetwideDesiccation))]
    ExtremePlanetwideDesiccation,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremePlanetWideMaelstrom))]
    ExtremePlanetWideMaelstrom,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.ExtremePlanetWideRadiationStorms))]
    ExtremePlanetWideRadiationStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremePouringToxicRain))]
    ExtremePouringToxicRain,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeRagingSnowstorms))]
    ExtremeRagingSnowstorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeRareFirestorms))]
    ExtremeRareFirestorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeRoaringIceStorms))]
    ExtremeRoaringIceStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeRoaringNuclearWind))]
    ExtremeRoaringNuclearWind,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeSandBlizzards))]
    ExtremeSandBlizzards,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeScaldingHeat))]
    ExtremeScaldingHeat,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeScaldingRainstorms))]
    ExtremeScaldingRainstorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeSelfIgnitingStorms))]
    ExtremeSelfIgnitingStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeStormsofDesolation))]
    ExtremeStormsofDesolation,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeSulphurousInferno))]
    ExtremeSulphurousInferno,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeSultryDisaster))]
    ExtremeSultryDisaster,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeSupercooledStorms))]
    ExtremeSupercooledStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeSuperheatedAir))]
    ExtremeSuperheatedAir,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeSuperheatedRain))]
    ExtremeSuperheatedRain,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeTorrentialAcid))]
    ExtremeTorrentialAcid,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeTorrentialHeat))]
    ExtremeTorrentialHeat,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeTorridDeluges))]
    ExtremeTorridDeluges,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeToxicDamp))]
    ExtremeToxicDamp,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeToxicMonsoons))]
    ExtremeToxicMonsoons,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeToxicSuperstorms))]
    ExtremeToxicSuperstorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.ExtremeWallsofFlame))]
    ExtremeWallsofFlame,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.GreenBiliousStorms))]
    GreenBiliousStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.GreenCloudsofHauntedGreen))]
    GreenCloudsofHauntedGreen,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.GreenCorruptedBlood))]
    GreenCorruptedBlood,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.GreenDeadlyPressureVariations))]
    GreenDeadlyPressureVariations,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.GreenEchoesofAcid))]
    GreenEchoesofAcid,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.GreenHarshToxicWind))]
    GreenHarshToxicWind,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.GreenInescapableToxins))]
    GreenInescapableToxins,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.GreenInfiniteToxicMist))]
    GreenInfiniteToxicMist,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.GreenInvisibleJadeWinds))]
    GreenInvisibleJadeWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.GreenPoisonCyclones))]
    GreenPoisonCyclones,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalAcidicDustPockets))]
    NormalAcidicDustPockets,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalAlkalineCloudbursts))]
    NormalAlkalineCloudbursts,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalAtmosphericCorruption))]
    NormalAtmosphericCorruption,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.NormalAtmosphericHeatInstabilities))]
    NormalAtmosphericHeatInstabilities,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalBiliousStorms))]
    NormalBiliousStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalBlastedAtmosphere))]
    NormalBlastedAtmosphere,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalBlisteringDamp))]
    NormalBlisteringDamp,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalBoilingPuddles))]
    NormalBoilingPuddles,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalBurningAir))]
    NormalBurningAir,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalCausticMoisture))]
    NormalCausticMoisture,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalCausticWinds))]
    NormalCausticWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalCeaselessDrought))]
    NormalCeaselessDrought,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalChokingHumidity))]
    NormalChokingHumidity,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalClammyMenace))]
    NormalClammyMenace,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalCoastalStorms))]
    NormalCoastalStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalCorrosiveRainstorms))]
    NormalCorrosiveRainstorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalCorrosiveSleetStorms))]
    NormalCorrosiveSleetStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalCorruptedBlood))]
    NormalCorruptedBlood,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalDangerouslyHot))]
    NormalDangerouslyHot,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalDangerouslyHotFog))]
    NormalDangerouslyHotFog,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalDangerouslyToxicRain))]
    NormalDangerouslyToxicRain,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.NormalDeadlyPressureVariations))]
    NormalDeadlyPressureVariations,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalDirectSunlight))]
    NormalDirectSunlight,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalDriftingFirestorms))]
    NormalDriftingFirestorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalDriftingSnowstorms))]
    NormalDriftingSnowstorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalDustChokedWinds))]
    NormalDustChokedWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalEnergeticStorms))]
    NormalEnergeticStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalFreezingNightWinds))]
    NormalFreezingNightWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalFrozenClouds))]
    NormalFrozenClouds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalHarsh))]
    NormalHarsh,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.IcyWinds))]
    IcyWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalHazardousMoisture))]
    NormalHazardousMoisture,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalHeatedAtmosphere))]
    NormalHeatedAtmosphere,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalHeatedGasPockets))]
    NormalHeatedGasPockets,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.NormalHighlyVariableTemperatures))]
    NormalHighlyVariableTemperatures,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalIceStorms))]
    NormalIceStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalIcy))]
    NormalIcy,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalIcyBlasts))]
    NormalIcyBlasts,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalIncendiaryWinds))]
    NormalIncendiaryWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalInfrequentBlizzards))]
    NormalInfrequentBlizzards,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalInfrequentDustStorms))]
    NormalInfrequentDustStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalInfrequentHeatStorms))]
    NormalInfrequentHeatStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalInfrequentTorrents))]
    NormalInfrequentTorrents,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.NormalInfrequentToxicDrizzle))]
    NormalInfrequentToxicDrizzle,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.NormalIntermittentWindBlasting))]
    NormalIntermittentWindBlasting,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalInvisibleJadeWinds))]
    NormalInvisibleJadeWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalIrradiatedDownpours))]
    NormalIrradiatedDownpours,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalIrradiatedStorms))]
    NormalIrradiatedStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalLethalAtmosphere))]
    NormalLethalAtmosphere,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.NormalLethalHumidityOutbreaks))]
    NormalLethalHumidityOutbreaks,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalMagmaGeysers))]
    NormalMagmaGeysers,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalMigratoryBlizzards))]
    NormalMigratoryBlizzards,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalMoltenRain))]
    NormalMoltenRain,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalMostlyCalm))]
    NormalMostlyCalm,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalObsidianDoom))]
    NormalObsidianDoom,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalOccasionalAcidStorms))]
    NormalOccasionalAcidStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalOccasionalAshStorms))]
    NormalOccasionalAshStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalOccasionalBoilingFog))]
    NormalOccasionalBoilingFog,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalOccasionalFirestorms))]
    NormalOccasionalFirestorms,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.NormalOccasionalRadiationOutbursts))]
    NormalOccasionalRadiationOutbursts,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalOccasionalSandstorms))]
    NormalOccasionalSandstorms,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.NormalOccasionalScaldingCloudbursts))]
    NormalOccasionalScaldingCloudbursts,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalOccasionalSnowfall))]
    NormalOccasionalSnowfall,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalOppressive))]
    NormalOppressive,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalOutbreaksofFrozenRain))]
    NormalOutbreaksofFrozenRain,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalPainfulMist))]
    NormalPainfulMist,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalParched))]
    NormalParched,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalParchedSands))]
    NormalParchedSands,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalParticulateWinds))]
    NormalParticulateWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalPassingToxicFronts))]
    NormalPassingToxicFronts,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalPillarsofFlame))]
    NormalPillarsofFlame,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalPlumesofFire))]
    NormalPlumesofFire,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalPoisonCyclones))]
    NormalPoisonCyclones,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalPoisonFlurries))]
    NormalPoisonFlurries,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalRadioactiveDustStorms))]
    NormalRadioactiveDustStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalReactiveRain))]
    NormalReactiveRain,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalSoggyDanger))]
    NormalSoggyDanger,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalSporadicGritStorms))]
    NormalSporadicGritStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalStickyHeat))]
    NormalStickyHeat,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalSuperheatedDrizzle))]
    NormalSuperheatedDrizzle,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalSuperheatedGasPockets))]
    NormalSuperheatedGasPockets,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalSuperheatedMists))]
    NormalSuperheatedMists,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalSwelteringDamp))]
    NormalSwelteringDamp,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalTectonicStorms))]
    NormalTectonicStorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalToxicOutbreaks))]
    NormalToxicOutbreaks,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalTropicalStorms))]
    NormalTropicalStorms,

    [Display(
        ResourceType = typeof(WeatherResource),
        Description = nameof(WeatherResource.NormalUnpredictableConflagrations))]
    NormalUnpredictableConflagrations,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalUnstableFog))]
    NormalUnstableFog,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalUsuallyMild))]
    NormalUsuallyMild,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalVolatileWindstorms))]
    NormalVolatileWindstorms,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalWanderingFrosts))]
    NormalWanderingFrosts,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.NormalWanderingHotSpots))]
    NormalWanderingHotSpots,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.RedAngeredClouds))]
    RedAngeredClouds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.RedBloodRain))]
    RedBloodRain,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.RedBurningCrimson))]
    RedBurningCrimson,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.RedCarmineWinds))]
    RedCarmineWinds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.RedFeveredClouds))]
    RedFeveredClouds,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.RedFlamingHail))]
    RedFlamingHail,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.RedRainofAtlas))]
    RedRainofAtlas,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.RedRedMist))]
    RedRedMist,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.RedScarletRain))]
    RedScarletRain,

    [Display(ResourceType = typeof(WeatherResource), Description = nameof(WeatherResource.RedVermillionStorms))]
    RedVermillionStorms,
}