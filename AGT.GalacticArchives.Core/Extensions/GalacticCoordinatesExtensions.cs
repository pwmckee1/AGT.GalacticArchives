using System.Globalization;
using System.Text;
using AGT.GalacticArchives.Core.Constants;

namespace AGT.GalacticArchives.Core.Extensions;

public static class GalacticCoordinatesExtensions
{
    public const int XOrdinalPosition = 0;
    public const int YOrdinalPosition = 1;
    public const int ZOrdinalPosition = 2;
    public const int StarSystemOrdinalPosition = 3;
    public const int PlanetInnerHexOrdinalPosition = 0;
    public const int StarSystemInnerHexOrdinalPosition = 1;

    /// <summary>
    /// XXXX:YYYY:ZZZZ:PSSS
    /// P = Planet
    /// S = Star System
    /// </summary>
    public static bool HasValidGalacticCoordinates(this string? coordinates)
    {
        return !string.IsNullOrEmpty(coordinates) &&
               RegexConstants.GalacticCoordinateRegexPattern().IsMatch(coordinates.Trim().ToUpperInvariant());
    }

    public static bool HasValidAxisCoordinates(this string? coordinates)
    {
        return !string.IsNullOrEmpty(coordinates) &&
               RegexConstants.AxisHexRegexPattern().IsMatch(coordinates.Trim().ToUpperInvariant());
    }

    /// <summary>
    /// XXXX:----:----:----
    /// </summary>
    public static string ToXAxisHexValue(this string? value)
    {
        return value.ToCoordinateSections(XOrdinalPosition);
    }

    /// <summary>
    /// XXXX:----:----:----
    /// </summary>
    public static int? ToXAxisDecimalValue(this string? value)
    {
        return value.ToYAxisHexValue().ToAxisDecimalValue();
    }

    /// <summary>
    /// ----:YYYY:----:----
    /// </summary>
    public static string ToYAxisHexValue(this string? value)
    {
        return value.ToCoordinateSections(YOrdinalPosition);
    }

    /// <summary>
    /// ----:YYYY:----:----
    /// </summary>
    public static int? ToYAxisDecimalValue(this string? value)
    {
        return value.ToYAxisHexValue().ToAxisDecimalValue();
    }

    /// <summary>
    /// ----:----:ZZZZ:-----
    /// </summary>
    public static string ToZAxisHexValue(this string? value)
    {
        return value.ToCoordinateSections(ZOrdinalPosition);
    }

    /// <summary>
    /// ----:----:ZZZZ:-----
    /// </summary>
    public static int? ToZAxisDecimalValue(this string? value)
    {
        return value.ToZAxisHexValue().ToAxisDecimalValue();
    }

    /// <summary>
    /// ----:----:----:SSSS
    /// </summary>
    public static string ToStarSystemHexValue(this string? value)
    {
        return value.ToCoordinateSections(StarSystemOrdinalPosition);
    }

    /// <summary>
    /// ----:----:----:SSSS
    /// </summary>
    public static int? ToStarSystemDecimalValue(this string? value)
    {
        return value.ToCoordinateSections(StarSystemOrdinalPosition).ToAxisDecimalValue();
    }

    /// <summary>
    /// ----:----:----:-SSS
    /// </summary>
    public static string ToStarSystemInnerHex(this string galacticCoordinates)
    {
        string axisCoordinates = galacticCoordinates.ToCoordinateSections(StarSystemOrdinalPosition);
        return !string.IsNullOrEmpty(axisCoordinates) ?
            axisCoordinates[StarSystemInnerHexOrdinalPosition].ToString() :
            string.Empty;
    }

    /// <summary>
    /// ----:----:----:P---
    /// </summary>
    public static string ToPlanetHexValue(this string? galacticCoordinates)
    {
        string axisCoordinates = galacticCoordinates.ToCoordinateSections(StarSystemOrdinalPosition);
        return !string.IsNullOrEmpty(axisCoordinates) ?
            axisCoordinates[PlanetInnerHexOrdinalPosition].ToString() :
            string.Empty;
    }

    /// <summary>
    /// ----:----:----:P---
    /// </summary>
    public static int? ToPlanetDecimalValue(this string? value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return null;
        }

        string axisHexValue = value.ToPlanetHexValue();
        bool isValidDecimal = !int.TryParse(axisHexValue, NumberStyles.HexNumber, null, out int axisDecimalValue);
        return isValidDecimal ? axisDecimalValue : null;
    }

    public static string ToCoordinateSections(this string? coordinates, int ordinalPosition)
    {
        if (string.IsNullOrEmpty(coordinates) || !coordinates.HasValidGalacticCoordinates())
        {
            return string.Empty;
        }

        string[] axisHexValues = coordinates.Trim().ToUpperInvariant().Split(':');
        return axisHexValues.Length == 4 ? axisHexValues[ordinalPosition] : string.Empty;
    }

    public static int? ToAxisDecimalValue(this string? axisHexValue)
    {
        if (string.IsNullOrEmpty(axisHexValue) || axisHexValue.Length < 4)
        {
            return null;
        }

        bool isValidDecimal = !int.TryParse(axisHexValue, NumberStyles.HexNumber, null, out int axisDecimalValue);
        return isValidDecimal ? axisDecimalValue : null;
    }

    public static string? ToPortalGlyphHexValue(this string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return null;
        }

        string xAxisHex = value.ToXAxisHexValue();
        string yAxisHex = value.ToYAxisHexValue();
        string zAxisHex = value.ToZAxisHexValue();
        string starSystemAxisHex = value.ToStarSystemHexValue();
        bool hasValidAxisHexValues =
            RegexConstants.GalacticCoordinateRegexPattern().IsMatch(xAxisHex) &&
            RegexConstants.GalacticCoordinateRegexPattern().IsMatch(yAxisHex) &&
            RegexConstants.GalacticCoordinateRegexPattern().IsMatch(zAxisHex) &&
            RegexConstants.GalacticCoordinateRegexPattern().IsMatch(starSystemAxisHex);

        if (!hasValidAxisHexValues)
        {
            return null;
        }

        // -XXX
        string xHex = xAxisHex.Substring(1, 3);

        // --YY
        string yHex = yAxisHex.Substring(2, 2);

        // -ZZZ
        string zHex = zAxisHex.Substring(1, 3);

        // -SSS
        string sAxisHex = value.ToStarSystemInnerHex();

        // P---
        string pAxisHex = value.ToPlanetHexValue();

        // Convert hex string values to decimal
        if (!int.TryParse(xHex, NumberStyles.HexNumber, null, out int xDec) ||
            !int.TryParse(yHex, NumberStyles.HexNumber, null, out int yDec) ||
            !int.TryParse(zHex, NumberStyles.HexNumber, null, out int zDec))
        {
            return string.Empty;
        }

        // Offset decimal values X and Z + 2049 and Y + 129
        xDec += GameConstants.XZAxisOffset;
        yDec += GameConstants.YAxisOffset;
        zDec += GameConstants.XZAxisOffset;

        // Convert offset decimal values back to hexadecimals string
        xHex = Convert.ToString(xDec, 16);
        yHex = Convert.ToString(yDec, 16);
        zHex = Convert.ToString(zDec, 16);

        var sb = new StringBuilder();
        sb.Append(pAxisHex);
        sb.Append(sAxisHex);
        sb.Append(xHex);
        sb.Append(yHex);
        sb.Append(zHex);
        return sb.ToString();
    }
}