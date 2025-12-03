using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.GameData.BaseEntities;
using AGT.GalacticArchives.Core.Models.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class PlanetMaps : Profile
{
    public PlanetMaps()
    {
        CreateMap<Dictionary<string, object?>, Planet>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<PlanetRequest, DatabaseEntity>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<PlanetRequest, Planet>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.PlanetId, o => o.Ignore())
            ;

        CreateMap<IDatabaseEntity, PlanetResponse>()
            ;

        CreateMap<Planet, PlanetResponse>()
            ;
    }
}