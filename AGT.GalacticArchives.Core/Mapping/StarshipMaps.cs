using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses;
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

        CreateMap<StarshipRequest, DatabaseEntity>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<StarshipRequest, Starship>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.StarshipId, o => o.Ignore())
            ;

        CreateMap<IDatabaseEntity, StarshipResponse>()
            ;

        CreateMap<Starship, StarshipResponse>()
            .ForMember(d => d.GalaxyId, o => o.MapFrom(s => s.StarSystem.Region!.GalaxyId))
            ;
    }
}