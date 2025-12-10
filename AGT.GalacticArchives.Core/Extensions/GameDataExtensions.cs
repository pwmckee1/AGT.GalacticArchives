using System.Reflection;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models;

namespace AGT.GalacticArchives.Core.Extensions;

public static class GameDataExtensions
{
    public static Dictionary<string, object> ToDictionary(
        this IDatabaseGameEntity databaseGameEntity,
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

    public static Dictionary<string, object> ToDictionary(this IDatabaseGameEntity databaseGameEntity)
    {
        var properties = databaseGameEntity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var excludedProperties = databaseGameEntity.PropertiesExcludedFromDatabase();

        return databaseGameEntity.ToDictionary(properties, excludedProperties);
    }
}