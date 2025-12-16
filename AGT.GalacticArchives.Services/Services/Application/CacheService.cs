using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Services.Interfaces.Application;

namespace AGT.GalacticArchives.Services.Services.Application;

public class CacheService(ICacheManager cacheManager) : ICacheService
{
    public HashSet<string> GetCacheKeys()
    {
        return cacheManager.GetCacheKeys();
    }

    public async Task ClearCacheByKey(string? cacheKey = null)
    {
        if (string.IsNullOrEmpty(cacheKey))
        {
            await cacheManager.ClearAllCacheAsync();
        }

        await cacheManager.ClearCacheByKeyAsync(cacheKey);
    }
}