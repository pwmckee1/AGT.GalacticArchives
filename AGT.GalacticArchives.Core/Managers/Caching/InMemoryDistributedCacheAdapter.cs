using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class InMemoryDistributedCacheAdapter : IDistributedCache
{
    private readonly IMemoryCache _memoryCache;

    public InMemoryDistributedCacheAdapter(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
    }

    public byte[] Get(string key)
    {
        _memoryCache.TryGetValue(key, out byte[]? value);
        return value ?? [];
    }

    public Task<byte[]?> GetAsync(string key, CancellationToken token = default)
    {
        _memoryCache.TryGetValue(key, out byte[]? value);
        return Task.FromResult(value);
    }

    public void Set(string key, byte[] value, DistributedCacheEntryOptions options)
    {
        var cacheEntryOptions = new MemoryCacheEntryOptions
        {
            AbsoluteExpiration = options.AbsoluteExpiration,
            AbsoluteExpirationRelativeToNow = options.AbsoluteExpirationRelativeToNow,
            SlidingExpiration = options.SlidingExpiration,
        };

        _memoryCache.Set(key, value, cacheEntryOptions);
    }

    public Task SetAsync(string key, byte[] value, DistributedCacheEntryOptions options, CancellationToken token = default)
    {
        var cacheEntryOptions = new MemoryCacheEntryOptions
        {
            AbsoluteExpiration = options.AbsoluteExpiration,
            AbsoluteExpirationRelativeToNow = options.AbsoluteExpirationRelativeToNow,
            SlidingExpiration = options.SlidingExpiration,
        };

        _memoryCache.Set(key, value, cacheEntryOptions);
        return Task.CompletedTask;
    }

    // Not supported by In Memory Cache
    public void Refresh(string key) { }

    // Not supported by In Memory Cache
    public Task RefreshAsync(string key, CancellationToken token = default)
    {
        return Task.CompletedTask;
    }

    public void Remove(string key)
    {
        _memoryCache.Remove(key);
    }

    public Task RemoveAsync(string key, CancellationToken token = default)
    {
        _memoryCache.Remove(key);
        return Task.CompletedTask;
    }
}
