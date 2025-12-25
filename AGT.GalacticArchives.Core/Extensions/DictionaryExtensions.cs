using System.Reflection;
using System.Runtime.CompilerServices;
using AGT.GalacticArchives.Globalization;
using Newtonsoft.Json;

namespace AGT.GalacticArchives.Core.Extensions;

public static class DictionaryExtensions
{
    public static bool MatchesDictionary(
        this Dictionary<string, object>? originalData,
        Dictionary<string, object>? comparisonData)
    {
        if (originalData?.Count == 0 && comparisonData?.Count == 0)
        {
            return false;
        }

        if (originalData?.Count == 0 || comparisonData?.Count == 0)
        {
            return true;
        }

        string serializedOriginalData = JsonConvert.SerializeObject(
            originalData,
            new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
            });

        string serializedComparisonData = JsonConvert.SerializeObject(
            comparisonData,
            new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
            });

        return serializedOriginalData == serializedComparisonData;
    }

    public static T ConvertDictionaryToObject<T>(this Dictionary<string, object?>? originalData)
        where T : class
    {
        var instance = (T)RuntimeHelpers.GetUninitializedObject(typeof(T));
        var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);

        foreach (var property in properties)
        {
            if (!property.CanWrite)
            {
                continue;
            }

            if (originalData == null || !originalData.TryGetValue(property.Name, out object? value))
            {
                continue;
            }

            try
            {
                object? convertedValue = ConvertValueToPropertyType(value, property.PropertyType);
                property.SetValue(instance, convertedValue);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(
                    string.Format(
                        GeneralErrorResource.FailedToConvertProperty,
                        property.Name,
                        typeof(T).Name,
                        value,
                        value?.GetType().Name,
                        property.PropertyType.Name),
                    ex);
            }
        }

        return instance;
    }

    private static object? ConvertValueToPropertyType(object? value, Type targetType)
    {
        if (value == null)
        {
            return null;
        }

        // Normalize common Firestore SDK return types (arrays, maps, Timestamp, etc.)
        value = value.NormalizeFirestoreValue();

        if (value == null)
        {
            return null;
        }

        // If types match, return it
        if (targetType.IsInstanceOfType(value))
        {
            return value;
        }

        // Handle nullable types
        var underlyingType = Nullable.GetUnderlyingType(targetType) ?? targetType;

        // Date/time: Firestore Timestamp gets normalized to DateTime, but your model might use DateTimeOffset
        if (underlyingType == typeof(DateTimeOffset))
        {
            switch (value)
            {
                case DateTimeOffset dto:
                    return dto;

                case DateTime dt:
                {
                    // Treat unspecified as UTC to match Firestore Timestamp semantics
                    if (dt.Kind == DateTimeKind.Unspecified)
                    {
                        dt = DateTime.SpecifyKind(dt, DateTimeKind.Utc);
                    }

                    return new DateTimeOffset(dt);
                }

                case string s when DateTimeOffset.TryParse(
                    s,
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.RoundtripKind,
                    out var parsedDto):
                    return parsedDto;
            }
        }

        // Optional: if your target is DateTime but you got DateTimeOffset, convert back.
        if (underlyingType == typeof(DateTime) && value is DateTimeOffset asDto)
        {
            return asDto.UtcDateTime;
        }

        // Enums (Firestore may return string (preferred) or long (legacy docs))
        if (underlyingType.IsEnum)
        {
            if (value is string enumName)
            {
                return Enum.Parse(underlyingType, enumName, true);
            }

            var enumUnderlying = Enum.GetUnderlyingType(underlyingType);
            object numeric = Convert.ChangeType(value, enumUnderlying);
            return Enum.ToObject(underlyingType, numeric);
        }

        // Guid: recommended Firestore storage is string
        if (underlyingType == typeof(Guid))
        {
            switch (value)
            {
                case Guid guidValue:
                    return guidValue;
                case string guidString:
                    return Guid.Parse(guidString);
            }
        }

        // Firestore numeric widening
        if (underlyingType == typeof(int) && value is long longValue)
        {
            return (int)longValue;
        }

        if (underlyingType == typeof(float))
        {
            switch (value)
            {
                case double doubleValue:
                    return (float)doubleValue;
                case long longValue2:
                    return (float)longValue2;
            }
        }

        // Convert Firestore arrays (List<object>) to HashSet<T>
        if (underlyingType.IsGenericType && underlyingType.GetGenericTypeDefinition() == typeof(HashSet<>))
        {
            return value.ConvertEnumerableToHashSet(underlyingType);
        }

        // Convert.ChangeType for primitives
        if (underlyingType.IsPrimitive || underlyingType == typeof(decimal))
        {
            return Convert.ChangeType(value, underlyingType);
        }

        throw new InvalidCastException(
            string.Format(GeneralErrorResource.CannotConvertValue, value.GetType().Name, targetType.Name));
    }
}