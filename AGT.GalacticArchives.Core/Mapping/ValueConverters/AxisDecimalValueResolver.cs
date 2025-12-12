using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping.ValueConverters;

public class AxisDecimalValueResolver : IMemberValueResolver<RegionImport, Region, string, int?>,
    IMemberValueResolver<StarSystemImport, StarSystem, string, int?>
{
    public int? Resolve(
        RegionImport source,
        Region destination,
        string sourceMember,
        int? destMember,
        ResolutionContext context)
    {
        return sourceMember switch
        {
            nameof(RegionImport.XXDec) when source.XXDec != null => source.XXDec,
            nameof(RegionImport.YYDec) when source.YYDec != null => source.YYDec,
            nameof(RegionImport.YYDec) when source.ZZDec != null => source.ZZDec,
            _ => sourceMember switch
            {
                nameof(RegionImport.XXDec) => source.XXHex.HasValidAxisCoordinates()
                    ? source.XXHex.ToAxisDecimalValue()
                    : source.GalacticCoordinates.ToXAxisDecimalValue(),
                nameof(RegionImport.YYDec) => source.YYHex.HasValidAxisCoordinates()
                    ? source.YYHex.ToAxisDecimalValue()
                    : source.GalacticCoordinates.ToYAxisDecimalValue(),
                nameof(RegionImport.ZZDec) => source.ZZHex.HasValidAxisCoordinates()
                    ? source.ZZHex.ToAxisDecimalValue()
                    : source.GalacticCoordinates.ToZAxisDecimalValue(),
                _ => null,
            },
        };
    }

    public int? Resolve(
        StarSystemImport source,
        StarSystem destination,
        string sourceMember,
        int? destMember,
        ResolutionContext context)
    {
        return sourceMember switch
        {
            nameof(StarSystemImport.XXDec) when source.XXDec != null => source.XXDec,
            nameof(StarSystemImport.YYDec) when source.YYDec != null => source.YYDec,
            nameof(StarSystemImport.YYDec) when source.ZZDec != null => source.ZZDec,
            nameof(StarSystemImport.SSDec) when source.SSDec != null => source.SSDec,
            _ => sourceMember switch
            {
                nameof(StarSystemImport.XXDec) => source.GalacticCoordinates.HasValidGalacticCoordinates()
                    ? source.GalacticCoordinates.ToXAxisDecimalValue()
                    : null,
                nameof(StarSystemImport.YYDec) => source.GalacticCoordinates.HasValidGalacticCoordinates()
                    ? source.GalacticCoordinates.ToYAxisDecimalValue()
                    : null,
                nameof(StarSystemImport.ZZDec) => source.GalacticCoordinates.HasValidGalacticCoordinates()
                    ? source.GalacticCoordinates.ToZAxisDecimalValue()
                    : null,
                nameof(StarSystemImport.SSDec) => source.GalacticCoordinates.HasValidGalacticCoordinates()
                    ? source.GalacticCoordinates.ToStarSystemDecimalValue()
                    : null,
                _ => null,
            },
        };
    }
}