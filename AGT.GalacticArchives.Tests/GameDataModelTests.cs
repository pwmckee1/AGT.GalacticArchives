using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Tests.AutoFixture;
using AutoFixture;
using Should;

namespace AGT.GalacticArchives.Tests;

public class GameDataModelTests
{
    public class WhenConvertingToDictionaryFromGameData : GameDataModelTests
    {
        public class WhenGalaxyToDictionaryIsCalled : WhenConvertingToDictionaryFromGameData
        {
            private Galaxy _galaxy = null!;

            [SetUp]
            public void Setup()
            {
                _galaxy = new Fixture()
                    .For<Galaxy>()
                    .With(g => g.Name, "Euclid")
                    .With(g => g.Regions, [])
                    .Create();
            }

            [Test]
            public void ThenGalaxyDictionaryIsPopulated()
            {
                var dictionary = _galaxy.ToDictionary();
                dictionary[nameof(Galaxy.Name)].ShouldEqual(_galaxy.Name);
                dictionary[nameof(Galaxy.GalaxyId)].ShouldEqual(_galaxy.GalaxyId.ToString());
                dictionary[nameof(Galaxy.Sequence)].ShouldEqual(_galaxy.Sequence);
                dictionary[nameof(Galaxy.NormalizedName)].ShouldEqual(_galaxy.NormalizedName);
            }
        }

        public class WhenRegionToDictionaryIsCalled : WhenConvertingToDictionaryFromGameData
        {
            private Region _region = null!;

            [SetUp]
            public void Setup()
            {
                _region = new Fixture()
                    .For<Region>()
                    .With(p => p.Name, "Region Name")
                    .With(r => r.Galaxy, null)
                    .With(r => r.Coordinates, "0000:0000:0000:0000")
                    .With(r => r.StarSystems, [])
                    .Create();
            }

            [Test]
            public void ThenRegionDictionaryIsPopulated()
            {
                var dictionary = _region.ToDictionary();
                dictionary[nameof(Region.Name)].ShouldEqual(_region.Name);
                dictionary[nameof(Region.RegionId)].ShouldEqual(_region.RegionId.ToString());
                dictionary[nameof(Region.NormalizedName)].ShouldEqual(_region.NormalizedName);
                dictionary[nameof(Region.GalaxyId)].ShouldEqual(_region.GalaxyId.ToString());
                dictionary[nameof(Region.XX)].ShouldEqual(_region.XX);
                dictionary[nameof(Region.DocSequence)].ShouldEqual(_region.DocSequence);
                dictionary[nameof(Region.RegionAge)].ShouldEqual(_region.RegionAge);
            }
        }

        public class WhenStarSystemToDictionaryIsCalled : WhenConvertingToDictionaryFromGameData
        {
            private StarSystem _starSystem = null!;

            [SetUp]
            public void Setup()
            {
                _starSystem = new Fixture()
                    .For<StarSystem>()
                    .With(p => p.Name, "Star System Name")
                    .With(r => r.Region, null)
                    .With(r => r.GalacticCoordinates, "0000:0000:0000:0000")
                    .With(r => r.Planets, [])
                    .With(r => r.SpaceStationTradeItems, ["iron", "pokemon cards"])
                    .Create();
            }

            [Test]
            public void ThenStarSystemDictionaryIsPopulated()
            {
                var dictionary = _starSystem.ToDictionary();
                dictionary[nameof(StarSystem.Name)].ShouldEqual(_starSystem.Name);
                dictionary[nameof(StarSystem.StarSystemId)].ShouldEqual(_starSystem.StarSystemId.ToString());
                dictionary[nameof(StarSystem.NormalizedName)].ShouldEqual(_starSystem.NormalizedName);
                dictionary[nameof(StarSystem.GalacticCoordinates)].ShouldEqual(_starSystem.GalacticCoordinates);
                dictionary[nameof(StarSystem.IsGiantSystem)].ShouldEqual(_starSystem.IsGiantSystem);
                dictionary[nameof(StarSystem.StarCount)].ShouldEqual(_starSystem.StarCount);
                dictionary[nameof(StarSystem.SpaceStationTradeItems)].ShouldEqual(_starSystem.SpaceStationTradeItems);
                dictionary[nameof(StarSystem.RegionId)].ShouldEqual(_starSystem.RegionId.ToString());
            }
        }

