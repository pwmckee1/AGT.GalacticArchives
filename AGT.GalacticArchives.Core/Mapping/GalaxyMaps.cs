using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Environments;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Requests.Environments;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Core.Models.Responses.Environments;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class GalaxyMaps : Profile
{
    public GalaxyMaps()
    {
        CreateMap<Dictionary<string, object>, Galaxy>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<GalaxyRequest, DatabaseEntity>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<GalaxyRequest, Galaxy>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.GalaxyId, o => o.Ignore())
            ;

        CreateMap<IDatabaseEntity, GalaxyResponse>()
            ;

        CreateMap<Galaxy, GalaxyResponse>()
            ;
    }
}