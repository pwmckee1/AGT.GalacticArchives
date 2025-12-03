using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class FaunaMaps : Profile
{
    public FaunaMaps()
    {
        CreateMap<Dictionary<string, object>, Fauna>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<FaunaRequest, GameDataEntity>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<FaunaRequest, Fauna>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.FaunaId, o => o.Ignore())
            ;

        CreateMap<IGameData, FaunaResponse>()
            ;

        CreateMap<Fauna, FaunaResponse>()
            ;
    }
}