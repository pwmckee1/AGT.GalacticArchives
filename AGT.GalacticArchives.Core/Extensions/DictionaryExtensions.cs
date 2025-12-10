using System.Reflection;
using System.Runtime.CompilerServices;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models;
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

    public static T ConvertDictionaryToObject<T>(this Dictionary<string, object>? originalData)
        where T : IDatabaseGameEntity
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
                // Handle type conversions
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
                        value.GetType().Name,
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

        // If types match, return it
        if (targetType.IsInstanceOfType(value))
        {
            return value;
        }

        // Handle nullable types
        var underlyingType = Nullable.GetUnderlyingType(targetType) ?? targetType;

        // Handle string conversions (from/to Guid, etc.)
        if (value is string stringValue && underlyingType == typeof(Guid))
        {
            return Guid.Parse(stringValue);
        }

        // Handle explicit conversions
        if (underlyingType.IsInstanceOfType(value))
        {
            return value;
        }

        // Handle IEnumerable conversions - convert List to HashSet if needed
        if (typeof(System.Collections.IEnumerable).IsAssignableFrom(underlyingType) && underlyingType.IsGenericType)
        {
            object? hashSet = ConvertEnumerableToHashSet(value, underlyingType);
            return hashSet;
        }

        // Convert.ChangeType for primitives
        if (underlyingType.IsPrimitive || underlyingType == typeof(decimal))
        {
            return Convert.ChangeType(value, underlyingType);
        }

        throw new InvalidCastException(
            string.Format(GeneralErrorResource.CannotConvertValue, value.GetType().Name, targetType.Name));
    }

    // Force IEnumerable<T> vales to be HashSet<T> otherwise they will default as List<T>
    private static object? ConvertEnumerableToHashSet(object value, Type underlyingType)
    {
        var genericArgs = underlyingType.GetGenericArguments();
        if (genericArgs.Length > 0 &&
            value is System.Collections.IEnumerable enumerable &&
            underlyingType.GetGenericTypeDefinition() == typeof(HashSet<>))
        {
            // If target is HashSet, convert from List or other IEnumerable
            var elementType = genericArgs[0];
            var hashSetType = typeof(HashSet<>).MakeGenericType(elementType);
            var hashSetInstance = (System.Collections.IEnumerable)Activator.CreateInstance(hashSetType)!;

            var addMethod = hashSetType.GetMethod(nameof(HashSet<>.Add), [elementType]);
            foreach (object? item in enumerable)
            {
                addMethod?.Invoke(hashSetInstance, [item]);
            }

            return hashSetInstance;
        }

        return null;
    }
}