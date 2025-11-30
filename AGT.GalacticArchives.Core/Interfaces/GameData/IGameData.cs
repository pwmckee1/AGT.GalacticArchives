using System.Reflection;

namespace AGT.GalacticArchives.Core.Interfaces.GameData;

public interface IGameData
{
    public Guid EntityId { get; }

    Dictionary<string, object?> ToDictionary(
        Models.GameData.GameData gameData = null!,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!);
}