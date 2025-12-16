using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Extensions;

public static class StringExtensions
{
    public static string GetValidatedCoordinates(this string? coordinates)
    {
        if (string.IsNullOrEmpty(coordinates))
        {
            return coordinates ?? string.Empty;
        }

        string normalizedCoordinates = coordinates.ToUpperInvariant();
        if (!RegexConstants.GalacticCoordinateRegexPattern().IsMatch(normalizedCoordinates))
        {
            throw new ArgumentException(
                GeneralErrorResource.CoordinatesMustMatchPattern,
                coordinates);
        }

        return normalizedCoordinates;
    }
}