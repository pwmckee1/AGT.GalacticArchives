using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Mapping.ValueConverters;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class RegionMaps : Profile
{
    public RegionMaps()
    {
        CreateMap<Dictionary<string, object?>, Region>().ConvertUsing<DatabaseEntityTypeConverter>();

        CreateMap<Dictionary<string, object?>, RegionResponse>().ConvertUsing<DatabaseEntityTypeConverter>();

        CreateMap<RegionImport, Region>()
            .ForMember(d => d.Name, o => o.MapFrom(s => s.RegionName))
            .ForMember(d => d.GalacticQuadrant, o => o.MapFrom(s => s.GalacticQuadrant))
            .ForMember(d => d.GlyphHexCode, o => o.MapFrom<GlyphCodeValueResolver>())
            .ForMember(
                d => d.XXHex,
                o => o.MapFrom<AxisHexValueResolver, string>(src => nameof(StarSystemImport.XXHex)))
            .ForMember(
                d => d.YYHex,
                o => o.MapFrom<AxisHexValueResolver, string>(src => nameof(StarSystemImport.YYHex)))
            .ForMember(
                d => d.ZZHex,
                o => o.MapFrom<AxisHexValueResolver, string>(src => nameof(StarSystemImport.ZZHex)))
            .ForMember(
                d => d.SSHex,
                o => o.MapFrom<AxisHexValueResolver, string>(src => nameof(StarSystemImport.SSHex)))
            .ForMember(
                d => d.XXDec,
                o => o.MapFrom<AxisDecimalValueResolver, string>(src => nameof(StarSystemImport.XXDec)))
            .ForMember(
                d => d.YYDec,
                o => o.MapFrom<AxisDecimalValueResolver, string>(src => nameof(StarSystemImport.YYDec)))
            .ForMember(
                d => d.ZZDec,
                o => o.MapFrom<AxisDecimalValueResolver, string>(src => nameof(StarSystemImport.ZZDec)))
            .ForMember(
                d => d.SSDec,
                o => o.MapFrom<AxisDecimalValueResolver, string>(src => nameof(StarSystemImport.SSDec)))
            .ForMember(d => d.SSHex, o => o.Ignore())
            .ForMember(d => d.SSDec, o => o.Ignore())
            .ForMember(d => d.StarSystems, o => o.Ignore())
            .ForMember(d => d.Region, o => o.Ignore())
            .ForMember(d => d.StarSystemId, o => o.Ignore())
            .ForMember(d => d.StarSystem, o => o.Ignore())
            .ForMember(d => d.PlanetId, o => o.Ignore())
            .ForMember(d => d.Planet, o => o.Ignore())
            .ForMember(d => d.YAxisPlanetCoordinate, o => o.Ignore())
            .ForMember(d => d.XAxisPlanetCoordinate, o => o.Ignore());

        CreateMap<Region, RegionRequest>();
        CreateMap<RegionRequest, Region>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore());

        CreateMap<Region, RegionResponse>();
        CreateMap<RegionResponse, Region>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore());
    }
}