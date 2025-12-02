using System.Collections.Concurrent;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public abstract class CacheManagerBase : ICacheManager
{
    protected readonly IDistributedCache DistributedCache;
    protected ConcurrentDictionary<string, bool> Keys = new();

    protected CacheManagerBase(IDistributedCache distributedCache)
    {
        DistributedCache = distributedCache;
    }

    public virtual HashSet<string> GetCacheKeys(string? key)
    {
        return string.IsNullOrEmpty(key)
            ? Keys.Keys.ToHashSet()
            : Keys.Keys.Where(k => k.Equals(key, StringComparison.InvariantCultureIgnoreCase)).ToHashSet();
    }

    // This implements the same as GetAsync<T/> without the T : Class requirement.
    // This is used for when there's no backing class so you can still use cache only storage.
    public async Task<T?> GetNoClassAsync<T>(string key, Func<Task<T>>? targetMethod, int? cacheDurationInMinutes = null)
    {
        byte[]? data = await DistributedCache.GetAsync(key);
        return data == null ? default : JsonConvert.DeserializeObject<T>(System.Text.Encoding.UTF8.GetString(data));
    }

    public virtual async Task<T?> GetAsync<T>(string key)
        where T : class?
    {
        byte[]? data = await DistributedCache.GetAsync(key);
        return data == null ? null : JsonConvert.DeserializeObject<T>(System.Text.Encoding.UTF8.GetString(data));
    }

    public virtual async Task<T?> GetAsync<T>(string key, Func<Task<T>>? targetMethod, int? cacheDurationInMinutes = null)
        where T : class?
    {
        return await GetAsync(
            key,
            targetMethod,
            new DistributedCacheEntryOptions()
                .SetAbsoluteExpiration(
                    new TimeSpan(0, cacheDurationInMinutes ?? BusinessRuleConstants.CacheDurationInMinutes, 0)));
    }

    public virtual async Task<T?> GetAsync<T>(string key, Func<Task<T>>? targetMethod, DistributedCacheEntryOptions cacheOptions)
        where T : class?
    {
        T? result = default;

        byte[]? cachedData = await DistributedCache.GetAsync(key);
        if (cachedData != null)
        {
            result = JsonConvert.DeserializeObject<T>(System.Text.Encoding.UTF8.GetString(cachedData))!;
        }
        else if (targetMethod != null)
        {
            result = await targetMethod.Invoke();

            await SetAsync(key, result, cacheOptions);
        }

        return result!;
    }

    public virtual async Task SetAsync<T>(string key, T value, int? cacheDurationInMinutes = null)
    {
        var cacheOptions = new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = new TimeSpan(0, cacheDurationInMinutes ?? BusinessRuleConstants.CacheDurationInMinutes, 0),
        };

        await SetAsync(key, value, cacheOptions);
    }

    public virtual async Task SetAsync<T>(string key, T value, DistributedCacheEntryOptions cacheOptions)
    {
        var settings = new JsonSerializerSettings
        {
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            NullValueHandling = NullValueHandling.Ignore,
        };

        string json = JsonConvert.SerializeObject(value, settings);
        await DistributedCache.SetAsync(key, System.Text.Encoding.UTF8.GetBytes(json), cacheOptions);
        Keys[key] = true;
    }

    public virtual async Task<T?> GetEnumAsync<T>(string key, Func<Task<T>>? targetMethod, int? cacheDurationInMinutes = null)
        where T : Enum
    {
        T? result = default;
        var cacheOptions = new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = new TimeSpan(0, cacheDurationInMinutes ?? BusinessRuleConstants.CacheDurationInMinutes, 0),
        };

        byte[]? cachedData = await DistributedCache.GetAsync(key);
        if (cachedData != null)
        {
            result = JsonConvert.DeserializeObject<T>(System.Text.Encoding.UTF8.GetString(cachedData))!;
        }
        else if (targetMethod != null)
        {
            result = await targetMethod.Invoke();

            await SetAsync(key, result, cacheOptions);
        }

        return result!;
    }

    public abstract Task ClearCacheBySuffixAsync(string cacheKeySuffix);

    public abstract Task ClearCacheByPrefixAsync(string cacheKeyPrefix);

    public abstract Task ClearCacheByPartialAsync(string partialCacheKey);

    public virtual async Task ClearCacheByKeyAsync(string? cacheKey)
    {
        if (string.IsNullOrEmpty(cacheKey))
        {
            foreach (var key in Keys.Keys)
            {
                await DistributedCache.RemoveAsync(key);
            }

            Keys = new ConcurrentDictionary<string, bool>();
        }
        else
        {
            await DistributedCache.RemoveAsync(cacheKey);
            Keys.TryRemove(cacheKey, out _);
        }
    }

    public virtual async Task ClearCacheByKeyAsync(HashSet<string> cacheKeys)
    {
        foreach (string cacheKey in cacheKeys)
        {
            await ClearCacheByKeyAsync(cacheKey);
        }
    }

    public virtual async Task ClearAllCacheAsync()
    {
        await Task.Run(() => { });
    }

    public abstract Task ClearCacheByPatternAsync(string pattern);
}

