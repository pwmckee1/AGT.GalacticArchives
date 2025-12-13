namespace AGT.GalacticArchives.Services.Interfaces.Application;

public interface ICacheService
{
    HashSet<string> GetCacheKeys();

    Task ClearCacheByKey(string? cacheKey = null);
}