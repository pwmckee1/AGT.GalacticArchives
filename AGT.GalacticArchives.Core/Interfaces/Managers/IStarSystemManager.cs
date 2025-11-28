using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IStarSystemManager
{
    Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId);

    Task CreateOrUpdateStarSystemAsync(StarSystem starSystem);

    Task DeleteStarSystemAsync(Guid starSystemId);
}