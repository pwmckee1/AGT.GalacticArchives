using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class MultiToolMaps : Profile
{
    public MultiToolMaps()
    {
        CreateMap<Dictionary<string, object?>, MultiTool>()
            .ConvertUsing<DatabaseEntityTypeConverter>()
            ;

        CreateMap<MultiTool, MultiToolRequest>()
            ;
        CreateMap<MultiToolRequest, MultiTool>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<MultiTool, MultiToolResponse>()
            ;
        CreateMap<MultiToolResponse, MultiTool>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;
    }
}