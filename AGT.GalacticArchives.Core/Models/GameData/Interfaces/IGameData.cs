using System.Reflection;

namespace AGT.GalacticArchives.Core.Models.GameData.Interfaces;

public interface IGameData
{
    public Guid EntityId { get; }

    public string CollectionName { get; }

    Dictionary<string, object?> ToDictionary(
        GameData? gameData = null,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!);
}