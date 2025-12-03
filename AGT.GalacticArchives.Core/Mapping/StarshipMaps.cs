using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;
using Starship = AGT.GalacticArchives.Core.Models.GameData.Starship;

namespace AGT.GalacticArchives.Core.Mapping;

public class StarshipMaps : Profile
{
    public StarshipMaps()
    {
        CreateMap<Dictionary<string, object>, Starship>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<StarshipDatabaseEntityRequest, GameDataEntity>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<StarshipDatabaseEntityRequest, Starship>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.StarshipId, o => o.Ignore())
            ;

        CreateMap<Starship, StarshipResponse>()
            ;

        CreateMap<IGameData, StarshipResponse>()
            ;
    }
}