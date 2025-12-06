using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace AGT.GalacticArchives.Core.Extensions;

public static class CacheKeyExtensions
{
    extension<T>(T request)
        where T : class
    {
        public string GetRequestHash([CallerMemberName] string callingMethod = "")
        {
            string json = JsonSerializer.Serialize(
                request,
                new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = false,
                });
            Span<byte> hash = stackalloc byte[32];
            SHA256.TryHashData(Encoding.UTF8.GetBytes(json), hash, out _);
            string hex = Convert.ToHexString(hash).ToLower()[..16];
            return $"{typeof(T)}:{callingMethod}:{hex}";
        }
    }
}