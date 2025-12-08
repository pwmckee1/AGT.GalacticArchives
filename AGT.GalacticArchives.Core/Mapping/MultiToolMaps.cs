using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.DatabaseEntities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
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

        CreateMap<MultiTool, MultiToolRequest>()
            ;
        CreateMap<MultiToolRequest, MultiTool>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<MultiTool, MultiToolResponse>()
            ;
        CreateMap<MultiToolResponse, MultiTool>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;
    }
}