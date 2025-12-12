using System.Globalization;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
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
        return !string.IsNullOrEmpty(value) && int.TryParse(value, out int result) ? result : null;
    }

    public static float? ReadFloatFieldOrNull(this IReaderRow row, string propertyName)
    {
        string? value = row.GetField(propertyName);
        return !string.IsNullOrEmpty(value) && float.TryParse(value, out float result) ? result : null;
    }

    public static bool? ReadBoolFieldOrNull(this IReaderRow row, string propertyName, string identifier)
    {
        string? value = row.GetField(propertyName);
        return value?.Trim().Equals(identifier, StringComparison.OrdinalIgnoreCase) ?? false;
    }

    public static DateTime? ReadDateTimeFieldOrNull(this IReaderRow row, string propertyName)
    {
        string? value = row.GetField(propertyName);
        return !string.IsNullOrEmpty(value) &&
               DateTime.TryParseExact(
                   value,
                   BusinessRuleConstants.ValidDateTimeFormats,
                   DateTimeFormatInfo.InvariantInfo,
                   DateTimeStyles.None,
                   out var result)
            ? result
            : null;
    }

    public static HashSet<TEnum> ReadEnumFields<TEnum>(this IReaderRow row, string headerColumnName)
        where TEnum : Enum
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
                        var enumValue = row.ReadEnumFieldOrNull<TEnum>(value);
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
    public static T ReadEnumFieldOrDefault<T>(this IReaderRow row, string propertyName, T defaultValue)
        where T : Enum
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
    public static T? ReadEnumFieldOrNull<T>(this IReaderRow row, string propertyName)
        where T : Enum
    {
        row.TryGetField(propertyName, out string? value);
        var enumValue = value.GetValueFromDescription<T>();
        return (int)(object)enumValue > 0 ? enumValue : default;
    }

    public static TEnum? ReadNullableEnumField<TEnum>(this IReaderRow row, string propertyName) where TEnum : Enum
    {
        row.TryGetField(propertyName, out string? value);
        return !string.IsNullOrEmpty(value) ? row.ReadEnumFieldOrNull<TEnum>(propertyName) : default;
    }

    public static HashSet<HarvestedMaterialType> ReadHarvestedMaterialFields(this IReaderRow row, string propertyName)
    {
        var baseMaterial = row.ReadEnumFields<BaseMaterialTypes>(propertyName)
            .Select(m => new HarvestedBaseMaterialType(m))
            .ToHashSet();
        var exoticMaterialTypes = row.ReadEnumFields<ExoticMaterialTypes>(propertyName)
            .Select(m => new HarvestedExoticMaterialType(m))
            .ToHashSet();
        var uniqueMaterialTypes = row.ReadEnumFields<UniqueMaterialTypes>(propertyName)
            .Select(m => new HarvestedUniqueMaterialType(m))
            .ToHashSet();
        var atmosphereMaterial = row.ReadEnumFields<AtmosphereMaterialTypes>(propertyName)
            .Select(m => new HarvestedAtmosphereMaterialType(m))
            .ToHashSet();
        var edibleMaterial = row.ReadEnumFields<EdibleMaterialTypes>(propertyName)
            .Select(m => new HarvestedEdibleMaterialType(m))
            .ToHashSet();
        var glitchMaterial = row.ReadEnumFields<GlitchMaterialTypes>(propertyName)
            .Select(m => new HarvestedGlitchMaterialType(m))
            .ToHashSet();

        var results = new HashSet<HarvestedMaterialType>();
        foreach (var baseMaterialType in baseMaterial)
        {
            results.Add(baseMaterialType);
        }

        results.UnionWith(exoticMaterialTypes);
        results.UnionWith(uniqueMaterialTypes);
        results.UnionWith(atmosphereMaterial);
        results.UnionWith(edibleMaterial);
        results.UnionWith(glitchMaterial);
        return results;
    }

    public static HarvestedMaterialType? ReadHarvestedMaterialField(this IReaderRow row, string propertyName)
    {
        var baseMaterial =
            row.ReadNullableEnumField<BaseMaterialTypes>(propertyName)
                as BaseMaterialTypes?;
        var exoticMaterial =
            row.ReadNullableEnumField<ExoticMaterialTypes>(propertyName)
                as ExoticMaterialTypes?;
        var uniqueMaterial =
            row.ReadNullableEnumField<UniqueMaterialTypes>(propertyName)
                as UniqueMaterialTypes?;
        var atmosphereMaterial =
            row.ReadNullableEnumField<AtmosphereMaterialTypes>(propertyName)
                as AtmosphereMaterialTypes?;
        var edibleMaterial =
            row.ReadNullableEnumField<EdibleMaterialTypes>(propertyName)
                as EdibleMaterialTypes?;
        var glitchMaterial =
            row.ReadNullableEnumField<GlitchMaterialTypes>(propertyName)
                as GlitchMaterialTypes?;

        if (baseMaterial != null)
        {
            return new HarvestedBaseMaterialType(baseMaterial.Value);
        }

        if (exoticMaterial != null)
        {
            return new HarvestedExoticMaterialType(exoticMaterial.Value);
        }

        if (uniqueMaterial != null)
        {
            return new HarvestedUniqueMaterialType(uniqueMaterial.Value);
        }

        if (atmosphereMaterial != null)
        {
            return new HarvestedAtmosphereMaterialType(atmosphereMaterial.Value);
        }

        if (edibleMaterial != null)
        {
            return new HarvestedEdibleMaterialType(edibleMaterial.Value);
        }

        return glitchMaterial != null ? new HarvestedGlitchMaterialType(glitchMaterial.Value) : null;
    }

    /// <summary>
    /// Reads a delimited CSV cell into a HashSet<string></string>, removing empty entries.
    /// </summary>
    /// <param name="row"></param>
    /// <param name="propertyName"></param>
    /// <param name="delimiters"></param>
    /// <returns></returns>
    public static HashSet<string> ReadDelimitedField(this IReaderRow row, string propertyName, params string[] delimiters)
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