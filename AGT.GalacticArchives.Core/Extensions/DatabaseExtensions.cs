using System.Collections;
using System.Reflection;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Extensions;

public static class DatabaseExtensions
{
    public static HashSet<string> PropertiesExcludedFromDatabase(this IDatabaseEntity entity)
    {
        // NOTE: must use runtime type; calling this from an interface-typed reference should still work.
        return entity.GetType().Name switch
        {
            nameof(Region) => [nameof(Region.StarSystems)],
            nameof(StarSystem) => [nameof(StarSystem.Region)],
            nameof(Planet) => [nameof(Planet.StarSystem)],
            nameof(MultiTool) or nameof(Starship) => [nameof(StarSystem), nameof(Planet)],
            nameof(Fauna) or nameof(PlayerBase) or nameof(PointOfInterest) or nameof(Settlement) => [nameof(Planet)],
            _ => [],
        };
    }

    public static Dictionary<string, object> ToDictionary(this IDatabaseEntity databaseGameEntity)
    {
        var properties = databaseGameEntity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var excludedProperties = databaseGameEntity.PropertiesExcludedFromDatabase();

        return databaseGameEntity.ToDictionary(properties, excludedProperties);
    }

    public static Dictionary<string, object> ToDictionary(
        this IDatabaseEntity databaseGameEntity,
        PropertyInfo[] properties,
        HashSet<string> excludedProperties)
    {
        var result = new Dictionary<string, object>();

        foreach (var property in properties.Where(p => !excludedProperties.Contains(p.Name)))
        {
            object? value = property.GetValue(databaseGameEntity);

            if (property.PropertyType == typeof(Guid) || property.PropertyType == typeof(Guid?))
            {
                value = value?.ToString();
            }

            value = ConvertToFirestoreValue(value);

            result[property.Name] = value!;
        }

        return result;
    }

    public static Dictionary<string, string> ToDictionary(this ISearchRequest request)
    {
        if (request == null)
        {
            return new Dictionary<string, string>();
        }

        return request
            .GetType()
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Select(prop => new
            {
                prop.Name,
                Value = prop.GetValue(request),
            })
            .Where(p => p.Value != null)
            .ToDictionary(p => p.Name, p => p.Value!.ToString() ?? string.Empty);
    }

    public static async Task<PagedDatabaseResponse> ToPaginatedDatabaseQueryAsync(
        this Query? query,
        int pageNumber,
        int pageSize,
        CancellationToken ct)
    {
        if (query == null)
        {
            return new PagedDatabaseResponse();
        }

        var countQuery = await query.Count().GetSnapshotAsync(ct);
        long totalRecords = countQuery.Count ?? 0;
        long totalPages = (long)Math.Ceiling((decimal)totalRecords / pageSize);
        if (totalRecords > 0)
        {
            int skip = (pageNumber - 1) * pageSize;
            query = query.Offset(skip).Limit(pageSize);
        }

        var snapshot = await query.GetSnapshotAsync(ct);

        var pagedResponse = new PagedDatabaseResponse
        {
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalRecords = totalRecords,
            TotalPages = totalPages,
            Response = snapshot.Documents.Count == 0 ? [] : [.. snapshot.Documents.Select(s => s.ToDictionary())],
        };
        return pagedResponse;
    }

    private static object? ConvertToFirestoreValue(object? value)
    {
        if (value is null)
        {
            return null;
        }

        // Enums -> string names (e.g. Alpha)
        if (value is Enum e)
        {
            return e.ToString();
        }

        // IEnumerable (but not string) -> List<object?>, recursively converting items (including enums)
        if (value is IEnumerable enumerable && value is not string)
        {
            var list = new List<object?>();
            foreach (var item in enumerable)
            {
                list.Add(ConvertToFirestoreValue(item));
            }

            return list;
        }

        return value;
    }
}