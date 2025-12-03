using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface IStarSystemManager
{
    Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId);

    Task<HashSet<StarSystem>> GetStarSystemsAsync(StarSystemRequest request);

    Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem);

    Task DeleteStarSystemAsync(Guid starSystemId);
}