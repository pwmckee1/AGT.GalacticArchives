// <copyright file="CacheKeyExtensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AGT.GalacticArchives.Core.Extensions;

using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

public static class CacheKeyExtensions
{
    public static string GetRequestHash<T>(this T request, [CallerMemberName] string callingMethod = "")
        where T : class
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