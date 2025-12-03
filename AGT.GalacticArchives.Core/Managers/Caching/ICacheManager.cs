using Microsoft.Extensions.Caching.Distributed;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public interface ICacheManager
{
    HashSet<string> GetCacheKeys(string? key);

    Task<T?> GetNoClassAsync<T>(string key, Func<Task<T>>? targetMethod, int? cacheDurationInMinutes = null);

    Task<T?> GetAsync<T>(string key)
        where T : class?;

    Task<T?> GetAsync<T>(string key, Func<Task<T>>? targetMethod, int? cacheDurationInMinutes = null)
        where T : class?;

    Task<T?> GetAsync<T>(string key, Func<Task<T>>? targetMethod, DistributedCacheEntryOptions cacheOptions)
        where T : class?;

    Task SetAsync<T>(string key, T value, int? cacheDurationInMinutes = null);

    Task SetAsync<T>(string key, T value, DistributedCacheEntryOptions cacheOptions);

    Task<T?> GetEnumAsync<T>(string key, Func<Task<T>>? targetMethod, int? cacheDurationInMinutes = null)
        where T : Enum;

    Task ClearCacheBySuffixAsync(string cacheKeySuffix);

    Task ClearCacheByPrefixAsync(string cacheKeyPrefix);

    Task ClearCacheByPartialAsync(string partialCacheKey);

    Task ClearCacheByKeyAsync(string? cacheKey);

    Task ClearCacheByKeyAsync(HashSet<string> cacheKeys);

    Task ClearCacheByPatternAsync(string pattern);

    Task ClearAllCacheAsync();
}