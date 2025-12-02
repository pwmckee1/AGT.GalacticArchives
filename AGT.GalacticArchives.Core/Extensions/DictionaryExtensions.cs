using System.Reflection;
using System.Runtime.CompilerServices;
using AGT.GalacticArchives.Globalization;
using Newtonsoft.Json;

namespace AGT.GalacticArchives.Core.Extensions;

public static class DictionaryExtensions
{
    public static bool HasAnyChanges(this Dictionary<string, object?> first, Dictionary<string, object?> second)
    {
        if (first.Count == 0 && second.Count == 0)
            return false;

        if (first.Count == 0 || second.Count == 0)
            return true;

        string firstJson = JsonConvert.SerializeObject(first, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
        });

        string secondJson = JsonConvert.SerializeObject(second, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
        });

        return firstJson != secondJson;
    }

    public static T ConvertDictionaryToObject<T>(this Dictionary<string, object> source) where T : class
    {
        var instance = (T)RuntimeHelpers.GetUninitializedObject(typeof(T));
        var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);

        foreach (var property in properties)
        {
            if (!property.CanWrite) continue;

            // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
            if (!source.TryGetValue(property.Name, out object? value) || value == null) continue;

            try
            {
                // Handle type conversions
                object? convertedValue = ConvertValue(value, property.PropertyType);
                property.SetValue(instance, convertedValue);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(string.Format(GeneralErrorResource.FailedToConvertProperty,
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
        if (value == null) return null;

        // If types match, return it
        if (targetType.IsInstanceOfType(value)) return value;

        // Handle nullable types
        var underlyingType = Nullable.GetUnderlyingType(targetType) ?? targetType;

        // Handle string conversions (from/to Guid, etc.)
        if (value is string stringValue)
            if (underlyingType == typeof(Guid))
                return Guid.Parse(stringValue);

        // Handle explicit conversions
        if (underlyingType.IsAssignableFrom(value.GetType())) return value;

        // Convert.ChangeType for primitives
        if (underlyingType.IsPrimitive || underlyingType == typeof(decimal))
            return Convert.ChangeType(value, underlyingType);

        throw new InvalidCastException(
            string.Format(GeneralErrorResource.CannotConvertValue, value.GetType().Name, targetType.Name));
    }
}