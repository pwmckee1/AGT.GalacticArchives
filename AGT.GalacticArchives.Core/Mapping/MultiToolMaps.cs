namespace AGT.GalacticArchives.Core.Mapping;

using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

public class MultiToolMaps : Profile
{
    public MultiToolMaps()
    {
        CreateMap<Dictionary<string, object>, MultiTool>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<MultiToolRequest, GameDataEntity>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<MultiToolRequest, MultiTool>()
            .ForMember(d => d.MultiToolId, o => o.Ignore())
            ;

        CreateMap<IGameData, MultiToolResponse>()
            ;

        CreateMap<MultiTool, MultiToolResponse>()
            ;
    }
}