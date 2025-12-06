namespace AGT.GalacticArchives.Core.Models;

public interface IGameData
{
    Guid Id { get; }

    string Name { get; set; }
}