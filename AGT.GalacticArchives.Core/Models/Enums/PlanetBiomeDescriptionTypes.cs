using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum PlanetBiomeDescriptionTypes
{
    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenAbandoned))]
    BarrenAbandoned = 0,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenBarren))]
    BarrenBarren = 1,

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
    BarrenRuinedDustbowl = 10,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenTainted))]
    BarrenTainted = 11,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenTerrorsphere))]
    BarrenTerrorsphere = 12,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.BarrenWindswept))]
    BarrenWindswept = 13,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.DeadAbandoned))]
    DeadAbandoned = 14,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.DeadAirless))]
    DeadAirless = 15,

    [Display(ResourceType = typeof(BiomeDescriptionResource), Description = nameof(BiomeDescriptionResource.DeadDead))]
    DeadDead = 16,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.DeadDesolate))]
    DeadDesolate = 17,

    [Display(ResourceType = typeof(BiomeDescriptionResource), Description = nameof(BiomeDescriptionResource.DeadEmpty))]
    DeadEmpty = 18,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.DeadForsaken))]
    DeadForsaken = 19,

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
    LushAbandonedParadise = 100,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushBountiful))]
    LushBountiful = 101,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushFlourishing))]
    LushFlourishing = 102,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushGrassy))]
    LushGrassy = 103,

    [Display(ResourceType = typeof(BiomeDescriptionResource), Description = nameof(BiomeDescriptionResource.LushHumid))]
    LushHumid = 104,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushInfectedParadise))]
    LushInfectedParadise = 105,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushInfestedParadise))]
    LushInfestedParadise = 106,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushOvergrown))]
    LushOvergrown = 107,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushOvergrownRelic))]
    LushOvergrownRelic = 108,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushParadise))]
    LushParadise = 109,

    [Display(ResourceType = typeof(BiomeDescriptionResource), Description = nameof(BiomeDescriptionResource.LushRainy))]
    LushRainy = 110,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushTemperate))]
    LushTemperate = 111,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushTheNest))]
    LushTheNest = 112,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushTheReliquary))]
    LushTheReliquary = 113,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushTropical))]
    LushTropical = 114,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushVerdant))]
    LushVerdant = 115,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushViridescent))]
    LushViridescent = 116,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushWormRidden))]
    LushWormRidden = 117,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.LushXenoColony))]
    LushXenoColony = 118,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshBoggy))]
    MarshBoggy = 119,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshCloudy))]
    MarshCloudy = 120,

    [Display(ResourceType = typeof(BiomeDescriptionResource), Description = nameof(BiomeDescriptionResource.MarshDamp))]
    MarshDamp = 121,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshEndlessMorass))]
    MarshEndlessMorass = 122,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshFoggy))]
    MarshFoggy = 123,

    [Display(ResourceType = typeof(BiomeDescriptionResource), Description = nameof(BiomeDescriptionResource.MarshHazy))]
    MarshHazy = 124,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshMarshy))]
    MarshMarshy = 125,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshMisty))]
    MarshMisty = 126,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshMurky))]
    MarshMurky = 127,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshQuagmire))]
    MarshQuagmire = 128,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshReeking))]
    MarshReeking = 129,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshSwamp))]
    MarshSwamp = 130,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshTropical))]
    MarshTropical = 131,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MarshVapour))]
    MarshVapour = 132,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticAzure))]
    MegaExoticAzure = 133,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticBlood))]
    MegaExoticBlood = 134,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticCerulean))]
    MegaExoticCerulean = 135,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticChromaticFog))]
    MegaExoticChromaticFog = 136,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticCrimson))]
    MegaExoticCrimson = 137,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticDeathlyGreenAnomaly))]
    MegaExoticDeathlyGreenAnomaly = 138,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticDoomedJade))]
    MegaExoticDoomedJade = 139,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticFrozenAnomaly))]
    MegaExoticFrozenAnomaly = 140,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticHarshBlueGlobe))]
    MegaExoticHarshBlueGlobe = 141,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticHauntedEmeril))]
    MegaExoticHauntedEmeril = 142,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticLostBlue))]
    MegaExoticLostBlue = 143,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticLostGreen))]
    MegaExoticLostGreen = 144,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticLostRed))]
    MegaExoticLostRed = 145,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticPlanetaryAnomaly))]
    MegaExoticPlanetaryAnomaly = 146,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticRedacted))]
    MegaExoticRedacted = 147,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticScarlet))]
    MegaExoticScarlet = 148,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticStellarCorruptionDetected))]
    MegaExoticStellarCorruptionDetected = 149,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticToxicAnomaly))]
    MegaExoticToxicAnomaly = 150,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticUltramarine))]
    MegaExoticUltramarine = 151,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticVermillionGlobe))]
    MegaExoticVermillionGlobe = 152,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticVileAnomaly))]
    MegaExoticVileAnomaly = 153,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.MegaExoticWineDark))]
    MegaExoticWineDark = 154,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedArid))]
    ScorchedArid = 155,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedBoiling))]
    ScorchedBoiling = 156,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedBoilingDoom))]
    ScorchedBoilingDoom = 157,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedCharred))]
    ScorchedCharred = 158,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedCorrupted))]
    ScorchedCorrupted = 159,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedFiery))]
    ScorchedFiery = 160,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedFieryDreadworld))]
    ScorchedFieryDreadworld = 161,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedHighTemperature))]
    ScorchedHighTemperature = 162,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedHot))]
    ScorchedHot = 163,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedIncandescent))]
    ScorchedIncandescent = 164,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedInfested))]
    ScorchedInfested = 165,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedScalding))]
    ScorchedScalding = 166,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedScorched))]
    ScorchedScorched = 167,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedScorchedRelic))]
    ScorchedScorchedRelic = 168,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ScorchedTorrid))]
    ScorchedTorrid = 169,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicAcidic))]
    ToxicAcidic = 170,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicAcrid))]
    ToxicAcrid = 171,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicBlighted))]
    ToxicBlighted = 172,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicCaustic))]
    ToxicCaustic = 173,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicCausticNightmare))]
    ToxicCausticNightmare = 174,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicCorrosive))]
    ToxicCorrosive = 175,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicDecayingRuin))]
    ToxicDecayingRuin = 176,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicInfested))]
    ToxicInfested = 177,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicMiasmatic))]
    ToxicMiasmatic = 178,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicNoxious))]
    ToxicNoxious = 179,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicPoisonous))]
    ToxicPoisonous = 180,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicRotting))]
    ToxicRotting = 181,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicToxic))]
    ToxicToxic = 182,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.ToxicToxicHorror))]
    ToxicToxicHorror = 183,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicAshShrouded))]
    VolcanicAshShrouded = 184,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicAshen))]
    VolcanicAshen = 185,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicBasalt))]
    VolcanicBasalt = 186,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicErupting))]
    VolcanicErupting = 187,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicFlameRuptured))]
    VolcanicFlameRuptured = 188,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicImminentCoreDetonation))]
    VolcanicImminentCoreDetonation = 189,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicLava))]
    VolcanicLava = 190,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicMagma))]
    VolcanicMagma = 191,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicMolten))]
    VolcanicMolten = 192,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicObsidianBead))]
    VolcanicObsidianBead = 193,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicTectonic))]
    VolcanicTectonic = 194,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicUnstable))]
    VolcanicUnstable = 195,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicViolent))]
    VolcanicViolent = 196,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.VolcanicVolcanic))]
    VolcanicVolcanic = 197,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.WaterworldAquatic))]
    WaterworldAquatic = 198,

    [Display(
        ResourceType = typeof(BiomeDescriptionResource),
        Description = nameof(BiomeDescriptionResource.WaterworldMarine))]
    WaterworldMarine = 199,

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