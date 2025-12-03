using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Mapping.ValueResolvers;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Environments;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Requests.Environments;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Core.Models.Responses.Environments;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class RegionMaps : Profile
{
    public RegionMaps()
    {
        CreateMap<Dictionary<string, object>, Region>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<RegionRequest, DatabaseEntity>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<RegionRequest, Region>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.RegionId, o => o.Ignore())
            ;

        CreateMap<IDatabaseEntity, RegionResponse>()
            ;

        CreateMap<Region, RegionResponse>()
            .ForMember(d => d.GalaxyId, o => o.MapFrom<GalaxyValueResolver>())
            .ForMember(d => d.Galaxy, o => o.MapFrom<GalaxyValueResolver>())
            ;

        CreateMap<Region, RegionResponseEntity>()
            ;
    }
}