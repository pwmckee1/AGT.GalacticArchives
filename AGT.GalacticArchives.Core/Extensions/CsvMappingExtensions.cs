using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Globalization;
using CsvHelper;

namespace AGT.GalacticArchives.Core.Extensions;

public static class CsvMappingExtensions
{
    public static string ValidateRequiredField(this string field, string propertyName, string fileName, int rowNumber)
    {
        bool isValid = !string.IsNullOrWhiteSpace(field);
        if (!isValid)
        {
            throw new ArgumentException(
                string.Format(ImportResource.RequiredFieldEmpty, rowNumber, fileName, propertyName));
        }

        return field;
    }

    /// <summary>
    /// Reads and validates CSV cell for standard string max length.
    /// </summary>
    /// <param name="field"></param>
    /// <param name="propertyName"></param>
    /// <param name="fileName"></param>
    /// <param name="rowNumber"></param>
    /// <returns></returns>
    public static string ValidateMaxLength(this string field, string propertyName, string fileName, int rowNumber)
    {
        return field.ValidateMaxLength(
            propertyName,
            fileName,
            rowNumber,
            BusinessRuleConstants.MaxLengthStandardString);
    }

    public static int? ReadIntFieldOrNull(this IReaderRow row, string propertyName)
    {
        string? value = row.GetField(propertyName);
        string formattedValue = !string.IsNullOrEmpty(value) ? value.Replace(",", string.Empty) : string.Empty;
        return int.TryParse(formattedValue, out int result) ? result : null;
    }

    public static Guid? ReadGuidFieldOrNull(this IReaderRow row, string propertyName)
    {
        string? value = row.GetField(propertyName);
        return Guid.TryParse(value, out var result) ? result : null;
    }

    public static float? ReadFloatFieldOrNull(this IReaderRow row, string propertyName)
    {
        string? value = row.GetField(propertyName);
        string formattedValue = !string.IsNullOrEmpty(value) ? value.Replace(",", string.Empty) : string.Empty;
        return float.TryParse(formattedValue, out float result) ? result : null;
    }

    public static bool? ReadBoolFieldOrNull(this IReaderRow row, string propertyName, string identifier)
    {
        string? value = row.GetField(propertyName);
        return value?.Trim().Equals(identifier, StringComparison.OrdinalIgnoreCase) ?? false;
    }

    public static DateTimeOffset? ReadDateTimeOffsetFieldOrNull(this IReaderRow row, string propertyName)
    {
        string? value = row.GetField(propertyName);
#pragma warning disable S6580 // Use a format provider when parsing date and time.
        return !string.IsNullOrEmpty(value) && DateTimeOffset.TryParse(value, out DateTimeOffset result)
            ? result
            : null;
#pragma warning restore S6580 // Use a format provider when parsing date and time.
    }

    public static HashSet<TEnum> ReadEnumFields<TEnum>(this IReaderRow row, string headerColumnName) where TEnum : Enum
    {
        var results = new HashSet<TEnum>();

        string[]? headerRecord = row.HeaderRecord;
        if (headerRecord != null)
        {
            for (int i = 0; i < headerRecord.Length; i++)
            {
                if (headerRecord[i].Contains(headerColumnName))
                {
                    string? value = row.GetField(i);
                    value = value?.Trim();
                    if (!string.IsNullOrEmpty(value))
                    {
                        var enumValue = value.GetValueFromDescription<TEnum>();
                        if (enumValue != null)
                        {
                            results.Add(enumValue);
                        }
                    }
                }
            }
        }

        return results;
    }

    /// <summary>
    /// Reads and validates CSV cell to Enum type. First enum value should start at index of 1.
    /// </summary>
    /// <typeparam name="T">typeof any Enum</typeparam>
    /// <param name="row"></param>
    /// <param name="propertyName"></param>
    /// <returns></returns>
    public static T ReadAndValidateEnumField<T>(this IReaderRow row, string propertyName) where T : struct, Enum
    {
        row.TryGetField(propertyName, out string? value);

        var enumValue = Enum.TryParse(value, out T enumName) ? enumName : value.GetValueFromDescription<T>();

        return (int)(object)enumValue == 0
            ? throw new ArgumentException(
                string.Format(ImportResource.MissingEnumerationValueForType, row.ColumnCount, value, propertyName))
            : enumValue;
    }

    /// <summary>
    /// Reads CSV and default to the specified value if parsed value is out of range. First enum value should start at index of 1.
    /// </summary>
    /// <typeparam name="T">typeof any Enum</typeparam>
    /// <param name="row"></param>
    /// <param name="propertyName"></param>
    /// <param name="defaultValue"></param>
    /// <returns></returns>
    public static T ReadEnumFieldOrDefault<T>(this IReaderRow row, string propertyName, T defaultValue) where T : Enum
    {
        row.TryGetField(propertyName, out string? value);
        var enumValue = value.GetValueFromDescription<T>();
        return (int)(object)enumValue > 0 ? enumValue : defaultValue;
    }

    /// <summary>
    /// Reads CSV and default to the specified value if parsed value is out of range. First enum value should start at index of 1.
    /// </summary>
    /// <typeparam name="T">typeof any Enum</typeparam>
    /// <param name="row"></param>
    /// <param name="propertyName"></param>
    /// <returns></returns>
    public static T? ReadEnumFieldOrNull<T>(this IReaderRow row, string propertyName) where T : struct, Enum
    {
        row.TryGetField(propertyName, out string? value);

        value = value?.Trim();
        if (string.IsNullOrEmpty(value))
        {
            return null;
        }

        var enumValue = value.GetValueFromDescription<T>();
        return (int)(object)enumValue > 0 ? enumValue : null;
    }

    public static TEnum? ReadNullableEnumField<TEnum>(this IReaderRow row, string propertyName)
        where TEnum : struct, Enum
    {
        row.TryGetField(propertyName, out string? value);
        return !string.IsNullOrEmpty(value) ? row.ReadEnumFieldOrNull<TEnum>(propertyName) : null;
    }

    /// <summary>
    /// Reads a delimited CSV cell into a HashSet<string></string>, removing empty entries.
    /// </summary>
    /// <param name="row"></param>
    /// <param name="propertyName"></param>
    /// <param name="delimiters"></param>
    /// <returns></returns>
    public static HashSet<string> ReadDelimitedField(
        this IReaderRow row,
        string propertyName,
        params string[] delimiters)
    {
        var entries = new HashSet<string>();
        row.TryGetField(propertyName, out string? value);

        if (!string.IsNullOrWhiteSpace(value))
        {
            entries = value
                .Trim()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToHashSet();
        }

        return entries;
    }

    private static string ValidateMaxLength(
        this string field,
        string propertyName,
        string fileName,
        int rowNumber,
        int maxLength)
    {
        if (field != null && field.Length > maxLength)
        {
            throw new ArgumentException(string.Format(ImportResource.LengthTooLong, rowNumber, fileName, propertyName));
        }

        return field!;
    }
}