using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Environments;
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

        CreateMap<Galaxy, GalaxyRequest>()
            ;
        CreateMap<GalaxyRequest, Galaxy>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<Galaxy, GalaxyResponse>()
            ;
        CreateMap<GalaxyResponse, Galaxy>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;
    }
}