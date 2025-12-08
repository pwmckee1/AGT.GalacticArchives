namespace AGT.GalacticArchives.Core.Models;

public interface IDatabaseEntity
{
    Guid Id { get; }

    string Name { get; set; }
}