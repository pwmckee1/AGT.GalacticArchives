using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Environments;

namespace AGT.GalacticArchives.Core.Extensions;

public static class DatabaseExtensions
{
    extension<T>(T entity)
    {
        public HashSet<string> PropertiesExcludedFromDatabase()
        {
            return typeof(T).Name switch
            {
                nameof(Galaxy) => [nameof(Galaxy.Regions),],
                nameof(Region) => [nameof(Region.Galaxy), nameof(Region.StarSystems),],
                nameof(StarSystem) =>
                [
                    nameof(StarSystem.Region), nameof(StarSystem.Planets), nameof(StarSystem.MultiTools),
                    nameof(StarSystem.Starships),
                ],
                nameof(Planet) =>
                [
                    nameof(Planet.StarSystem), nameof(Planet.Fauna), nameof(Planet.MultiTools),
                    nameof(Planet.PlayerBases), nameof(Planet.PointsOfInterest), nameof(Planet.Settlements),
                    nameof(Planet.Starships),
                ],
                nameof(MultiTool) or nameof(Starship) => [nameof(StarSystem), nameof(Planet),],
                nameof(Fauna) or nameof(PlayerBase) or nameof(PointOfInterest) or nameof(Settlement) =>
                [
                    nameof(Planet),
                ],
                _ => [],
            };
        }
    }
}