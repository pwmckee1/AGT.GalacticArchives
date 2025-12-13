using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IStarSystemManager
{
    Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId);

    Task<HashSet<StarSystem>> GetStarSystemsAsync(StarSystemRequest request);

    Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem);

    Task<HashSet<StarSystem>> UpsertStarSystemAsync(HashSet<StarSystem> request);

    Task DeleteStarSystemAsync(Guid starSystemId);
}