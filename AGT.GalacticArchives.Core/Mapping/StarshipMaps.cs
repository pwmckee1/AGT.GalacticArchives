using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class StarshipMaps : Profile
{
    public StarshipMaps()
    {
        CreateMap<Dictionary<string, object>, Starship>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<Starship, StarshipRequest>()
            ;
        CreateMap<StarshipRequest, Starship>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<Starship, StarshipResponse>()
            ;
        CreateMap<StarshipResponse, Starship>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;
    }
}