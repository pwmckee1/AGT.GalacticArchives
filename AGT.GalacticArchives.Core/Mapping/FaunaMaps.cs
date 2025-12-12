using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class FaunaMaps : Profile
{
    public FaunaMaps()
    {
        CreateMap<Dictionary<string, object>, Fauna>()
            .ConvertUsing<DatabaseEntityTypeConverter>()
            ;

        CreateMap<Fauna, FaunaRequest>()
            ;
        CreateMap<FaunaRequest, Fauna>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<Fauna, FaunaResponse>()
            ;
        CreateMap<FaunaResponse, Fauna>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;
    }
}