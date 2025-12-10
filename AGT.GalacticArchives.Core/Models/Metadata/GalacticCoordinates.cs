using System.Globalization;
using System.Text;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;

namespace AGT.GalacticArchives.Core.Models.Metadata;

public class GalacticCoordinates
{
    // ReSharper disable once ReplaceWithFieldKeyword
    private string _coordinates = string.Empty;

    /// <summary>
    /// XXXX:YYYY:ZZZZ:PSSS
    /// P = Planet
    /// S = Star System
    /// </summary>
    public string Coordinates
    {
        get => _coordinates;
        set => _coordinates = value.GetValidatedCoordinates();
    }

    /// <summary>
    /// XXXX:----:----:----
    /// </summary>
    public string XAxis => !string.IsNullOrEmpty(Coordinates) ? Coordinates.Split(':')[0] : string.Empty;

    /// <summary>
    /// ----:YYYY:----:----
    /// </summary>
    public string YAxis => !string.IsNullOrEmpty(Coordinates) ? Coordinates.Split(':')[1] : string.Empty;

    /// <summary>
    /// ----:----:ZZZZ:-----
    /// </summary>
    public string ZAxis => !string.IsNullOrEmpty(Coordinates) ? Coordinates.Split(':')[2] : string.Empty;

    /// <summary>
    /// ----:----:----:-SSSS
    /// </summary>
    public string StarSystemHex =>
        !string.IsNullOrEmpty(Coordinates) ? Coordinates.Split(':')[3][1..] : string.Empty;

    /// <summary>
    /// ----:----:----:P---
    /// </summary>
    public string PlanetHex =>
        !string.IsNullOrEmpty(Coordinates) ? Coordinates.Split(':')[3][0].ToString() : string.Empty;

    public string PortalCode()
    {
        if (string.IsNullOrEmpty(Coordinates))
        {
            return string.Empty;
        }

        // -XXX
        string xHex = XAxis.Substring(1, 3);

        // --YY
        string yHex = YAxis.Substring(2, 2);

        // -ZZZ
        string zHex = ZAxis.Substring(1, 3);

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
        sb.Append(PlanetHex);
        sb.Append(StarSystemHex);
        sb.Append(xHex);
        sb.Append(yHex);
        sb.Append(zHex);
        return sb.ToString();
    }
}