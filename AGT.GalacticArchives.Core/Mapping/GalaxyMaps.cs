using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class GalaxyMaps : Profile
{
    public GalaxyMaps()
    {
        CreateMap<Dictionary<string, object>, Galaxy>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<GalaxyRequest, Data>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<GalaxyRequest, Galaxy>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.GalaxyId, o => o.Ignore())
            ;

        CreateMap<IGameData, GalaxyResponse>()
            ;

        CreateMap<Galaxy, GalaxyResponse>()
            ;
    }
}