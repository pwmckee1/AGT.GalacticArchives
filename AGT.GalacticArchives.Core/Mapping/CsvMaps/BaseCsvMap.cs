using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace AGT.GalacticArchives.Core.Mapping.CsvMaps;

public abstract class BaseCsvMap<T> : ClassMap<T> where T : class
{
    protected virtual TEnum GetEnumValueFromCsvField<TEnum>(string? value, ConvertFromStringArgs m) where TEnum : Enum
    {
        var type = value!.GetValueFromDescription<TEnum>();
        if (int.TryParse(value, out int result) && result == 0)
        {
            throw new InvalidCastException(
                string.Format(GoogleSheetResource.MissingEnumerationValueForType, m.Row.Parser.Row, value, nameof(T)));
        }

        return type;
    }

    protected virtual HashSet<TEnum> GetEnumValuesFromCsvColumns<TEnum>(
        string headerColumnName,
        ConvertFromStringArgs m) where TEnum : Enum
    {
        var results = new HashSet<TEnum>();

        string[]? headerRecord = m.Row.HeaderRecord;
        if (headerRecord != null)
        {
            for (int i = 0; i < headerRecord.Length; i++)
            {
                if (headerRecord[i] == headerColumnName)
                {
                    string? value = m.Row.GetField(i);
                    if (!string.IsNullOrEmpty(value))
                    {
                        var enumValue = GetEnumValueFromCsvField<TEnum>(value, m);
                        results.Add(enumValue);
                    }
                }
            }
        }

        return results;
    }
}