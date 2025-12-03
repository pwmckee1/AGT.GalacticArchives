using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class FaunaMaps : Profile
{
    public FaunaMaps()
    {
        CreateMap<Dictionary<string, object>, Fauna>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<Fauna, FaunaRequest>()
            ;
        CreateMap<FaunaRequest, Fauna>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<Fauna, FaunaResponse>()
            ;
        CreateMap<FaunaResponse, Fauna>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;
    }
}