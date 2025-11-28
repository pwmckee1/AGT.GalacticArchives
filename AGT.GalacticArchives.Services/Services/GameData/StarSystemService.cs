using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Services.Interfaces.GameData;

namespace AGT.GalacticArchives.Services.Services.GameData;

public class StarSystemService(IStarSystemManager starSystemManager) : IStarSystemService
{
    public async Task<HashSet<StarSystem>> GetStarSystemsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId)
    {
        throw new NotImplementedException();
    }

    public async Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteStarSystemAsync(Guid starSystemId)
    {
        throw new NotImplementedException();
    }
}