using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Mapping.TypeConverters;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Mapping;

public class GameDataMaps : Profile
{
    public GameDataMaps()
    {
        CreateMap<Dictionary<string, object?>, Galaxy>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<Dictionary<string, object>, Region>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<Dictionary<string, object>, StarSystem>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<Dictionary<string, object>, PlayerBase>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<Dictionary<string, object>, Fauna>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<Dictionary<string, object>, MultiTool>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<Dictionary<string, object>, PointOfInterest>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<Dictionary<string, object>, StarSystem>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<Dictionary<string, object>, Starship>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<GalaxyRequest, GameData>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<GalaxyRequest, Galaxy>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<Galaxy, GalaxyResponse>()
            ;

        CreateMap<FaunaRequest, Fauna>()
            ;

        CreateMap<Fauna, FaunaResponse>()
            ;

        CreateMap<MultiToolRequest, MultiTool>()
            ;

        CreateMap<MultiTool, MultiToolResponse>()
            ;

        CreateMap<PlanetRequest, Planet>()
            ;

        CreateMap<Planet, PlanetResponse>()
            ;

        CreateMap<PlayerBaseRequest, PlayerBase>()
            ;

        CreateMap<PlayerBase, PlayerBaseResponse>()
            ;

        CreateMap<PointOfInterestRequest, PointOfInterest>()
            ;

        CreateMap<PointOfInterest, PointOfInterestResponse>()
            ;

        CreateMap<RegionRequest, Region>()
            ;

        CreateMap<Region, RegionResponse>()
            ;

        CreateMap<SettlementRequest, Settlement>()
            ;

        CreateMap<Settlement, SettlementResponse>()
            ;

        CreateMap<StarshipRequest, Starship>()
            ;

        CreateMap<Starship, StarshipResponse>()
            ;

        CreateMap<StarSystemRequest, StarSystem>()
            ;

        CreateMap<StarSystem, StarSystemResponse>()
            ;
    }
}