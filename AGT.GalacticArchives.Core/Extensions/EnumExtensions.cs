using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Extensions;

public static class EnumExtensions
{
    extension(string? description)
    {
        public T GetValueFromDescription<T>()
            where T : Enum
        {
            description ??= string.Empty;
            var values = GetValues<T>()
                .Where(v => string.Equals(v.GetDescription(), description, StringComparison.InvariantCultureIgnoreCase))
                .ToHashSet();
            if (values.Count == 0)
            {
                values = GetValues<T>()
                    .Where(v => string.Equals(
                        v.GetDescription().Replace(" ", string.Empty).Replace("-", string.Empty),
                        description,
                        StringComparison.InvariantCultureIgnoreCase))
                    .ToHashSet();
            }

            return values.FirstOrDefault()!;
        }
    }

    // ReSharper disable once ParameterOnlyUsedForPreconditionCheck.Global
    extension<T>(T value)
        where T : Enum
    {
        public void ValidateEnum()
        {
            if ((byte)(object)value == 0)
            {
                string propertyName = typeof(T).Name;
                throw new ArgumentException(
                    propertyName,
                    string.Format(GeneralErrorResource.PropertyMissing, propertyName));
            }
        }
    }

    extension<T>(T? value)
        where T : struct, Enum
    {
        public bool HasValidValue()
        {
            return value.HasValue && value.Value.HasValidValue();
        }
    }

    extension<T>(T value)
        where T : struct, Enum
    {
        public bool HasValidValue()
        {
            return (byte)(object)value > 0;
        }
    }

    extension(string enumStringValue)
    {
        public T? GetValueFromString<T>()
            where T : struct, Enum
        {
            var gameType = GetValues<T>()
                .FirstOrDefault(v => v.ToString().ToLowerInvariant().Equals(enumStringValue.ToLowerInvariant()));

            return gameType.HasValidValue() ? gameType : null;
        }
    }

    public static HashSet<T> GetValues<T>()
        where T : Enum
    {
        return [.. Enum.GetValues(typeof(T)).Cast<T>()];
    }

    public static HashSet<string> GetDescriptions<T>()
        where T : Enum
    {
        return typeof(T)
            .GetFields()
            .Where(f => f.Name != BusinessRuleConstants.ValueFieldName)
            .Select(m => m.GetDescription())
            .ToHashSet(StringComparer.CurrentCultureIgnoreCase);
    }
}