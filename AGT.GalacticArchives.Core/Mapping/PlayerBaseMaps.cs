using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class PlayerBaseMaps : Profile
{
    public PlayerBaseMaps()
    {
        CreateMap<Dictionary<string, object>, PlayerBase>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<PlayerBaseRequest, GameDataEntity>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<PlayerBaseRequest, PlayerBase>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.PlayerBaseId, o => o.Ignore())
            ;

        CreateMap<PlayerBase, PlayerBaseResponse>()
            ;

        CreateMap<IGameData, PlayerBaseResponse>()
            ;
    }
}