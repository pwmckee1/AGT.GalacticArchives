using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using AGT.GalacticArchives.Globalization;
using Newtonsoft.Json;

namespace AGT.GalacticArchives.Core.Extensions;

public static class DictionaryExtensions
{
    public static bool Matches(
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

        return serializedOriginalData != serializedComparisonData;
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
                object? convertedValue = ConvertValue(value, property.PropertyType);
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

    private static object? ConvertValue(object? value, Type targetType)
    {
        if (value == null)
        {
            return null;
        }

        // Normalize common Firestore SDK return types (arrays, maps, Timestamp, etc.)
        value = NormalizeFirestoreValue(value);

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
            return ConvertEnumerableToHashSet(value, underlyingType);
        }

        // Convert.ChangeType for primitives
        if (underlyingType.IsPrimitive || underlyingType == typeof(decimal))
        {
            return Convert.ChangeType(value, underlyingType);
        }

        throw new InvalidCastException(
            string.Format(GeneralErrorResource.CannotConvertValue, value.GetType().Name, targetType.Name));
    }

    /// <summary>
    /// Normalizes values retrieved from Firestore into their corresponding .NET types.
    /// </summary>
    /// <param name="value">The value to normalize from Firestore.</param>
    /// <returns>
    /// A normalized object that can be used in .NET:
    /// - Converts Firestore maps to case-insensitive Dictionary&lt;string, object&gt;
    /// - Converts Firestore arrays to List&lt;object&gt;
    /// - Converts Firestore Timestamp to DateTime
    /// - Returns other values unchanged
    /// </returns>
    private static object NormalizeFirestoreValue(object value)
    {
        switch (value)
        {
            // Firestore "map" often comes back as Dictionary<string, object>
            case IDictionary<string, object> map:
            {
                var normalized = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);
                foreach (var kvp in map)
                {
                    normalized[kvp.Key] = kvp.Value == null ? null : NormalizeFirestoreValue(kvp.Value);
                }

                return normalized;
            }

            // Firestore "array" often comes back as List<object>
            case IList list when value is not string:
            {
                var normalizedList = new List<object?>(list.Count);
                foreach (object? item in list)
                {
                    normalizedList.Add(item == null ? null : NormalizeFirestoreValue(item));
                }

                return normalizedList;
            }
        }

        // Google.Cloud.Firestore.Timestamp -> DateTime (via reflection to avoid hard dependency here)
        var type = value.GetType();
        if (string.Equals(type.FullName, "Google.Cloud.Firestore.Timestamp", StringComparison.Ordinal))
        {
            var toDateTime = type.GetMethod("ToDateTime", BindingFlags.Public | BindingFlags.Instance);
            if (toDateTime != null)
            {
                return toDateTime.Invoke(value, null)!;
            }
        }

        return value;
    }

    private static object? ConvertEnumerableToHashSet(object value, Type hashSetType)
    {
        if (value is not IEnumerable enumerable)
        {
            return null;
        }

        var elementType = hashSetType.GetGenericArguments()[0];
        var elementUnderlying = Nullable.GetUnderlyingType(elementType) ?? elementType;

        var closedHashSetType = typeof(HashSet<>).MakeGenericType(elementType);
        object hashSetInstance = Activator.CreateInstance(closedHashSetType)!;

        var addMethod = closedHashSetType.GetMethod(nameof(HashSet<int>.Add), [elementType])!;
        foreach (object? item in enumerable)
        {
            object? convertedItem = item;

            if (convertedItem == null)
            {
                // Skip nulls for non-nullable value types
                if (elementUnderlying.IsValueType && Nullable.GetUnderlyingType(elementType) == null)
                {
                    continue;
                }

                addMethod.Invoke(hashSetInstance, [null]);
                continue;
            }

            convertedItem = NormalizeFirestoreValue(convertedItem);

            // Enum elements stored as strings (preferred) or numeric (legacy)
            if (elementUnderlying.IsEnum)
            {
                if (convertedItem is string s)
                {
                    convertedItem = Enum.Parse(elementUnderlying, s, true);
                }
                else
                {
                    var enumUnderlying = Enum.GetUnderlyingType(elementUnderlying);
                    object numeric = Convert.ChangeType(convertedItem, enumUnderlying);
                    convertedItem = Enum.ToObject(elementUnderlying, numeric);
                }
            }

            // Guid elements stored as strings
            else if (elementUnderlying == typeof(Guid) && convertedItem is string guidString)
            {
                convertedItem = Guid.Parse(guidString);
            }

            // int elements coming back as long
            else if (elementUnderlying == typeof(int) && convertedItem is long l)
            {
                convertedItem = (int)l;
            }

            // float elements coming back as double
            else if (elementUnderlying == typeof(float) && convertedItem is double d)
            {
                convertedItem = (float)d;
            }

            addMethod.Invoke(hashSetInstance, [convertedItem]);
        }

        return hashSetInstance;
    }
}