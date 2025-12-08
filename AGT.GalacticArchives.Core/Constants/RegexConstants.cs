using System.Text.RegularExpressions;

namespace AGT.GalacticArchives.Core.Constants;

public static partial class RegexConstants
{
    [GeneratedRegex(@"^[0-9A-F]{4}$", RegexOptions.IgnoreCase)]
    public static partial Regex HexadecimalDigitRegexPattern();

    [GeneratedRegex(@"^[0-9A-F]{4}:[0-9A-F]{4}:[0-9A-F]{4}$", RegexOptions.IgnoreCase)]
    public static partial Regex BaseCoordinateRegexPattern();

    [GeneratedRegex(@"^[0-9A-F]{4}:[0-9A-F]{4}:[0-9A-F]{4}:[0-9A-FX]{4}$", RegexOptions.IgnoreCase)]
    public static partial Regex GalacticCoordinateRegexPattern();

    [GeneratedRegex(@"^[0-9A-FX]{12}$", RegexOptions.IgnoreCase)]
    public static partial Regex GlyphHexadecimalRegexPattern();
}