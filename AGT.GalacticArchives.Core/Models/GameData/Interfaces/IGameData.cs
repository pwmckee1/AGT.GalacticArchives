using System.Reflection;

namespace AGT.GalacticArchives.Core.Models.GameData.Interfaces;

public interface IGameData
{
    Guid EntityId { get; }

    string CollectionName { get; }

    Dictionary<string, object?> ToDictionary(
        GameData? gameData = null,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!);
}
