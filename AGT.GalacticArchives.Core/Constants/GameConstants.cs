using AGT.GalacticArchives.Core.Models.Enums;

namespace AGT.GalacticArchives.Core.Constants;

public static class GameConstants
{
    public const int XZAxisOffset = 2049;
    public const int YAxisOffset = 129;

    public static Dictionary<FaunaGenusSubtypes, string> GetFaunaSubGenusDescriptions()
    {
        return new Dictionary<FaunaGenusSubtypes, string>
        {
            {
                FaunaGenusSubtypes.AnastomusMantis,
                "The bipedal strider creature is mantis-like with claws on short arms."
            },
            {
                FaunaGenusSubtypes.AnastomusInsectoid,
                "A bipedal strider creature which may feature large eyes and a exoskeleton/chitin-like outer appearance."
            },
            {
                FaunaGenusSubtypes.AnastomusInsectoidEyeless,
                "A bipedal strider creature which may feature no eyes and a exoskeleton/chitin-like outer appearance."
            },
            {
                FaunaGenusSubtypes.AnastomusShovelMouth,
                "A bipedal strider creature which features a large lower jaw that extends far beyond upper jaw."
            },
            {
                FaunaGenusSubtypes.AnastomusDorito,
                "A bipedal strider creature which features a bone protrusion on a part of its body that resembles a Dorito chip."
            },
            {
                FaunaGenusSubtypes.AnastomusMushroomBack,
                "A bipedal strider creature which features a bone protrusion on a part of its body that mushroom."
            },
            {
                FaunaGenusSubtypes.AnastomusNoodles,
                "A bipedal strider creature which features a noodle like appendage anatomy."
            },
            {
                FaunaGenusSubtypes.AnastomusScimitar,
                "A bipedal strider creature which features a large bone protrusion that resembles a scimitar."
            },
            { FaunaGenusSubtypes.AnastomusGull, "A bipedal strider creature which gull type wings on its torso." },
            {
                FaunaGenusSubtypes.AnastomusLocust,
                "The bipedal strider creature is mantis-like with claws on short arms and also has wings on its backside."
            },
            {
                FaunaGenusSubtypes.AnastomusTurtlehead,
                "A bipedal strider creature which features a turtle or reptilian like head and no other major subtype characteristics."
            },
            {
                FaunaGenusSubtypes.AnomalousBall,
                "A perfectly spherical ball that appears to be anomalously alive and rolls around."
            },
            {
                FaunaGenusSubtypes.AnomalousBeamLightCrawler,
                "A series of vertically pulsating living lights that move."
            },
            {
                FaunaGenusSubtypes.AnomalousBoneCrawler,
                "A series of vertically pulsating living bione rocks that move under and over across the surface ."
            },
            {
                FaunaGenusSubtypes.AnomalousBloodBalloon,
                "A singular floating balloon like creature that appears to contain liquid that may be blood."
            },
            {
                FaunaGenusSubtypes.AnomalousContourSphere,
                "A mechanical-like ball with an apparent light/eye that appears to be anomalously alive and rolls across the surface."
            },
            {
                FaunaGenusSubtypes.AnomalousFractCube,
                "A pulsating electrical floating ball which appears to have some exterior forcefield to maintain structural integrity that is anomalously alive and floats across the surface."
            },
            {
                FaunaGenusSubtypes.AnomalousHexagonJellyfloater,
                "An animated and living anomalous collection of hexagonal shaped floating jellyfish."
            },
            {
                FaunaGenusSubtypes.AnomalousElectricalAir,
                "An animated, sparkling, and living anomalous collection of electrical pulses of light."
            },
            {
                FaunaGenusSubtypes.AnomalousButterflyShells,
                "An animated, fluttering and living anomalous collection of shells that resemble a butterfly."
            },
            {
                FaunaGenusSubtypes.AnomalousRollingShell,
                "A anomalous living entity with an interior bright light and a limestone like shell with 10-12 stationary appendages that rolls across the surface."
            },
            {
                FaunaGenusSubtypes.AnomalousFloatingShards,
                "An animated, floating and living anomalous collection of pulsting shards."
            },
            { FaunaGenusSubtypes.AnomalousFloatingWireCell, "An animated, floating and living anomalous wire cell." },
            { FaunaGenusSubtypes.BosSunBeetle, "An insectoid beetle that crawls across the surface." },
            {
                FaunaGenusSubtypes.BosLesserMushroomBeetle,
                "An insectoid beetle with an apparent mushroom closely mounted on its backside, that crawls across the surface."
            },
            {
                FaunaGenusSubtypes.BosGreaterMushroomBeetle,
                "An insectoid beetle with an apparent mushroom protruding considerably from its backside, that crawls across the surface."
            },
            { FaunaGenusSubtypes.BosFloatingSunBeetle, "An insectoid beetle that floats above the surface." },
            {
                FaunaGenusSubtypes.BosFloatingLesserMushroomBeetle,
                "An insectoid beetle with an apparent mushroom protruding considerably from its backside, that floats above the surface."
            },
            {
                FaunaGenusSubtypes.BosFloatingGreaterMushroomBeetle,
                "An insectoid beetle with an apparent mushroom protruding considerably from its backside, that floats above the surface."
            },
            {
                FaunaGenusSubtypes.BosSpiderCrab,
                "A creature which resembles a spider-crab mix and crawls on the surface."
            },
            {
                FaunaGenusSubtypes.BosFloatingSpiderCrab,
                "A creature which resembles a spider-crab mix and floats above the surface."
            },
            {
                FaunaGenusSubtypes.BosSpiderCrabMantis,
                "A creature which resembles a spider-crab, features a mantis like head protruding from its body and crawls on the surface."
            },
            {
                FaunaGenusSubtypes.BosFloatingSpiderCrabMantis,
                "A creature which resembles a spider-crab, features a mantis like head protruding from its body and floats above the surface."
            },
            {
                FaunaGenusSubtypes.BosopteraBeakHead,
                "A flying winged beetle which hovers above the ground and occasionally lands on the ground to collect nutrients. It appears to have a beak like head."
            },
            {
                FaunaGenusSubtypes.BosopteraHerculesHead,
                "A flying winged beetle which hovers above the ground and occasionally lands on the ground to collect nutrients. It appears to have a head with extended upper and lower protruding elements."
            },
            { FaunaGenusSubtypes.ConokinisSunBeetle, "An insectoid beetle that crawls across the surface." },
            {
                FaunaGenusSubtypes.ConokinisLesserMushroomBeetle,
                "An insectoid beetle with an apparent mushroom closely mounted on its backside, that crawls across the surface."
            },
            {
                FaunaGenusSubtypes.ConokinisGreaterMushroomBeetle,
                "An insectoid beetle with an apparent mushroom protruding considerably from its backside, that crawls across the surface."
            },
            {
                FaunaGenusSubtypes.ConokinisSpiderCrab,
                "A creature which resembles a spider-crab mix and crawls on the surface."
            },
            {
                FaunaGenusSubtypes.ConokinisSpiderCrabMantis,
                "A creature which resembles a spider-crab, features a mantis like head protruding from its body and crawls on the surface."
            },
            { FaunaGenusSubtypes.FelidaeQuadruped, "A four limbed feline/dog creature that walks on all four legs." },
            {
                FaunaGenusSubtypes.FelidaeBipedal,
                "A four limbed feline/dog creature that walks on its hind rear legs as a bipedal."
            },
            {
                FaunaGenusSubtypes.FelidaeUnicorn,
                "A four limbed felidae creature that walks on all four legs and features horns on its snout."
            },
            {
                FaunaGenusSubtypes.FelidaeWinged,
                "A four limbed felidae creature that walks on all four legs and features wings on its torso."
            },
            {
                FaunaGenusSubtypes.FelidaeCanine,
                "A four limbed felidae creature that walks on all four legs and features a dog style head."
            },
            {
                FaunaGenusSubtypes.FelidaeFeline,
                "A four limbed felidae creature that walks on all four legs and features a cat style head."
            },
            {
                FaunaGenusSubtypes.FelidaeReptilian,
                "A four limbed felidae creature that walks on all four legs and features a reptilian style head."
            },
            {
                FaunaGenusSubtypes.FelidaeBoar,
                "A four limbed felidae creature that walks on all four legs and features a boar style head."
            },
            {
                FaunaGenusSubtypes.FelidaeXenobeast,
                "A four limbed felidae creature that walks on all four legs and features a alien style head."
            },
            {
                FaunaGenusSubtypes.FelihexFelihex,
                "A six limbed Felidae (feline/dog) like creature that walks on all six legs."
            },
            {
                FaunaGenusSubtypes.HexungulatisHexungulatis,
                "A six limbed cow like creature that walks on all six legs."
            },
            {
                FaunaGenusSubtypes.LokColony,
                "A multi-headed bouncing blob where each head may feature its own facial characteristics."
            },
            {
                FaunaGenusSubtypes.LokPlant,
                "A sentient plant like bouncing blob that may resemble a living pineapple at times."
            },
            {
                FaunaGenusSubtypes.LokSquid,
                "A sentient bouncing blob that consists of a head with a neck mounted on a legs less torso."
            },
            {
                FaunaGenusSubtypes.LokBlobby,
                "A sentient bouncing blob that features a clearly visibly facial structure."
            },
            {
                FaunaGenusSubtypes.LokWormLike,
                "A sentient bouncing blob that features multiple body mounted eyes and a vertical ingestion chute at the top."
            },
            {
                FaunaGenusSubtypes.LokLargeBlob,
                "A sentient semi half spherical bouncing blob with little visible appendages."
            },
            {
                FaunaGenusSubtypes.LokLargeBlobTendrilled,
                "A sentient semi half spherical bouncing blob with visible appendages."
            },
            {
                FaunaGenusSubtypes.LokLesserMeadowCrab,
                "A sentient bouncing blob that features a crustacean-like shell mounted on a large number of leg appendages."
            },
            { FaunaGenusSubtypes.MechanocerisBipedRobot, "A bipedal robot type creature." },
            { FaunaGenusSubtypes.MechanocerisQuadrupedalRobot, "A quadrapedal robot type creature." },
            {
                FaunaGenusSubtypes.MechanocerisBipedRobotMagnet,
                "A bipedal robot type creature which appears to have a magnet attached to its back."
            },
            {
                FaunaGenusSubtypes.MechanocerisQuadrapedalRobotMagnet,
                "A quadrapedal robot type creature which appears to have a magnet attached to its back."
            },
            {
                FaunaGenusSubtypes.MogaraTeddyBear,
                "A mogara which bears a strong resemblance to a bi-pedal walking teddy bear."
            },
            {
                FaunaGenusSubtypes.MogaraGekLike,
                "A mogara which bears a strong resemblance to a bi-pedal walking [[Gek]]."
            },
            {
                FaunaGenusSubtypes.MogaraFlyingWingedMogara,
                "A mogara which has wings and occassionally floats slightly off the ground as it moves."
            },
            {
                FaunaGenusSubtypes.MogaraMaskedMogara,
                "A mogara which appears to have a shell based mask covering its face."
            },
            {
                FaunaGenusSubtypes.MogaraTeddyAntlers,
                "A mogara with antlers which bears a strong resemblance to a bi-pedal walking teddy bear."
            },
            {
                FaunaGenusSubtypes.MogaraGekAntlers,
                "A mogara with antlers which bears a strong resemblance to a bi-pedal walking [[Gek]]."
            },
            { FaunaGenusSubtypes.OsteofelidaeSpherical, "A bonecat creature with a semi-spherical torso body." },
            {
                FaunaGenusSubtypes.OsteofelidaeCrystal,
                "A bonecat creature with crystals growing on various parts of its body."
            },
            {
                FaunaGenusSubtypes.OsteofelidaeMushroom,
                "A bonecat creature with mushrooms growing on various parts of its body."
            },
            {
                FaunaGenusSubtypes.PrionterraeRollerSpade,
                "A spherical creature with many legs that end in triangular spades that dig through the soil, allowing for faster movement."
            },
            {
                FaunaGenusSubtypes.PrionterraeTendrilDigger,
                "A creature with multiple blade-like segments that exudes glowing tendrils."
            },
            {
                FaunaGenusSubtypes.PrionterraeAnglerDigger,
                "A long digger with about many legs that dig through the soil and has a glowing angler-like protrusion on its head."
            },
            {
                FaunaGenusSubtypes.PrionterraeBuzzsawSnail,
                "A shell creature with a central churning blade and two large horns."
            },
            {
                FaunaGenusSubtypes.PrionterraeBladeSwarm,
                "A group of about a dozen blade-like organisms working in a pack to churn up and move quickly through soil."
            },
            {
                FaunaGenusSubtypes.PrionterraeBoneSnake,
                "A bony, serpentine creature with a large blade-like head that almost swims through soil"
            },
            {
                FaunaGenusSubtypes.PrionterraeSled,
                "A creature with a lower, relatively flat body that appears to skim or glide across and info surfaces, and features flowing tentacles from the rear half top of its torso."
            },
            {
                FaunaGenusSubtypes.PrionterraeSquid,
                "A generally triangular head followed by a series of organic flowing tentacles, typically 3-8."
            },
            {
                FaunaGenusSubtypes.PrionterraeCaterpillar,
                "A creature which resembles a large worm/caterpillar which moves through the soil and has no clearly discernible body segments aside from a non-descript head and tail."
            },
            {
                FaunaGenusSubtypes.ProcavyaReptilianTurtleShell, "A rodent with a reptilian head and turtle-like shell."
            },
            { FaunaGenusSubtypes.ProcavyaReptilian, "A rodent with a reptilian head." },
            { FaunaGenusSubtypes.ProcavyaBadger, "A rodent with a badger head." },
            { FaunaGenusSubtypes.ProcavyaCanine, "A rodent with a canine head." },
            { FaunaGenusSubtypes.ProcavyaMole, "A rodent with a mole head." },
            { FaunaGenusSubtypes.ProcavyaRat, "A rodent with a rat head." },
            { FaunaGenusSubtypes.ProcavyaBirdhead, "A rodent with a bird-like head." },
            { FaunaGenusSubtypes.ProcavyaTurtlehead, "A rodent with a turtle-like head." },
            { FaunaGenusSubtypes.ProcavyaFrilledKoala, "A rodent with a head that resembles a frilled koala." },
            { FaunaGenusSubtypes.ProcavyaAnteater, "A rodent with an anteater head." },
            { FaunaGenusSubtypes.ProcavyaTurtleheadShell, "A rodent with a turtle like head and shell." },
            {
                FaunaGenusSubtypes.ProtocaeliFloatingMushroom,
                "A floating mushroom-like creature with a disc shape that hovers over the surface at low heights."
            },
            {
                FaunaGenusSubtypes.ProtocaeliFloatingOrchid,
                "A floating orchid-like creature that hovers over the surface at low heights. It features several appendages that wave in air."
            },
            {
                FaunaGenusSubtypes.ProtocaeliBoneflyer,
                "A floating boney segmented creature that hovers over the surface at low heights."
            },
            {
                FaunaGenusSubtypes.ProtocaeliGhostflyer,
                "A floating ghostly aquatic-like creature that hovers over the surface at low heights."
            },
            {
                FaunaGenusSubtypes.ProtocaeliSnailflyer,
                "A floating snail-like creature that hovers over the surface at low height."
            },
            {
                FaunaGenusSubtypes.ProtocaeliGuppieflyer,
                "A floating aquatic-like guppy creature that hovers over the surface at low heights. It features several appendages that wave in air."
            },
            {
                FaunaGenusSubtypes.ProtocaeliPlainFlyer,
                "A floating aquatic-like creature that hovers over the surface at low heights."
            },
            {
                FaunaGenusSubtypes.ProtocaeliElephloat,
                "A elephant like head/snout creature that hovers over the surface at low heights"
            },
            {
                FaunaGenusSubtypes.ProtocaeliBubbles,
                "A bubble-like creature that hovers over the surface at low heights."
            },
            {
                FaunaGenusSubtypes.ProtocaeliPuffleflyer,
                "A puff-fish like creature that hovers over the surface at low heights."
            },
            {
                FaunaGenusSubtypes.ProtosphaeridaeArmadillon,
                "An armoured arthropod creature that appears like a woodlouse curled up in a shell"
            },
            { FaunaGenusSubtypes.ProtosphaeridaeBoneHoop, "A bony hoop-like shape that rolls very fast" },
            {
                FaunaGenusSubtypes.ProtosphaeridaeCatsEyeSwarm,
                "A swarm of eyes that roll together in a tight formation appearing much like the eyes of cats"
            },
            {
                FaunaGenusSubtypes.ProtosphaeridaeEyeballBubble,
                "A translucent sphere with many half-open eyeballs within it"
            },
            { FaunaGenusSubtypes.ProtosphaeridaeJellifiedBall, "A jellified mass with fleshy buboes" },
            { FaunaGenusSubtypes.ProtosphaeridaePuffball, "A perforated sphere with specially-placed breathing holes" },
            {
                FaunaGenusSubtypes.ProtosphaeridaeRainbowSphere,
                "A translucent sphere with 12 prismatic spheres within it"
            },
            {
                FaunaGenusSubtypes.ProtosphaeridaeSnakeBall,
                "An armoured reptilian creature that appears like a coiled ball of snakes"
            },
            {
                FaunaGenusSubtypes.ProtosphaeridaeTendrilCluster,
                "A creature that appears as a cluster of tendrils attached to a sphere"
            },
            {
                FaunaGenusSubtypes.ProtosphaeridaeJellifiedTendrilBall,
                "A jellified mass with fleshy buboes and tendril appendages."
            },
            { FaunaGenusSubtypes.ProtosphaeridaeFutball, "A creature that resembles a football/soccer ball." },
            { FaunaGenusSubtypes.ProtosphaeridaeKugelpanzer, "A creature with a shell like ball" },
            {
                FaunaGenusSubtypes.PrototerraeTentacleCluster,
                "A series of tentacles protruding from the surface that move wildly and may rapidly move across the surface when the creature is in an aggressive mood."
            },
            {
                FaunaGenusSubtypes.PrototerraeEyestalkCluster,
                "A series of eyestalks protruding from the surface that move wildly and may rapidly move across the surface when the creature is in an aggressive mood."
            },
            {
                FaunaGenusSubtypes.PrototerraeGeothermalVents,
                "The creature appears only as a series of sequential gas vents erupting from the ground."
            },
            {
                FaunaGenusSubtypes.PrototerraeScrat,
                "The creature appears as a small mole-like creature that constantly dips and emerges from the surface at high speeds."
            },
            {
                FaunaGenusSubtypes.PrototerraeSporestalk,
                "A series of stalks protruding from the surface that move wildly and may rapidly move across the surface when the creature is in an aggressive mood."
            },
            {
                FaunaGenusSubtypes.RangifaeHeadFrillDragon,
                "A long-necked \"Diplo\" or dinosaur-like creature with frilled fanned wings on a dragon style head."
            },
            {
                FaunaGenusSubtypes.RangifaeFlathead,
                "A long-necked \"Diplo\" or dinosaur-like creature with a large flatbone protruding on the head."
            },
            {
                FaunaGenusSubtypes.RangifaeTrojan,
                "A long-necked \"Diplo\" or dinosaur-like creature with frilled crests on its neck and/or head."
            },
            {
                FaunaGenusSubtypes.RangifaeCobra,
                "A long-necked \"Diplo\" or dinosaur-like creature with a snake-like neck and head."
            },
            { FaunaGenusSubtypes.RangifaeSpyro, "A compact curled-necked dinosaur-like creature." },
            {
                FaunaGenusSubtypes.RangifaeSpadeFrillGiraffe,
                "A long-necked \"Diplo\" or dinosaur-like creature with frilled wings or plates on the neck or upper torso, with a giraffe-like head."
            },
            {
                FaunaGenusSubtypes.RangifaeHammerhead,
                "A long-necked \"Diplo\" or dinosaur-like creature with large bones protruding horizontally from the skull in the approximate location of where ears may be expected."
            },
            {
                FaunaGenusSubtypes.RangifaeBeak,
                "A long-necked \"Diplo\" or dinosaur-like creature with a bird-like beak and head."
            },
            {
                FaunaGenusSubtypes.RangifaeDragon,
                "A long-necked \"Diplo\" or dinosaur-like creature with a dragon style head."
            },
            {
                FaunaGenusSubtypes.RangifaeHaloSword,
                "A long-necked \"Diplo\" or dinosaur-like creature with a large flat sail or halo style bone protruding over the head and extending a large distance."
            },
            {
                FaunaGenusSubtypes.RangifaeHorns,
                "A long-necked \"Diplo\" or dinosaur-like creature with a horns on its head."
            },
            {
                FaunaGenusSubtypes.RangifaeGiraffe,
                "A long-necked \"Diplo\" or dinosaur-like creature with a giraffe-like head."
            },
            {
                FaunaGenusSubtypes.ReococcyxAntlers,
                "A bipedal antelope with two distinct eyes, a mouth, and nose at the end of snout and antlers."
            },
            {
                FaunaGenusSubtypes.ReococcyxHorns,
                "A bipedal antelope with two distinct eyes, a mouth, and nose at the end of snout and horns."
            },
            {
                FaunaGenusSubtypes.ReococcyxPlain,
                "A bipedal antelope with two distinct eyes, a mouth, and nose at the end of snout."
            },
            {
                FaunaGenusSubtypes.ReococcyxHornedWinged,
                "A bipedal antelope with flappy wings, two distinct eyes, a mouth, and nose at the end of snout and horns."
            },
            {
                FaunaGenusSubtypes.ReococcyxAntlerWinged,
                "A bipedal antelope with flappy wings, two distinct eyes, a mouth, and nose at the end of snout and antlers."
            },
            {
                FaunaGenusSubtypes.ReococcyxSpined,
                "A bipedal antelope with two distinct eyes, a mouth, and nose at the end of snout and spines on its backside."
            },
            {
                FaunaGenusSubtypes.ReococcyxAntlerSpined,
                "A bipedal antelope with two distinct eyes, a mouth, and nose at the end of snout and antlers and spines on its backside."
            },
            {
                FaunaGenusSubtypes.ReococcyxHornedSpined,
                "A bipedal antelope with two distinct eyes, a mouth, and nose at the end of snout and horns and spines on its backside."
            },
            {
                FaunaGenusSubtypes.SpiralisGlowdrill,
                "A spiral shaped series of fluttering strips that can phase through terrain, and move in a spiral pattern. This creatures features several different colors in a regular glowing pattern."
            },
            {
                FaunaGenusSubtypes.SpiralisCordrill,
                "A spiral shaped series of fluttering strips that can phase through terrain, and move in a spiral pattern. The creature strips appear to resemble cord, rope or twine and maintain a constant color."
            },
            {
                FaunaGenusSubtypes.SpiralisPlantdrill,
                "A spiral shaped series of fluttering strips that can phase through terrain, and move in a spiral pattern. The creature strips appear to resemble organic plant matter, and maintain a constant color."
            },
            {
                FaunaGenusSubtypes.SpiralisBonedrill,
                "A spiral shaped series of fluttering strips that can phase through terrain, and move in a spiral pattern. The creature strips appear to resemble segmented bones and maintain a constant color."
            },
            {
                FaunaGenusSubtypes.SpiralisSpiradrill,
                "A spiral shaped series of fluttering strips that can phase through terrain, and move in a spiral pattern. This creatures features a light and dark coloration in a regular pattern."
            },
            {
                FaunaGenusSubtypes.TalpidaeSpikey,
                "This creature is often partially submerged in the ground and moves in a slow and jagged movement. It features a series of protruding spikes on its torso that wave as it moves."
            },
            {
                FaunaGenusSubtypes.TalpidaeTurtle,
                "This creature is often partially submerged in the ground and moves in a slow and jagged movement. It features a shell, head and appendages that resemble turtles."
            },
            {
                FaunaGenusSubtypes.TalpidaeSquid,
                "This creature is often partially submerged in the ground and moves in a slow and jagged movement. It features a shell, head and appendages that resemble crustaceans."
            },
            { FaunaGenusSubtypes.TetracerisDoghead, "A four legged antelope that features a dog shaped head." },
            {
                FaunaGenusSubtypes.TetracerisFrilledDoghead,
                "A four legged antelope that features a frilled dog shaped head."
            },
            { FaunaGenusSubtypes.TetracerisSnoot, "A four legged antelope that features a snoot shaped head." },
            {
                FaunaGenusSubtypes.TetracerisBedlington,
                "A four legged antelope that features a Bedlington Terrier shaped head."
            },
            { FaunaGenusSubtypes.TetracerisRoo, "A four legged antelope that features a kanagaroo shaped head." },
            {
                FaunaGenusSubtypes.TetracerisAnteater,
                "A four legged antelope that features an anteater shaped head with an elongated snout."
            },
            {
                FaunaGenusSubtypes.TetracerisWormhead,
                "A four legged antelope that features a worm with an open digestive shaped head."
            },
            {
                FaunaGenusSubtypes.TetracerisShortflyHead,
                "A four legged antelope that features a shortbodied fly type of headshape."
            },
            {
                FaunaGenusSubtypes.TetracerisLongflyHead,
                "A four legged antelope that features a long bodied fly type of headshape."
            },
            { FaunaGenusSubtypes.TetracerisSlughead, "A four legged antelope that features a slug type of headshape." },
            {
                FaunaGenusSubtypes.TetracerisFloralHead,
                "A four legged antelope that features a floral type of headshape."
            },
            {
                FaunaGenusSubtypes.TheromaHippo,
                "Flat-backed. Two distinct nostrils and hippo-like head/teeth. Some may have tusks."
            },
            { FaunaGenusSubtypes.TheromaRhino, "Flat-backed. Large 1-2 horns on the snout or jaw." },
            { FaunaGenusSubtypes.TheromaTriceratops, "Flat-backed. Three horns around the snout, jaw or head." },
            {
                FaunaGenusSubtypes.TheromaReptoma,
                "A reptilian looking Theroma. Always has an arched back. Often will have mismatching front and back limbs. The limbs typically will have hooves or very distinct finger-like appendages."
            },
            { FaunaGenusSubtypes.TheromaExotic, "A exotic head Theroma with a arched back." },
            {
                FaunaGenusSubtypes.TyranocaeTrex,
                "A bipedal Tyrannosaurus dinosaur like creature with a reptilian style head."
            },
            {
                FaunaGenusSubtypes.TyranocaeXenoRex,
                "A bipedal Tyrannosaurus dinosaur like creature with a moth-like head."
            },
            {
                FaunaGenusSubtypes.TyranocaeDodo,
                "A bipedal Tyrannosaurus dinosaur like creature with a condor-like head."
            },
            {
                FaunaGenusSubtypes.TyranocaeGreaterMushroomBack,
                "A bipedal Tyrannosaurus dinosaur like creature with a a large mushroom appendage on its backside."
            },
            {
                FaunaGenusSubtypes.TyranocaeLesserMushroomBack,
                "A bipedal Tyrannosaurus dinosaur like creature with a a small mushroom appendage on its backside."
            },
            {
                FaunaGenusSubtypes.TyranocaeNoodles,
                "A bipedal Tyrannosaurus dinosaur like creature with noodle like appendages."
            },
            {
                FaunaGenusSubtypes.TyranocaeUnicorn,
                "A bipedal Tyrannosaurus dinosaur like creature with a unicorn-like head and horn."
            },
            {
                FaunaGenusSubtypes.TyranocaeMousy,
                "A bipedal Tyrannosaurus dinosaur like creature with a mouse or mole like head."
            },
            {
                FaunaGenusSubtypes.TyranocaeDemon,
                "A bipedal Tyrannosaurus dinosaur like creature with a demon-like head and horns."
            },
            {
                FaunaGenusSubtypes.UngulatisHovering,
                "A four limbed \"cow\"-like species which features odd numbers of toes and small wings that allow low distance hovering/flying above the ground."
            },
            {
                FaunaGenusSubtypes.UngulatisBipedal,
                "A four limbed \"cow\"-like species which features odd numbers of toes which walks as a biped on the ground."
            },
            {
                FaunaGenusSubtypes.RhopaloceraPygmyButterflies,
                "Pygmy butterflies (which also includes dragonfly-like and moth-like species) will have wings divided into two sections. In other words, the animal may just have two wings like an Earth butterfly, or it may have dragonfly-like wings that move as if they were butterfly wings. These butterflies are found exclusively in groups, usually of 8+ individuals in a group."
            },
            {
                FaunaGenusSubtypes.RhopaloceraAnomalousButterflies,
                "Anomalous butterflies are very similar to pygmy butterflies in most regards, but differ in that they have a more consistent appearance and are found exclusively on [[Irri Shells]]-type Exotic planets."
            },
            {
                FaunaGenusSubtypes.RhopaloceraSporeflies,
                "Sporeflies are the smallest group of fauna in the simulation. Rather than wings, these fauna will have \"flaps\" which may slightly flap, or may just stay still as they blow in the breeze. Some have compared them to the appearance of a germ cell or jellyfish. They are almost always found in groups of 3+."
            },
            {
                FaunaGenusSubtypes.RhopaloceraLargeButterflies,
                "Large butterflies (which also includes moth-like species) will create an audible flapping noise when flying nearby, and are easily visually distinguishable from other butterfly variants. As the name implies, they are much larger than other butterflies, and similarly to the [[Bosoptera]] genus, they exhibit the behavior of landing on the ground occasionally, flying away if a traveler approaches too close."
            },
        };
    }
}