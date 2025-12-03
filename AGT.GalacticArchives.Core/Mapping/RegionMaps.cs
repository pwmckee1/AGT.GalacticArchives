using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class RegionMaps : Profile
{
    public RegionMaps()
    {
        CreateMap<Dictionary<string, object>, Region>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<RegionRequest, GameDataEntity>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<RegionRequest, Region>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.RegionId, o => o.Ignore())
            ;

        CreateMap<Region, RegionResponse>()
            ;

        CreateMap<IGameData, RegionResponse>()
            ;
    }
}