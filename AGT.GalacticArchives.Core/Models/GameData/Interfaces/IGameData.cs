namespace AGT.GalacticArchives.Core.Models.GameData.Interfaces;

using System.Reflection;

public interface IGameData
{
    Guid EntityId { get; }

    string CollectionName { get; }

    Dictionary<string, object?> ToDictionary(
        GameDataEntity? gameData = null,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!);
}