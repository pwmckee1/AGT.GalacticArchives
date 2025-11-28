using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Caching;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedStarSystemManager(ICacheManager cacheManager, IStarSystemManager target) : IStarSystemManager
{
    public async Task<StarSystem?> GetStarSystemByIdAsync(Guid galaxyId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(StarSystem)}:{nameof(GetStarSystemByIdAsync)}",
            async () => await target.GetStarSystemByIdAsync(galaxyId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<StarSystem> UpsertStarSystemAsync(StarSystem galaxy)
    {
        return await target.UpsertStarSystemAsync(galaxy);
    }

    public async Task DeleteStarSystemAsync(Guid galaxyId)
    {
        await target.DeleteStarSystemAsync(galaxyId);
    }
}