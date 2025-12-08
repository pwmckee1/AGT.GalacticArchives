using System.Diagnostics.CodeAnalysis;
using AGT.GalacticArchives.Core.Models.Entities;

namespace AGT.GalacticArchives.Core.Extensions;

public static class DatabaseExtensions
{
    [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1313:Parameter names should begin with lower-case letter")]
    public static HashSet<string> PropertiesExcludedFromDatabase<T>(this T _)
    {
        return typeof(T).Name switch
        {
            nameof(Region) => [nameof(Region.Galaxy), nameof(Region.StarSystems)],
            nameof(StarSystem) =>
            [
                nameof(StarSystem.Region),
                nameof(StarSystem.Planets),
                nameof(StarSystem.MultiTools),
                nameof(StarSystem.Starships),
            ],
            nameof(Planet) =>
            [
                nameof(Planet.StarSystem),
                nameof(Planet.Fauna),
                nameof(Planet.MultiTools),
                nameof(Planet.PlayerBases),
                nameof(Planet.PointsOfInterest),
                nameof(Planet.Settlements),
                nameof(Planet.Starships),
            ],
            nameof(MultiTool) or nameof(Starship) => [nameof(StarSystem), nameof(Planet),],
            nameof(Fauna) or nameof(PlayerBase) or nameof(PointOfInterest) or nameof(Settlement) => [nameof(Planet)],
            _ => [],
        };
    }
}