using System.Reflection;
using AGT.GalacticArchives.Core.Models;

namespace AGT.GalacticArchives.Core.Extensions;

public static class GameDataExtensions
{
    extension(IGameData gameData)
    {
        public Dictionary<string, object> ToDictionary(
            PropertyInfo[] properties,
            HashSet<string> excludedProperties)
        {
            var result = new Dictionary<string, object>();

            foreach (var property in properties.Where(p => !excludedProperties.Contains(p.Name)))
            {
                object? value = property.GetValue(gameData);

                if (property.PropertyType == typeof(Guid) || property.PropertyType == typeof(Guid?))
                {
                    value = value?.ToString();
                }

                result[property.Name] = value!;
            }

            return result;
        }

        public Dictionary<string, object> ToDictionary()
        {
            var properties = gameData.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var excludedProperties = gameData.PropertiesExcludedFromDatabase();

            return gameData.ToDictionary(properties, excludedProperties);
        }
    }
}