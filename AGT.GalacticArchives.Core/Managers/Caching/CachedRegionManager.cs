using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Caching;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedRegionManager(ICacheManager cacheManager, IRegionManager target) : IRegionManager
{
    public async Task<Region?> GetRegionByIdAsync(Guid galaxyId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Region)}:{nameof(GetRegionByIdAsync)}",
            async () => await target.GetRegionByIdAsync(galaxyId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Region> UpsertRegionAsync(Region galaxy)
    {
        return await target.UpsertRegionAsync(galaxy);
    }

    public async Task DeleteRegionAsync(Guid galaxyId)
    {
        await target.DeleteRegionAsync(galaxyId);
    }
}