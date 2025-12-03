using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class SettlementMaps : Profile
{
    public SettlementMaps()
    {
        CreateMap<Dictionary<string, object>, Settlement>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<SettlementRequest, GameDataEntity>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<SettlementRequest, Settlement>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.SettlementId, o => o.Ignore())
            ;

        CreateMap<Settlement, SettlementResponse>()
            ;

        CreateMap<IGameData, SettlementResponse>()
            ;
    }
}