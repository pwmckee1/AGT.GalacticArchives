using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.InGame.Locations;

namespace AGT.GalacticArchives.Core.Extensions;

public static class DatabaseExtensions
{
    [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1313:Parameter names should begin with lower-case letter")]
    public static HashSet<string> PropertiesExcludedFromDatabase<T>(this T _)
    {
        return typeof(T).Name switch
        {
            nameof(Region) => [nameof(Region.Galaxy), nameof(Region.StarSystems)],
            nameof(StarSystem) => [nameof(StarSystem.Region),],
            nameof(Planet) => [nameof(Planet.StarSystem),],
            nameof(MultiTool) or nameof(Starship) => [nameof(StarSystem), nameof(Planet),],
            nameof(Fauna) or nameof(PlayerBase) or nameof(PointOfInterest) or nameof(Settlement) => [nameof(Planet)],
            _ => [],
        };
    }

    public static Dictionary<string, object> ToDictionary(
        this IDatabaseEntity databaseGameEntity,
        PropertyInfo[] properties,
        HashSet<string> excludedProperties)
    {
        var result = new Dictionary<string, object>();

        foreach (var property in properties.Where(p => !excludedProperties.Contains(p.Name)))
        {
            object? value = property.GetValue(databaseGameEntity);

            if (property.PropertyType == typeof(Guid) || property.PropertyType == typeof(Guid?))
            {
                value = value?.ToString();
            }

            result[property.Name] = value!;
        }

        return result;
    }

    public static Dictionary<string, object> ToDictionary(this IDatabaseEntity databaseGameEntity)
    {
        var properties = databaseGameEntity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var excludedProperties = databaseGameEntity.PropertiesExcludedFromDatabase();

        return databaseGameEntity.ToDictionary(properties, excludedProperties);
    }
}