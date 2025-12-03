using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;
using AutoMapper;
using Starship = AGT.GalacticArchives.Core.Models.Entities.Starship;

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
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<Starship, StarshipResponse>()
            ;
        CreateMap<StarshipResponse, Starship>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;
    }
}