using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Mapping.ValueResolvers;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Environments;
using AGT.GalacticArchives.Core.Models.Requests.Environments;
using AGT.GalacticArchives.Core.Models.Responses.Environments;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class StarSystemMaps : Profile
{
    public StarSystemMaps()
    {
        CreateMap<Dictionary<string, object>, StarSystem>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<StarSystemRequest, DatabaseEntity>()
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<StarSystemRequest, StarSystem>()
            ;

        CreateMap<DatabaseEntity, StarSystemResponse>()
            ;

        CreateMap<StarSystem, StarSystemResponse>()
            .ForMember(d => d.RegionId, o => o.MapFrom<GalaxyValueResolver>())
            .ForMember(d => d.Galaxy, o => o.MapFrom<GalaxyValueResolver>())
            ;

        CreateMap<StarSystem, StarSystemResponseEntity>()
            ;
    }
}