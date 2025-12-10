using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum FaunaGenusSubtypes
{
    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.AnastomusMantis))]
    AnastomusMantis,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnastomusInsectoid))]
    AnastomusInsectoid,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnastomusInsectoidEyeless))]
    AnastomusInsectoidEyeless,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnastomusShovelMouth))]
    AnastomusShovelMouth,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.AnastomusDorito))]
    AnastomusDorito,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnastomusMushroomBack))]
    AnastomusMushroomBack,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnastomusNoodles))]
    AnastomusNoodles,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnastomusScimitar))]
    AnastomusScimitar,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.AnastomusGull))]
    AnastomusGull,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.AnastomusLocust))]
    AnastomusLocust,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnastomusTurtlehead))]
    AnastomusTurtlehead,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Anastomus12))]
    Anastomus12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.AnomalousBall))]
    AnomalousBall,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnomalousBeamLightCrawler))]
    AnomalousBeamLightCrawler,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnomalousBoneCrawler))]
    AnomalousBoneCrawler,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnomalousBloodBalloon))]
    AnomalousBloodBalloon,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnomalousContourSphere))]
    AnomalousContourSphere,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnomalousFractCube))]
    AnomalousFractCube,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnomalousHexagonJellyfloater))]
    AnomalousHexagonJellyfloater,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnomalousElectricalAir))]
    AnomalousElectricalAir,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnomalousButterflyShells))]
    AnomalousButterflyShells,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnomalousRollingShell))]
    AnomalousRollingShell,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnomalousFloatingShards))]
    AnomalousFloatingShards,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.AnomalousFloatingWireCell))]
    AnomalousFloatingWireCell,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.BosSunBeetle))]
    BosSunBeetle,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.BosLesserMushroomBeetle))]
    BosLesserMushroomBeetle,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.BosGreaterMushroomBeetle))]
    BosGreaterMushroomBeetle,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.BosFloatingSunBeetle))]
    BosFloatingSunBeetle,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.BosFloatingLesserMushroomBeetle))]
    BosFloatingLesserMushroomBeetle,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.BosFloatingGreaterMushroomBeetle))]
    BosFloatingGreaterMushroomBeetle,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.BosSpiderCrab))]
    BosSpiderCrab,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.BosFloatingSpiderCrab))]
    BosFloatingSpiderCrab,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.BosSpiderCrabMantis))]
    BosSpiderCrabMantis,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.BosFloatingSpiderCrabMantis))]
    BosFloatingSpiderCrabMantis,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bos11))]
    Bos11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bos12))]
    Bos12,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.BosopteraBeakHead))]
    BosopteraBeakHead,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.BosopteraHerculesHead))]
    BosopteraHerculesHead,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosoptera3))]
    Bosoptera3,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosoptera4))]
    Bosoptera4,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosoptera5))]
    Bosoptera5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosoptera6))]
    Bosoptera6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosoptera7))]
    Bosoptera7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosoptera8))]
    Bosoptera8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosoptera9))]
    Bosoptera9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosoptera10))]
    Bosoptera10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosoptera11))]
    Bosoptera11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosoptera12))]
    Bosoptera12,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ConokinisSunBeetle))]
    ConokinisSunBeetle,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ConokinisLesserMushroomBeetle))]
    ConokinisLesserMushroomBeetle,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ConokinisGreaterMushroomBeetle))]
    ConokinisGreaterMushroomBeetle,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ConokinisSpiderCrab))]
    ConokinisSpiderCrab,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ConokinisSpiderCrabMantis))]
    ConokinisSpiderCrabMantis,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Conokinis6))]
    Conokinis6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Conokinis7))]
    Conokinis7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Conokinis8))]
    Conokinis8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Conokinis9))]
    Conokinis9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Conokinis10))]
    Conokinis10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Conokinis11))]
    Conokinis11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Conokinis12))]
    Conokinis12,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.FelidaeQuadruped))]
    FelidaeQuadruped,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.FelidaeBipedal))]
    FelidaeBipedal,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.FelidaeUnicorn))]
    FelidaeUnicorn,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.FelidaeWinged))]
    FelidaeWinged,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.FelidaeCanine))]
    FelidaeCanine,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.FelidaeFeline))]
    FelidaeFeline,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.FelidaeReptilian))]
    FelidaeReptilian,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.FelidaeBoar))]
    FelidaeBoar,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.FelidaeXenobeast))]
    FelidaeXenobeast,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Felidae10))]
    Felidae10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Felidae11))]
    Felidae11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Felidae12))]
    Felidae12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.FelihexFelihex))]
    FelihexFelihex,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.HexungulatisHexungulatis))]
    HexungulatisHexungulatis,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.LokColony))]
    LokColony,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.LokPlant))]
    LokPlant,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.LokSquid))]
    LokSquid,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.LokBlobby))]
    LokBlobby,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.LokWormLike))]
    LokWormLike,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.LokLargeBlob))]
    LokLargeBlob,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.LokLargeBlobTendrilled))]
    LokLargeBlobTendrilled,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.LokLesserMeadowCrab))]
    LokLesserMeadowCrab,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Lok9))]
    Lok9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Lok10))]
    Lok10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Lok11))]
    Lok11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Lok12))]
    Lok12,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.MechanocerisBipedRobot))]
    MechanocerisBipedRobot,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.MechanocerisQuadrupedalRobot))]
    MechanocerisQuadrupedalRobot,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.MechanocerisBipedRobotMagnet))]
    MechanocerisBipedRobotMagnet,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.MechanocerisQuadrapedalRobotMagnet))]
    MechanocerisQuadrapedalRobotMagnet,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Mechanoceris5))]
    Mechanoceris5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Mechanoceris6))]
    Mechanoceris6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Mechanoceris7))]
    Mechanoceris7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Mechanoceris8))]
    Mechanoceris8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Mechanoceris9))]
    Mechanoceris9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Mechanoceris10))]
    Mechanoceris10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Mechanoceris11))]
    Mechanoceris11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Mechanoceris12))]
    Mechanoceris12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.MogaraTeddyBear))]
    MogaraTeddyBear,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.MogaraGekLike))]
    MogaraGekLike,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.MogaraFlyingWingedMogara))]
    MogaraFlyingWingedMogara,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.MogaraMaskedMogara))]
    MogaraMaskedMogara,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.MogaraTeddyAntlers))]
    MogaraTeddyAntlers,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.MogaraGekAntlers))]
    MogaraGekAntlers,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Mogara7))]
    Mogara7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Mogara8))]
    Mogara8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Mogara9))]
    Mogara9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Mogara10))]
    Mogara10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Mogara11))]
    Mogara11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Mogara12))]
    Mogara12,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.OsteofelidaeSpherical))]
    OsteofelidaeSpherical,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.OsteofelidaeCrystal))]
    OsteofelidaeCrystal,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.OsteofelidaeMushroom))]
    OsteofelidaeMushroom,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Osteofelidae4))]
    Osteofelidae4,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Osteofelidae5))]
    Osteofelidae5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Osteofelidae6))]
    Osteofelidae6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Osteofelidae7))]
    Osteofelidae7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Osteofelidae8))]
    Osteofelidae8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Osteofelidae9))]
    Osteofelidae9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Osteofelidae10))]
    Osteofelidae10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Osteofelidae11))]
    Osteofelidae11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Osteofelidae12))]
    Osteofelidae12,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.PrionterraeRollerSpade))]
    PrionterraeRollerSpade,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.PrionterraeTendrilDigger))]
    PrionterraeTendrilDigger,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.PrionterraeAnglerDigger))]
    PrionterraeAnglerDigger,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.PrionterraeBuzzsawSnail))]
    PrionterraeBuzzsawSnail,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.PrionterraeBladeSwarm))]
    PrionterraeBladeSwarm,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.PrionterraeBoneSnake))]
    PrionterraeBoneSnake,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.PrionterraeSled))]
    PrionterraeSled,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.PrionterraeSquid))]
    PrionterraeSquid,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.PrionterraeCaterpillar))]
    PrionterraeCaterpillar,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionterrae10))]
    Prionterrae10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionterrae11))]
    Prionterrae11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionterrae12))]
    Prionterrae12,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProcavyaReptilianTurtleShell))]
    ProcavyaReptilianTurtleShell,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProcavyaReptilian))]
    ProcavyaReptilian,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.ProcavyaBadger))]
    ProcavyaBadger,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.ProcavyaCanine))]
    ProcavyaCanine,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.ProcavyaMole))]
    ProcavyaMole,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.ProcavyaRat))]
    ProcavyaRat,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProcavyaBirdhead))]
    ProcavyaBirdhead,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProcavyaTurtlehead))]
    ProcavyaTurtlehead,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProcavyaFrilledKoala))]
    ProcavyaFrilledKoala,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProcavyaAnteater))]
    ProcavyaAnteater,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProcavyaTurtleheadShell))]
    ProcavyaTurtleheadShell,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Procavya12))]
    Procavya12,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtocaeliFloatingMushroom))]
    ProtocaeliFloatingMushroom,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtocaeliFloatingOrchid))]
    ProtocaeliFloatingOrchid,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtocaeliBoneflyer))]
    ProtocaeliBoneflyer,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtocaeliGhostflyer))]
    ProtocaeliGhostflyer,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtocaeliSnailflyer))]
    ProtocaeliSnailflyer,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtocaeliGuppieflyer))]
    ProtocaeliGuppieflyer,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtocaeliPlainFlyer))]
    ProtocaeliPlainFlyer,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtocaeliElephloat))]
    ProtocaeliElephloat,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtocaeliBubbles))]
    ProtocaeliBubbles,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtocaeliPuffleflyer))]
    ProtocaeliPuffleflyer,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Protocaeli11))]
    Protocaeli11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Protocaeli12))]
    Protocaeli12,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtosphaeridaeArmadillon))]
    ProtosphaeridaeArmadillon,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtosphaeridaeBoneHoop))]
    ProtosphaeridaeBoneHoop,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtosphaeridaeCatsEyeSwarm))]
    ProtosphaeridaeCatsEyeSwarm,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtosphaeridaeEyeballBubble))]
    ProtosphaeridaeEyeballBubble,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtosphaeridaeJellifiedBall))]
    ProtosphaeridaeJellifiedBall,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtosphaeridaePuffball))]
    ProtosphaeridaePuffball,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtosphaeridaeRainbowSphere))]
    ProtosphaeridaeRainbowSphere,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtosphaeridaeSnakeBall))]
    ProtosphaeridaeSnakeBall,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtosphaeridaeTendrilCluster))]
    ProtosphaeridaeTendrilCluster,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtosphaeridaeJellifiedTendrilBall))]
    ProtosphaeridaeJellifiedTendrilBall,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtosphaeridaeFutball))]
    ProtosphaeridaeFutball,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ProtosphaeridaeKugelpanzer))]
    ProtosphaeridaeKugelpanzer,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.PrototerraeTentacleCluster))]
    PrototerraeTentacleCluster,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.PrototerraeEyestalkCluster))]
    PrototerraeEyestalkCluster,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.PrototerraeGeothermalVents))]
    PrototerraeGeothermalVents,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.PrototerraeScrat))]
    PrototerraeScrat,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.PrototerraeSporestalk))]
    PrototerraeSporestalk,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prototerrae6))]
    Prototerrae6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prototerrae7))]
    Prototerrae7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prototerrae8))]
    Prototerrae8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prototerrae9))]
    Prototerrae9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prototerrae10))]
    Prototerrae10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prototerrae11))]
    Prototerrae11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prototerrae12))]
    Prototerrae12,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.RangifaeHeadFrillDragon))]
    RangifaeHeadFrillDragon,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.RangifaeFlathead))]
    RangifaeFlathead,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.RangifaeTrojan))]
    RangifaeTrojan,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.RangifaeCobra))]
    RangifaeCobra,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.RangifaeSpyro))]
    RangifaeSpyro,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.RangifaeSpadeFrillGiraffe))]
    RangifaeSpadeFrillGiraffe,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.RangifaeHammerhead))]
    RangifaeHammerhead,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.RangifaeBeak))]
    RangifaeBeak,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.RangifaeDragon))]
    RangifaeDragon,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.RangifaeHaloSword))]
    RangifaeHaloSword,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.RangifaeHorns))]
    RangifaeHorns,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.RangifaeGiraffe))]
    RangifaeGiraffe,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ReococcyxAntlers))]
    ReococcyxAntlers,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.ReococcyxHorns))]
    ReococcyxHorns,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.ReococcyxPlain))]
    ReococcyxPlain,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ReococcyxHornedWinged))]
    ReococcyxHornedWinged,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ReococcyxAntlerWinged))]
    ReococcyxAntlerWinged,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.ReococcyxSpined))]
    ReococcyxSpined,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ReococcyxAntlerSpined))]
    ReococcyxAntlerSpined,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.ReococcyxHornedSpined))]
    ReococcyxHornedSpined,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Reococcyx9))]
    Reococcyx9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Reococcyx10))]
    Reococcyx10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Reococcyx11))]
    Reococcyx11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Reococcyx12))]
    Reococcyx12,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.SpiralisGlowdrill))]
    SpiralisGlowdrill,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.SpiralisCordrill))]
    SpiralisCordrill,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.SpiralisPlantdrill))]
    SpiralisPlantdrill,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.SpiralisBonedrill))]
    SpiralisBonedrill,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.SpiralisSpiradrill))]
    SpiralisSpiradrill,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Spiralis6))]
    Spiralis6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Spiralis7))]
    Spiralis7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Spiralis8))]
    Spiralis8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Spiralis9))]
    Spiralis9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Spiralis10))]
    Spiralis10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Spiralis11))]
    Spiralis11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Spiralis12))]
    Spiralis12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.TalpidaeSpikey))]
    TalpidaeSpikey,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.TalpidaeTurtle))]
    TalpidaeTurtle,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.TalpidaeSquid))]
    TalpidaeSquid,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Talpidae4))]
    Talpidae4,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Talpidae5))]
    Talpidae5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Talpidae6))]
    Talpidae6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Talpidae7))]
    Talpidae7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Talpidae8))]
    Talpidae8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Talpidae9))]
    Talpidae9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Talpidae10))]
    Talpidae10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Talpidae11))]
    Talpidae11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Talpidae12))]
    Talpidae12,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TetracerisDoghead))]
    TetracerisDoghead,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TetracerisFrilledDoghead))]
    TetracerisFrilledDoghead,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.TetracerisSnoot))]
    TetracerisSnoot,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TetracerisBedlington))]
    TetracerisBedlington,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.TetracerisRoo))]
    TetracerisRoo,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TetracerisAnteater))]
    TetracerisAnteater,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TetracerisWormhead))]
    TetracerisWormhead,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TetracerisShortflyHead))]
    TetracerisShortflyHead,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TetracerisLongflyHead))]
    TetracerisLongflyHead,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TetracerisSlughead))]
    TetracerisSlughead,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TetracerisFloralHead))]
    TetracerisFloralHead,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Tetraceris12))]
    Tetraceris12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.TheromaHippo))]
    TheromaHippo,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.TheromaRhino))]
    TheromaRhino,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TheromaTriceratops))]
    TheromaTriceratops,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.TheromaReptoma))]
    TheromaReptoma,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.TheromaExotic))]
    TheromaExotic,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Theroma6))]
    Theroma6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Theroma7))]
    Theroma7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Theroma8))]
    Theroma8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Theroma9))]
    Theroma9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Theroma10))]
    Theroma10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Theroma11))]
    Theroma11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Theroma12))]
    Theroma12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.TyranocaeTrex))]
    TyranocaeTrex,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TyranocaeXenoRex))]
    TyranocaeXenoRex,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.TyranocaeDodo))]
    TyranocaeDodo,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TyranocaeGreaterMushroomBack))]
    TyranocaeGreaterMushroomBack,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TyranocaeLesserMushroomBack))]
    TyranocaeLesserMushroomBack,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TyranocaeNoodles))]
    TyranocaeNoodles,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.TyranocaeUnicorn))]
    TyranocaeUnicorn,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.TyranocaeMousy))]
    TyranocaeMousy,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.TyranocaeDemon))]
    TyranocaeDemon,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Tyranocae10))]
    Tyranocae10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Tyranocae11))]
    Tyranocae11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Tyranocae12))]
    Tyranocae12,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.UngulatisHovering))]
    UngulatisHovering,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.UngulatisBipedal))]
    UngulatisBipedal,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ungulatis3))]
    Ungulatis3,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ungulatis4))]
    Ungulatis4,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ungulatis5))]
    Ungulatis5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ungulatis6))]
    Ungulatis6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ungulatis7))]
    Ungulatis7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ungulatis8))]
    Ungulatis8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ungulatis9))]
    Ungulatis9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ungulatis10))]
    Ungulatis10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ungulatis11))]
    Ungulatis11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ungulatis12))]
    Ungulatis12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosaquatica1))]
    Bosaquatica1,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosaquatica2))]
    Bosaquatica2,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosaquatica4))]
    Bosaquatica4,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosaquatica5))]
    Bosaquatica5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosaquatica6))]
    Bosaquatica6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosaquatica7))]
    Bosaquatica7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosaquatica8))]
    Bosaquatica8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosaquatica9))]
    Bosaquatica9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosaquatica10))]
    Bosaquatica10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosaquatica11))]
    Bosaquatica11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Bosaquatica12))]
    Bosaquatica12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Chrysaora1))]
    Chrysaora1,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Chrysaora2))]
    Chrysaora2,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Chrysaora3))]
    Chrysaora3,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Chrysaora4))]
    Chrysaora4,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Chrysaora5))]
    Chrysaora5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Chrysaora6))]
    Chrysaora6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Chrysaora7))]
    Chrysaora7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Chrysaora8))]
    Chrysaora8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Chrysaora9))]
    Chrysaora9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Chrysaora10))]
    Chrysaora10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Chrysaora11))]
    Chrysaora11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Chrysaora12))]
    Chrysaora12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ictaloris1))]
    Ictaloris1,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ictaloris2))]
    Ictaloris2,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ictaloris3))]
    Ictaloris3,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ictaloris4))]
    Ictaloris4,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ictaloris5))]
    Ictaloris5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ictaloris6))]
    Ictaloris6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ictaloris7))]
    Ictaloris7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ictaloris8))]
    Ictaloris8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ictaloris9))]
    Ictaloris9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ictaloris10))]
    Ictaloris10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ictaloris11))]
    Ictaloris11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Ictaloris12))]
    Ictaloris12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionace1))]
    Prionace1,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionace2))]
    Prionace2,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionace3))]
    Prionace3,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionace4))]
    Prionace4,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionace5))]
    Prionace5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionace6))]
    Prionace6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionace7))]
    Prionace7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionace8))]
    Prionace8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionace9))]
    Prionace9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionace10))]
    Prionace10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionace11))]
    Prionace11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionace12))]
    Prionace12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionacefda1))]
    Prionacefda1,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionacefda2))]
    Prionacefda2,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionacefda3))]
    Prionacefda3,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionacefda4))]
    Prionacefda4,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionacefda5))]
    Prionacefda5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionacefda6))]
    Prionacefda6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionacefda7))]
    Prionacefda7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionacefda8))]
    Prionacefda8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionacefda9))]
    Prionacefda9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionacefda10))]
    Prionacefda10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionacefda11))]
    Prionacefda11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Prionacefda12))]
    Prionacefda12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Procavaquatica1))]
    Procavaquatica1,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Procavaquatica2))]
    Procavaquatica2,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Procavaquatica3))]
    Procavaquatica3,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Procavaquatica4))]
    Procavaquatica4,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Procavaquatica5))]
    Procavaquatica5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Procavaquatica6))]
    Procavaquatica6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Procavaquatica7))]
    Procavaquatica7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Procavaquatica8))]
    Procavaquatica8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Procavaquatica9))]
    Procavaquatica9,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.Procavaquatica10))]
    Procavaquatica10,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.Procavaquatica11))]
    Procavaquatica11,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.Procavaquatica12))]
    Procavaquatica12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Agnelis1))]
    Agnelis1,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Agnelis2))]
    Agnelis2,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Agnelis3))]
    Agnelis3,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Agnelis4))]
    Agnelis4,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Agnelis5))]
    Agnelis5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Agnelis6))]
    Agnelis6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Agnelis7))]
    Agnelis7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Agnelis8))]
    Agnelis8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Agnelis9))]
    Agnelis9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Agnelis10))]
    Agnelis10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Agnelis11))]
    Agnelis11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Agnelis12))]
    Agnelis12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Cycromys1))]
    Cycromys1,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Cycromys2))]
    Cycromys2,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Cycromys3))]
    Cycromys3,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Cycromys4))]
    Cycromys4,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Cycromys5))]
    Cycromys5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Cycromys6))]
    Cycromys6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Cycromys7))]
    Cycromys7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Cycromys8))]
    Cycromys8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Cycromys9))]
    Cycromys9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Cycromys10))]
    Cycromys10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Cycromys11))]
    Cycromys11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Cycromys12))]
    Cycromys12,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Oxyacta1))]
    Oxyacta1,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Oxyacta2))]
    Oxyacta2,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Oxyacta3))]
    Oxyacta3,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Oxyacta4))]
    Oxyacta4,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Oxyacta5))]
    Oxyacta5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Oxyacta6))]
    Oxyacta6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Oxyacta7))]
    Oxyacta7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Oxyacta8))]
    Oxyacta8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Oxyacta9))]
    Oxyacta9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Oxyacta10))]
    Oxyacta10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Oxyacta11))]
    Oxyacta11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Oxyacta12))]
    Oxyacta12,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.RhopaloceraPygmyButterflies))]
    RhopaloceraPygmyButterflies,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.RhopaloceraAnomalousButterflies))]
    RhopaloceraAnomalousButterflies,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.RhopaloceraSporeflies))]
    RhopaloceraSporeflies,

    [Display(
        ResourceType = typeof(FaunaTaxonomyResource),
        Description = nameof(FaunaTaxonomyResource.RhopaloceraLargeButterflies))]
    RhopaloceraLargeButterflies,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Rhopalocera5))]
    Rhopalocera5,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Rhopalocera6))]
    Rhopalocera6,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Rhopalocera7))]
    Rhopalocera7,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Rhopalocera8))]
    Rhopalocera8,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Rhopalocera9))]
    Rhopalocera9,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Rhopalocera10))]
    Rhopalocera10,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Rhopalocera11))]
    Rhopalocera11,

    [Display(ResourceType = typeof(FaunaTaxonomyResource), Description = nameof(FaunaTaxonomyResource.Rhopalocera12))]
    Rhopalocera12,
}