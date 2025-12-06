using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace AGT.GalacticArchives.Core.Extensions;

public static class CacheKeyExtensions
{
    private static readonly JsonSerializerOptions Options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = false,
    };

    public static string GetRequestHash<T>(this T request, [CallerMemberName] string callingMethod = "")
        where T : class
    {
        string json = JsonSerializer.Serialize(
            request,
            Options);
        Span<byte> hash = stackalloc byte[32];
        SHA256.TryHashData(Encoding.UTF8.GetBytes(json), hash, out _);
        string hex = Convert.ToHexString(hash).ToLower()[..16];
        return $"{typeof(T)}:{callingMethod}:{hex}";
    }
}