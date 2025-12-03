using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.GameData.BaseEntities;
using AGT.GalacticArchives.Core.Models.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class StarSystemMaps : Profile
{
    public StarSystemMaps()
    {
        CreateMap<Dictionary<string, object?>, StarSystem>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<StarSystemRequest, DatabaseEntity>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<StarSystemRequest, StarSystem>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.StarSystemId, o => o.Ignore())
            ;

        CreateMap<IDatabaseEntity, StarSystemResponse>()
            ;

        CreateMap<StarSystem, StarSystemResponse>()
            ;
    }
}