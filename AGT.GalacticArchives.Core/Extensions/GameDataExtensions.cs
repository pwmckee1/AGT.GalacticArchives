using System.Reflection;
using AGT.GalacticArchives.Core.Models.GameData.Interfaces;

namespace AGT.GalacticArchives.Core.Extensions;

public static class GameDataExtensions
{
    extension(IDatabaseEntity entity)
    {
        public Dictionary<string, object?> ToDictionary(
            PropertyInfo[] properties,
            HashSet<string> excludedProperties)
        {
            var result = new Dictionary<string, object?>();

            foreach (var property in properties.Where(p => !excludedProperties.Contains(p.Name)))
            {
                object? value = property.GetValue(entity);

                if (property.PropertyType == typeof(Guid) || property.PropertyType == typeof(Guid?))
                {
                    value = value?.ToString();
                }

                result[property.Name] = value;
            }

            return result;
        }

        public Dictionary<string, object?> ToDictionary()
        {
            var properties = entity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var excludedProperties = entity.PropertiesExcludedFromDatabase();

            return entity.ToDictionary(properties, excludedProperties);
        }
    }
}