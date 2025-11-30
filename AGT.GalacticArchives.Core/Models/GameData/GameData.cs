using System.Reflection;
using AGT.GalacticArchives.Core.Interfaces.GameData;

namespace AGT.GalacticArchives.Core.Models.GameData;

public abstract class GameData : IGameData
{
    public abstract Guid EntityId { get; }
    public virtual Dictionary<string, object?> ToDictionary(
        GameData gameData = null!,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!)
    {
        var result = new Dictionary<string, object?>();

        foreach (var property in properties.Where(p => !excludedProperties.Contains(p.Name)))
        {
            var value = property.GetValue(gameData);

            if (property.PropertyType == typeof(Guid) || property.PropertyType == typeof(Guid?))
            {
                value = value?.ToString();
            }

            result[property.Name] = value;
        }

        return result;
    }
}