        public class WhenPlanetToDictionaryIsCalled : WhenConvertingToDictionaryFromGameData
        {
            private Planet _planet = null!;

            [SetUp]
            public void Setup()
            {
                _planet = new Fixture()
                    .For<Planet>()
                    .With(p => p.Name, "Planet Name")
                    .With(p => p.StarSystem, null)
                    .With(p => p.RawIngredients, ["bread", "milk"])
                    .Create();
            }

            [Test]
            public void ThenPlanetDictionaryIsPopulated()
            {
                var dictionary = _planet.ToDictionary();
                dictionary[nameof(Planet.Name)].ShouldEqual(_planet.Name);
                dictionary[nameof(Planet.PlanetId)].ShouldEqual(_planet.PlanetId.ToString());
                dictionary[nameof(Planet.NormalizedName)].ShouldEqual(_planet.NormalizedName);
                dictionary[nameof(Planet.StarSystemId)].ShouldEqual(_planet.StarSystemId.ToString());
                dictionary[nameof(Planet.HasSandworms)].ShouldEqual(_planet.HasSandworms);
                dictionary[nameof(Planet.DocumentSequence)].ShouldEqual(_planet.DocumentSequence);
                dictionary[nameof(Planet.RawIngredients)].ShouldEqual(_planet.RawIngredients);
            }
        }
    }

    public class WhenConvertingToGameDataFromDictionary : GameDataModelTests
    {
        private readonly Dictionary<string, object> _dictionary = [];

        public class WhenConvertingGalaxy : WhenConvertingToGameDataFromDictionary
        {
            [SetUp]
            public void Setup()
            {
                _dictionary[nameof(Galaxy.GalaxyId)] = Guid.NewGuid();
                _dictionary[nameof(Galaxy.Name)] = "Euclid";
                _dictionary[nameof(Galaxy.Sequence)] = 1;
            }

            [Test]
            public void ThenGalaxyIsPopulated()
            {
                var galaxy = _dictionary.ConvertDictionaryToObject<Galaxy>();
                galaxy.GalaxyId.ShouldEqual((Guid)_dictionary[nameof(Galaxy.GalaxyId)]!);
                galaxy.Name.ShouldEqual((string)_dictionary[nameof(Galaxy.Name)]!);
                galaxy.Sequence.ShouldEqual((int)_dictionary[nameof(Galaxy.Sequence)]!);
            }
        }

        public class WhenConvertingRegion : WhenConvertingToGameDataFromDictionary
        {
            [SetUp]
            public void Setup()
            {
                _dictionary[nameof(Region.RegionId)] = Guid.NewGuid();
                _dictionary[nameof(Region.Name)] = "Euclid";
                _dictionary[nameof(Region.GalaxyId)] = Guid.NewGuid();
                _dictionary[nameof(Region.Coordinates)] = "123a:123b:123d:123f";
                _dictionary[nameof(Region.DocSequence)] = 1;
                _dictionary[nameof(Region.RegionAge)] = 5.1f;
            }

            [Test]
            public void ThenRegionIsPopulated()
            {
                var region = _dictionary.ConvertDictionaryToObject<Region>();
                region.RegionId.ShouldEqual((Guid)_dictionary[nameof(Region.RegionId)]!);
                region.Name.ShouldEqual((string)_dictionary[nameof(Region.Name)]!);
                region.Coordinates.ShouldEqual(((string)_dictionary[nameof(Region.Coordinates)]!).ToUpperInvariant());
                region.XX.ShouldEqual("123A");
                region.DocSequence.ShouldEqual((int)_dictionary[nameof(Region.DocSequence)]!);
                region.RegionAge.ShouldEqual((float?)_dictionary[nameof(Region.RegionAge)]);
            }
        }

