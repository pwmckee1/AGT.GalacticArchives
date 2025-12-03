namespace AGT.GalacticArchives.Core.Managers.Caching;

using System.Text.RegularExpressions;
using AGT.GalacticArchives.Core.Constants;
using Microsoft.Extensions.Caching.Distributed;

public class InMemoryCacheManager : CacheManagerBase
{
    public InMemoryCacheManager(IDistributedCache distributedCache) : base(distributedCache)
    {
    }

    public override async Task<T?> GetAsync<T>(string key)
        where T : class
    {
        return await base.GetAsync<T>(key);
    }

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

    public override async Task<T?> GetAsync<T>(
        string key,
        Func<Task<T>>? targetMethod,
        DistributedCacheEntryOptions cacheOptions)
        where T : class
    {
        return await base.GetAsync(key, targetMethod, cacheOptions);
    }

    public override Task SetAsync<T>(string key, T value, int? cacheDurationInMinutes = null)
    {
        return base.SetAsync(key, value, cacheDurationInMinutes);
    }

    public override Task<T?> GetEnumAsync<T>(
        string key,
        Func<Task<T>>? targetMethod,
        int? cacheDurationInMinutes = null)
        where T : default
    {
        return base.GetEnumAsync(key, targetMethod, cacheDurationInMinutes);
    }

    public override async Task ClearCacheBySuffixAsync(string cacheKeySuffix)
    {
        foreach (string key in Keys.Keys.Where(k => k.EndsWith(cacheKeySuffix)))
        {
            await DistributedCache.RemoveAsync(key);
            Keys.TryRemove(key, out _);
        }
    }

    public override async Task ClearCacheByPrefixAsync(string cacheKeyPrefix)
    {
        foreach (string key in Keys.Keys.Where(k => k.StartsWith(cacheKeyPrefix)))
        {
            await DistributedCache.RemoveAsync(key);
            Keys.TryRemove(key, out _);
        }
    }

    public override async Task ClearCacheByPartialAsync(string partialCacheKey)
    {
        foreach (string key in Keys.Keys.Where(k => k.Contains(partialCacheKey)))
        {
            await DistributedCache.RemoveAsync(key);
            Keys.TryRemove(key, out _);
        }
    }

    public override async Task ClearCacheByPatternAsync(string pattern)
    {
        foreach (string key in Keys.Keys)
            if (Regex.IsMatch(key, pattern))
            {
                await DistributedCache.RemoveAsync(key);
                Keys.TryRemove(key, out _);
            }
    }

    public override async Task ClearAllCacheAsync()
    {
        foreach (string key in Keys.Keys) await DistributedCache.RemoveAsync(key);

        Keys.Clear();
    }
}