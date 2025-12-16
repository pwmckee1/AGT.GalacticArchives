using System.Text.RegularExpressions;
using AGT.GalacticArchives.Core.Constants;
using Microsoft.Extensions.Caching.Distributed;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class InMemoryCacheManager(IDistributedCache distributedCache) : CacheManagerBase(distributedCache)
{
    public override async Task<T?> GetAsync<T>(
        string key,
        Func<Task<T>>? targetMethod,
        int? cacheDurationInMinutes = null)
        where T : class
    {
        return await GetAsync(
            key,
            targetMethod,
            new DistributedCacheEntryOptions()
                .SetAbsoluteExpiration(
                    new TimeSpan(0, cacheDurationInMinutes ?? BusinessRuleConstants.CacheDurationInMinutes, 0)));
    }

    public override async Task ClearCacheBySuffixAsync(string cacheKeySuffix)
    {
        foreach (string key in CacheKeys.Keys.Where(k => k.EndsWith(cacheKeySuffix)))
        {
            await DistributedCache.RemoveAsync(key);
            CacheKeys.TryRemove(key, out _);
        }
    }

    public override async Task ClearCacheByPrefixAsync(string cacheKeyPrefix)
    {
        foreach (string key in CacheKeys.Keys.Where(k => k.StartsWith(cacheKeyPrefix)))
        {
            await DistributedCache.RemoveAsync(key);
            CacheKeys.TryRemove(key, out _);
        }
    }

    public override async Task ClearCacheByPartialAsync(string partialCacheKey)
    {
        foreach (string key in CacheKeys.Keys.Where(k => k.Contains(partialCacheKey)))
        {
            await DistributedCache.RemoveAsync(key);
            CacheKeys.TryRemove(key, out _);
        }
    }

    public override async Task ClearCacheByPatternAsync(string pattern)
    {
        foreach (string key in CacheKeys.Keys.Where(k => Regex.IsMatch(k, pattern)))
        {
            await DistributedCache.RemoveAsync(key);
            CacheKeys.TryRemove(key, out _);
        }
    }

    public override async Task ClearAllCacheAsync()
    {
        foreach (string key in CacheKeys.Keys)
        {
            await DistributedCache.RemoveAsync(key);
        }

        CacheKeys.Clear();
    }
}