using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Extensions;

public static class EnumExtensions
    {
        public static HashSet<T> GetValues<T>()
            where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToHashSet();
        }

        public static HashSet<string> GetDescriptions<T>()
            where T : Enum
        {
            return typeof(T).GetFields()
                .Where(f => f.Name != BusinessRuleConstants.ValueFieldName)
                .Select(m => m.GetDescription())
                .ToHashSet(StringComparer.CurrentCultureIgnoreCase);
        }

        public static T GetValueFromDescription<T>(this string? description)
            where T : Enum
        {
            description ??= string.Empty;
            var values = GetValues<T>()
                .Where(v =>
                    string.Equals(v.GetDescription(), description, StringComparison.InvariantCultureIgnoreCase)).ToHashSet();
            if (values.Count == 0)
            {
                values = GetValues<T>()
                    .Where(v =>
                        string.Equals(v.GetDescription().Replace(" ", string.Empty).Replace("-", string.Empty), description, StringComparison.InvariantCultureIgnoreCase)).ToHashSet();
            }

            return values.FirstOrDefault()!;
        }

        // ReSharper disable once ParameterOnlyUsedForPreconditionCheck.Global
        public static void ValidateEnum<T>(this T value)
            where T : Enum
        {
            if ((byte)(object)value == 0)
            {
                var propertyName = typeof(T).Name;
                throw new ArgumentException(propertyName, string.Format(GeneralErrorResource.PropertyMissing, propertyName));
            }
        }

        public static bool HasValidValue<T>(this T? value)
            where T : struct, Enum
        {
            return value.HasValue && value.Value.HasValidValue();
        }

        public static bool HasValidValue<T>(this T value)
            where T : struct, Enum
        {
            return (byte)(object)value > 0;
        }

        public static T? GetValueFromString<T>(this string enumStringValue)
            where T : struct, Enum
        {
            var gameType = GetValues<T>()
                .FirstOrDefault(v => v.ToString().ToLowerInvariant().Equals(enumStringValue.ToLowerInvariant()));

            return gameType.HasValidValue() ? gameType : null;
        }
    }