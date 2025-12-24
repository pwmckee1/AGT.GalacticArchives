using System.Collections;
using System.Reflection;

namespace AGT.GalacticArchives.Core.Extensions;

public static class FirestoreExtensions
{
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
    public static object? NormalizeFirestoreValue(this object value)
    {
        switch (value)
        {
            // Handle Newtonsoft.JSON types if they leaked into the dictionary
            case Newtonsoft.Json.Linq.JValue jValue:
                return jValue.Value;

            case Newtonsoft.Json.Linq.JObject jObject:
            {
                // If it's an empty JObject {}, treat it as null for primitive targets
                return !jObject.HasValues ? null : jObject.ToObject<Dictionary<string, object?>>();
            }

            // Firestore "map" often comes back as Dictionary<string, object>
            case IDictionary<string, object> map:
            {
                var normalized = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);
                foreach (var kvp in map)
                {
                    normalized[kvp.Key] = kvp.Value.NormalizeFirestoreValue();
                }

                return normalized;
            }

            // Firestore "array" often comes back as List<object>
            case IList list when value is not string:
            {
                var normalizedList = new List<object?>(list.Count);
                foreach (object? item in list)
                {
                    normalizedList.Add(item?.NormalizeFirestoreValue());
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
}