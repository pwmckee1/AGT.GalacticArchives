using AGT.GalacticArchives.Core.Models.Environments;
using AGT.GalacticArchives.Core.Models.Requests.Environments;

namespace AGT.GalacticArchives.Core.Managers.Environments;

public interface IStarSystemManager
{
    Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId);

    Task<HashSet<StarSystem>> GetStarSystemsAsync(StarSystemRequest request);

    Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem);

    Task DeleteStarSystemAsync(Guid starSystemId);
}