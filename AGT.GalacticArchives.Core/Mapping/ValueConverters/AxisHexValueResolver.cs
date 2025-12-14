using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping.ValueConverters;

public class AxisHexValueResolver : IMemberValueResolver<RegionImport, Region, string, string?>,
    IMemberValueResolver<StarSystemImport, StarSystem, string, string?>
{
    public string? Resolve(
        RegionImport source,
        Region destination,
        string sourceMember,
        string? destMember,
        ResolutionContext context)
    {
        return sourceMember switch
        {
            nameof(RegionImport.XXHex) => source.XXHex.HasValidAxisCoordinates()
                ? source.XXHex!.Trim().ToUpperInvariant()
                : source.GalacticCoordinates.ToXAxisHexValue(),
            nameof(RegionImport.YYHex) => source.YYHex.HasValidAxisCoordinates()
                ? source.YYHex!.Trim().ToUpperInvariant()
                : source.GalacticCoordinates.ToYAxisHexValue(),
            nameof(RegionImport.ZZHex) => source.ZZHex.HasValidAxisCoordinates()
                ? source.ZZHex!.Trim().ToUpperInvariant()
                : source.GalacticCoordinates.ToZAxisHexValue(),

                : source.GalacticCoordinates.ToStarSystemHexValue(),
            _ => null,
        };
    }

    public string? Resolve(
        StarSystemImport source,
        StarSystem destination,
        string sourceMember,
        string? destMember,
        ResolutionContext context)
    {
        return sourceMember switch
        {
            nameof(StarSystemImport.XXHex) => source.XXHex.HasValidAxisCoordinates()
                ? source.XXHex!.Trim().ToUpperInvariant()
                : source.GalacticCoordinates.ToXAxisHexValue(),
            nameof(StarSystemImport.YYHex) => source.YYHex.HasValidAxisCoordinates()
                ? source.YYHex!.Trim().ToUpperInvariant()
                : source.GalacticCoordinates.ToYAxisHexValue(),
            nameof(StarSystemImport.ZZHex) => source.ZZHex.HasValidAxisCoordinates()
                ? source.ZZHex!.Trim().ToUpperInvariant()
                : source.GalacticCoordinates.ToZAxisHexValue(),
            nameof(StarSystemImport.SSHex) => source.SSHex.HasValidAxisCoordinates()
                ? source.SSHex!.Trim().ToUpperInvariant()
                : source.GalacticCoordinates.ToStarSystemHexValue(),
            _ => null,
        };
    }
}