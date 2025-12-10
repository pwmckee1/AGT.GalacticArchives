using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class RegionMaps : Profile
{
    public RegionMaps()
    {
        CreateMap<Dictionary<string, object>, Region>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<Region, RegionRequest>()
            ;
        CreateMap<RegionRequest, Region>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<Region, RegionResponse>()
            ;
        CreateMap<RegionResponse, Region>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;
    }
}