namespace AGT.GalacticArchives.Core.Interfaces.GameData;

public interface IGameData
{
    public Guid EntityId { get; }

    Dictionary<string, object?> ToDictionary();
}