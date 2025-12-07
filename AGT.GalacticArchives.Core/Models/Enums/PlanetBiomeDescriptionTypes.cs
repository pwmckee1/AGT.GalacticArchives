using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum PlanetBiomeDescriptionTypes
{
    [Display(ResourceType = typeof(ApplicationResources), Description = nameof(ApplicationResources.NotApplicable))]
    NotApplicable,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenAbandoned))]
    BarrenAbandoned,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenBarren))]
    BarrenBarren,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenBleak))]
    BarrenBleak = 2,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenDesert))]
    BarrenDesert = 3,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenDesolate))]
    BarrenDesolate = 4,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenDusty))]
    BarrenDusty = 5,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenInfested))]
    BarrenInfested = 6,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenInfectedDustbowl))]
    BarrenInfectedDustbowl = 7,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenParched))]
    BarrenParched = 8,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenRocky))]
    BarrenRocky = 9,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenRuinedDustbowl))]
    BarrenRuinedDustbowl0,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenTainted))]
    BarrenTainted1,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenTerrorsphere))]
    BarrenTerrorsphere2,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenWindswept))]
    BarrenWindswept3,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.DeadAbandoned))]
    DeadAbandoned4,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.DeadAirless))]
    DeadAirless5,

    [Display(ResourceType = typeof(BiomeDescriptionResource), Description = nameof(BiomeDescriptionResource.DeadDead))]
    DeadDead6,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.DeadDesolate))]
    DeadDesolate7,

    [Display(ResourceType = typeof(BiomeDescriptionResource), Description = nameof(BiomeDescriptionResource.DeadEmpty))]
    DeadEmpty8,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.DeadForsaken))]
    DeadForsaken9,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.DeadLifeIncompatible))]
    DeadLifeIncompatible = 20,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.DeadLifeless))]
    DeadLifeless = 21,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.DeadLowAtmosphere))]
    DeadLowAtmosphere = 22,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.DeadTerraformingCatastrophe))]
    DeadTerraformingCatastrophe = 23,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticBladed))]
    ExoticBladed = 24,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticBreached))]
    ExoticBreached = 25,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticBubbling))]
    ExoticBubbling = 26,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticCabled))]
    ExoticCabled = 27,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticCalcified))]
    ExoticCalcified = 28,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticCapped))]
    ExoticCapped = 29,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticCloudsofHauntedGreen))]
    ExoticCloudsofHauntedGreen = 30,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticColumned))]
    ExoticColumned = 31,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticContoured))]
    ExoticContoured = 32,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticCorrupted))]
    ExoticCorrupted = 33,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticCrimson))]
    ExoticCrimson = 34,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticDoomed))]
    ExoticDoomed = 35,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticErased))]
    ExoticErased = 36,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticFinned))]
    ExoticFinned = 37,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticFissured))]
    ExoticFissured = 38,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticFoaming))]
    ExoticFoaming = 39,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticFractured))]
    ExoticFractured = 40,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticFragmented))]
    ExoticFragmented = 41,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticFrothing))]
    ExoticFrothing = 42,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticFungal))]
    ExoticFungal = 43,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticGlassy))]
    ExoticGlassy = 44,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticHexagonal))]
    ExoticHexagonal = 45,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticInfected))]
    ExoticInfected = 46,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticMalfunctioning))]
    ExoticMalfunctioning = 47,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticMechanical))]
    ExoticMechanical = 48,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticMetallic))]
    ExoticMetallic = 49,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticMetallurgic))]
    ExoticMetallurgic = 50,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticMoonofLight))]
    ExoticMoonofLight = 51,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticOssified))]
    ExoticOssified = 52,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticPetrified))]
    ExoticPetrified = 53,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticPillared))]
    ExoticPillared = 54,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticPlanetaryAnomaly))]
    ExoticPlanetaryAnomaly = 55,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticPlanetofLight))]
    ExoticPlanetofLight = 56,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticPlated))]
    ExoticPlated = 57,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticRattling))]
    ExoticRattling = 58,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticRedacted))]
    ExoticRedacted = 59,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticScaly))]
    ExoticScaly = 60,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticSharded))]
    ExoticSharded = 61,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticShattered))]
    ExoticShattered = 62,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticShellStrewn))]
    ExoticShellStrewn = 63,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticSkeletal))]
    ExoticSkeletal = 64,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticSpined))]
    ExoticSpined = 65,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticSporal))]
    ExoticSporal = 66,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticTemporary))]
    ExoticTemporary = 67,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticThirsty))]
    ExoticThirsty = 68,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ExoticWebbed))]
    ExoticWebbed = 69,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.FrozenArctic))]
    FrozenArctic = 70,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.FrozenFreezing))]
    FrozenFreezing = 71,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.FrozenFrozen))]
    FrozenFrozen = 72,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.FrozenFrozenHell))]
    FrozenFrozenHell = 73,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.FrozenFrostbound))]
    FrozenFrostbound = 74,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.FrozenGlacial))]
    FrozenGlacial = 75,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.FrozenHiemal))]
    FrozenHiemal = 76,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.FrozenHyperborean))]
    FrozenHyperborean = 77,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.FrozenIcebound))]
    FrozenIcebound = 78,

    [Display(ResourceType = typeof(BiomeDescriptionResource), Description = nameof(BiomeDescriptionResource.FrozenIcy))]
    FrozenIcy = 79,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.FrozenIcyAbhorrence))]
    FrozenIcyAbhorrence = 80,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.FrozenInfested))]
    FrozenInfested = 81,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.FrozenSubZero))]
    FrozenSubZero = 82,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.GasGiantMemoryTitan))]
    GasGiantMemoryTitan = 83,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.GasGiantPetrifiedGiant))]
    GasGiantPetrifiedGiant = 84,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.GasGiantTBD3))]
    GasGiantTBD3 = 85,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.GasGiantTBD4))]
    GasGiantTBD4 = 86,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.IrradiatedContaminated))]
    IrradiatedContaminated = 87,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.IrradiatedDecayingNuclear))]
    IrradiatedDecayingNuclear = 88,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.IrradiatedGammaIntensive))]
    IrradiatedGammaIntensive = 89,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.IrradiatedHighEnergy))]
    IrradiatedHighEnergy = 90,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.IrradiatedHighRadioSource))]
    IrradiatedHighRadioSource = 91,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.IrradiatedInfested))]
    IrradiatedInfested = 92,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.IrradiatedIrradiated))]
    IrradiatedIrradiated = 93,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.IrradiatedIsotopic))]
    IrradiatedIsotopic = 94,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.IrradiatedMutated))]
    IrradiatedMutated = 95,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.IrradiatedNuclear))]
    IrradiatedNuclear = 96,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.IrradiatedRadioactiveAbomination))]
    IrradiatedRadioactiveAbomination = 97,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.IrradiatedRadioactive))]
    IrradiatedRadioactive = 98,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.IrradiatedSupercritical))]
    IrradiatedSupercritical = 99,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushAbandonedParadise))]
    LushAbandonedParadise00,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushBountiful))]
    LushBountiful01,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushFlourishing))]
    LushFlourishing02,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushGrassy))]
    LushGrassy03,

    [Display(ResourceType = typeof(BiomeDescriptionResource), Description = nameof(BiomeDescriptionResource.LushHumid))]
    LushHumid04,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushInfectedParadise))]
    LushInfectedParadise05,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushInfestedParadise))]
    LushInfestedParadise06,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushOvergrown))]
    LushOvergrown07,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushOvergrownRelic))]
    LushOvergrownRelic08,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushParadise))]
    LushParadise09,

    [Display(ResourceType = typeof(BiomeDescriptionResource), Description = nameof(BiomeDescriptionResource.LushRainy))]
    LushRainy10,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushTemperate))]
    LushTemperate11,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushTheNest))]
    LushTheNest12,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushTheReliquary))]
    LushTheReliquary13,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushTropical))]
    LushTropical14,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushVerdant))]
    LushVerdant15,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushViridescent))]
    LushViridescent16,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushWormRidden))]
    LushWormRidden17,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushXenoColony))]
    LushXenoColony18,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshBoggy))]
    MarshBoggy19,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshCloudy))]
    MarshCloudy20,

    [Display(ResourceType = typeof(BiomeDescriptionResource), Description = nameof(BiomeDescriptionResource.MarshDamp))]
    MarshDamp21,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshEndlessMorass))]
    MarshEndlessMorass22,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshFoggy))]
    MarshFoggy23,

    [Display(ResourceType = typeof(BiomeDescriptionResource), Description = nameof(BiomeDescriptionResource.MarshHazy))]
    MarshHazy24,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshMarshy))]
    MarshMarshy25,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshMisty))]
    MarshMisty26,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshMurky))]
    MarshMurky27,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshQuagmire))]
    MarshQuagmire28,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshReeking))]
    MarshReeking29,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshSwamp))]
    MarshSwamp30,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshTropical))]
    MarshTropical31,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshVapour))]
    MarshVapour32,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticAzure))]
    MegaExoticAzure33,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticBlood))]
    MegaExoticBlood34,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticCerulean))]
    MegaExoticCerulean35,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticChromaticFog))]
    MegaExoticChromaticFog36,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticCrimson))]
    MegaExoticCrimson37,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticDeathlyGreenAnomaly))]
    MegaExoticDeathlyGreenAnomaly38,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticDoomedJade))]
    MegaExoticDoomedJade39,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticFrozenAnomaly))]
    MegaExoticFrozenAnomaly40,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticHarshBlueGlobe))]
    MegaExoticHarshBlueGlobe41,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticHauntedEmeril))]
    MegaExoticHauntedEmeril42,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticLostBlue))]
    MegaExoticLostBlue43,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticLostGreen))]
    MegaExoticLostGreen44,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticLostRed))]
    MegaExoticLostRed45,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticPlanetaryAnomaly))]
    MegaExoticPlanetaryAnomaly46,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticRedacted))]
    MegaExoticRedacted47,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticScarlet))]
    MegaExoticScarlet48,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticStellarCorruptionDetected))]
    MegaExoticStellarCorruptionDetected49,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticToxicAnomaly))]
    MegaExoticToxicAnomaly50,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticUltramarine))]
    MegaExoticUltramarine51,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticVermillionGlobe))]
    MegaExoticVermillionGlobe52,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticVileAnomaly))]
    MegaExoticVileAnomaly53,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticWineDark))]
    MegaExoticWineDark54,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedArid))]
    ScorchedArid55,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedBoiling))]
    ScorchedBoiling56,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedBoilingDoom))]
    ScorchedBoilingDoom57,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedCharred))]
    ScorchedCharred58,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedCorrupted))]
    ScorchedCorrupted59,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedFiery))]
    ScorchedFiery60,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedFieryDreadworld))]
    ScorchedFieryDreadworld61,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedHighTemperature))]
    ScorchedHighTemperature62,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedHot))]
    ScorchedHot63,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedIncandescent))]
    ScorchedIncandescent64,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedInfested))]
    ScorchedInfested65,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedScalding))]
    ScorchedScalding66,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedScorched))]
    ScorchedScorched67,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedScorchedRelic))]
    ScorchedScorchedRelic68,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedTorrid))]
    ScorchedTorrid69,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicAcidic))]
    ToxicAcidic70,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicAcrid))]
    ToxicAcrid71,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicBlighted))]
    ToxicBlighted72,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicCaustic))]
    ToxicCaustic73,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicCausticNightmare))]
    ToxicCausticNightmare74,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicCorrosive))]
    ToxicCorrosive75,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicDecayingRuin))]
    ToxicDecayingRuin76,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicInfested))]
    ToxicInfested77,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicMiasmatic))]
    ToxicMiasmatic78,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicNoxious))]
    ToxicNoxious79,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicPoisonous))]
    ToxicPoisonous80,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicRotting))]
    ToxicRotting81,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicToxic))]
    ToxicToxic82,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicToxicHorror))]
    ToxicToxicHorror83,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicAshShrouded))]
    VolcanicAshShrouded84,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicAshen))]
    VolcanicAshen85,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicBasalt))]
    VolcanicBasalt86,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicErupting))]
    VolcanicErupting87,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicFlameRuptured))]
    VolcanicFlameRuptured88,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicImminentCoreDetonation))]
    VolcanicImminentCoreDetonation89,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicLava))]
    VolcanicLava90,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicMagma))]
    VolcanicMagma91,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicMolten))]
    VolcanicMolten92,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicObsidianBead))]
    VolcanicObsidianBead93,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicTectonic))]
    VolcanicTectonic94,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicUnstable))]
    VolcanicUnstable95,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicViolent))]
    VolcanicViolent96,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicVolcanic))]
    VolcanicVolcanic97,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.WaterworldAquatic))]
    WaterworldAquatic98,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.WaterworldMarine))]
    WaterworldMarine99,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.WaterworldUltramarineGiant))]
    WaterworldUltramarineGiant = 200,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.WaterworldWaterlocked))]
    WaterworldWaterlocked = 201,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.WaterworldWaterworld))]
    WaterworldWaterworld = 202,
}