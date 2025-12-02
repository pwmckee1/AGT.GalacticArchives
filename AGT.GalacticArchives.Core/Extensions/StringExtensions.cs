using System.Text.RegularExpressions;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Extensions;

public static partial class StringExtensions
{
    private static readonly Regex CoordinatesPattern = CoordinateRegexPattern();

    [GeneratedRegex(@"^[0-9A-F]{4}:[0-9A-F]{4}:[0-9A-F]{4}:[0-9A-F|XXXX]{4}$", RegexOptions.IgnoreCase, "en-US")]
    private static partial Regex CoordinateRegexPattern();

    public static string GetValidatedCoordinates(this string? coordinates)
    {
        if (string.IsNullOrEmpty(coordinates)) return coordinates ?? string.Empty;

        string normalizedCoordinates = coordinates.ToUpperInvariant();
        if (!CoordinatesPattern.IsMatch(normalizedCoordinates))
            throw new ArgumentException(
                GeneralErrorResource.CoordinatesMustMatchPattern,
                nameof(coordinates));

        return normalizedCoordinates;
    }
}