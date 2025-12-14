using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Mapping.ValueConverters;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class StarSystemMaps : Profile
{
    public StarSystemMaps()
    {
        CreateMap<Dictionary<string, object?>, StarSystem>().ConvertUsing<DatabaseEntityTypeConverter>();

        CreateMap<StarSystemImport, StarSystem>()
            .ForMember(d => d.Name, o => o.MapFrom(s => s.StarSystemName))
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
            .ForMember(d => d.RegionId, o => o.Ignore())
            .ForMember(d => d.Region, o => o.Ignore())
            .ForMember(d => d.StarSystem, o => o.Ignore())
            .ForMember(d => d.PlanetId, o => o.Ignore())
            .ForMember(d => d.Planet, o => o.Ignore())
            .ForMember(d => d.YAxisPlanetCoordinate, o => o.Ignore())
            .ForMember(d => d.XAxisPlanetCoordinate, o => o.Ignore());

        CreateMap<StarSystem, StarSystemRequest>();

        CreateMap<StarSystemRequest, StarSystem>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore());

        CreateMap<StarSystem, StarSystemResponse>();

        CreateMap<StarSystemResponse, StarSystem>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore());
    }
}