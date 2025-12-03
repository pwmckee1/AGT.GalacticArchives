using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Core.Models.Responses.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class MultiToolMaps : Profile
{
    public MultiToolMaps()
    {
        CreateMap<Dictionary<string, object>, MultiTool>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<MultiToolRequest, DatabaseEntity>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<MultiToolRequest, MultiTool>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.MultiToolId, o => o.Ignore())
            ;

        CreateMap<IDatabaseEntity, MultiToolResponse>()
            ;

        CreateMap<MultiTool, MultiToolResponse>()
            ;
    }
}