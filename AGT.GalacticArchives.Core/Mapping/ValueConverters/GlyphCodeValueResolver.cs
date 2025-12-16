using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping.ValueConverters;

public class GlyphCodeValueResolver : IValueResolver<RegionImport, Region, string?>,
    IValueResolver<StarSystemImport, StarSystem, string?>
{
    public string? Resolve(RegionImport source, Region destination, string? destMember, ResolutionContext context)
    {
        return ResolveGlyphHexValue(source.GlyphHexCode, source.GalacticCoordinates);
    }

    public string? Resolve(
        StarSystemImport source,
        StarSystem destination,
        string? destMember,
        ResolutionContext context)
    {
        return ResolveGlyphHexValue(source.GlyphHexCode, source.GalacticCoordinates);
    }

    public string? Resolve(StarshipImport source, Starship destination, string? destMember, ResolutionContext context)
    {
        return ResolveGlyphHexValue(source.GlyphHexCode, source.GalacticCoordinates);
    }

    private static string? ResolveGlyphHexValue(string? glyphHexCode, string? galacticCoordinates)
    {
        if (string.IsNullOrEmpty(glyphHexCode) && string.IsNullOrEmpty(galacticCoordinates))
        {
            return null;
        }

        string? glyphCode = string.IsNullOrEmpty(glyphHexCode)
            ? galacticCoordinates!.ToPortalGlyphHexValue()
            : glyphHexCode;
        return glyphCode;
    }
}