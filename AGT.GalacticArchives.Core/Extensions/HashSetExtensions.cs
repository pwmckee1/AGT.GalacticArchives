using System.Collections;

namespace AGT.GalacticArchives.Core.Extensions;

public static class HashSetExtensions
{
    public static object? ConvertEnumerableToHashSet(this object value, Type hashSetType)
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

            convertedItem = convertedItem.NormalizeFirestoreValue();

            // Enum elements stored as strings (preferred) or numeric (legacy)
            if (elementUnderlying.IsEnum)
            {
                if (convertedItem is string s)
                {
                    convertedItem = Enum.Parse(elementUnderlying, s, true);
                }
                else if (convertedItem != null)
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