        public class WhenConvertingStarSystem : WhenConvertingToGameDataFromDictionary
        {
            [SetUp]
            public void Setup()
            {
                _dictionary[nameof(StarSystem.StarSystemId)] = Guid.NewGuid();
                _dictionary[nameof(StarSystem.Name)] = "Euclid";
                _dictionary[nameof(StarSystem.RegionId)] = Guid.NewGuid();
                _dictionary[nameof(StarSystem.GalacticCoordinates)] = "123a:123b:123d:123f";
                _dictionary[nameof(StarSystem.IsGiantSystem)] = true;
                _dictionary[nameof(StarSystem.Buy)] = -13.4f;
                _dictionary[nameof(StarSystem.SpaceStationTradeItems)] = new HashSet<string?>
                {
                    "Labooboo dolls",
                    "Funko pops",
                };
                _dictionary[nameof(StarSystem.HasCenterAccess)] = false;
            }

            [Test]
            public void ThenStarSystemIsPopulated()
            {
                var starSystem = _dictionary.ConvertDictionaryToObject<StarSystem>();
                starSystem.StarSystemId.ShouldEqual((Guid)_dictionary[nameof(StarSystem.StarSystemId)]!);
                starSystem.RegionId.ShouldEqual((Guid)_dictionary[nameof(StarSystem.RegionId)]!);
                starSystem.Name.ShouldEqual((string)_dictionary[nameof(StarSystem.Name)]!);
                starSystem.GalacticCoordinates.ShouldEqual(
                    ((string)_dictionary[nameof(StarSystem.GalacticCoordinates)]!).ToUpperInvariant());
                starSystem.IsGiantSystem.ShouldEqual((bool)_dictionary[nameof(StarSystem.IsGiantSystem)]!);
                starSystem.Buy.ShouldEqual((float?)_dictionary[nameof(StarSystem.Buy)]);
                starSystem.HasCenterAccess.ShouldEqual((bool?)_dictionary[nameof(StarSystem.HasCenterAccess)]!);
            }
        }

        public class WhenConvertingPlanet : WhenConvertingToGameDataFromDictionary
        {
            [SetUp]
            public void Setup()
            {
                _dictionary[nameof(Planet.PlanetId)] = Guid.NewGuid();
                _dictionary[nameof(Planet.Name)] = "Earth";
                _dictionary[nameof(Planet.PlanetNameAllPlatforms)] = "Terra";
                _dictionary[nameof(Planet.PlanetIdInSystem)] = null!;
                _dictionary[nameof(Planet.IsInfected)] = true;
                _dictionary[nameof(Planet.RawIngredients)] = new HashSet<string?> { "tofu", "spam" };
                _dictionary[nameof(Planet.NumberOfFauna)] = 2;
                _dictionary[nameof(Planet.HasSandworms)] = true;
            }

            [Test]
            public void ThenPlanetIsPopulated()
            {
                var planet = _dictionary.ConvertDictionaryToObject<Planet>();
                planet.PlanetId.ShouldEqual((Guid)_dictionary[nameof(Planet.PlanetId)]!);
                planet.Name.ShouldEqual((string)_dictionary[nameof(Planet.Name)]!);
                planet.PlanetNameAllPlatforms.ShouldEqual((string?)_dictionary[nameof(Planet.PlanetNameAllPlatforms)]);
                planet.PlanetIdInSystem.ShouldEqual((int?)_dictionary[nameof(Planet.PlanetIdInSystem)]);
                planet.RawIngredients.ShouldEqual((HashSet<string?>)_dictionary[nameof(Planet.RawIngredients)]!);
                planet.NumberOfFauna.ShouldEqual((int?)_dictionary[nameof(Planet.NumberOfFauna)]);
                planet.HasSandworms.ShouldEqual((bool?)_dictionary[nameof(Planet.HasSandworms)]);
            }
        }
    }
}