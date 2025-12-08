using System.Reflection;
using AGT.GalacticArchives.Core.Models;

namespace AGT.GalacticArchives.Core.Extensions;

public static class GameDataExtensions
{
    public static Dictionary<string, object> ToDictionary(
        this IDatabaseEntity databaseEntity,
        PropertyInfo[] properties,
        HashSet<string> excludedProperties)
    {
        var result = new Dictionary<string, object>();

        foreach (var property in properties.Where(p => !excludedProperties.Contains(p.Name)))
        {
            object? value = property.GetValue(databaseEntity);

            if (property.PropertyType == typeof(Guid) || property.PropertyType == typeof(Guid?))
            {
                value = value?.ToString();
            }

            result[property.Name] = value!;
        }

        return result;
    }

    public static Dictionary<string, object> ToDictionary(this IDatabaseEntity databaseEntity)
    {
        var properties = databaseEntity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var excludedProperties = databaseEntity.PropertiesExcludedFromDatabase();

        return databaseEntity.ToDictionary(properties, excludedProperties);
    }
}