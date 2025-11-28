using System.Text.Json;
using System.Text.Json.Serialization;
using AGT.GalacticArchives.Core.Extensions;

namespace AGT.GalacticArchives.Core.Attributes;

public class DisplayAttributeEnumConverter : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert.IsEnum;
    }

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var converterType = typeof(DisplayAttributeEnumConverterInner<>).MakeGenericType(typeToConvert);
        return (JsonConverter)Activator.CreateInstance(converterType)!;
    }

    private class DisplayAttributeEnumConverterInner<T> : JsonConverter<T> where T : struct, Enum
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();

            if (string.IsNullOrEmpty(value))
                throw new JsonException($"Empty string is not a valid value for {typeToConvert.Name}");

            // Try exact enum name match first
            if (Enum.TryParse<T>(value, ignoreCase: true, out var result))
                return result;

            // Try Display attribute description match using your extension
            var fromDescription = value.GetValueFromDescription<T>();
            if (fromDescription.HasValidValue())
                return fromDescription;

            throw new JsonException($"'{value}' is not a valid value for {typeToConvert.Name}");
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}