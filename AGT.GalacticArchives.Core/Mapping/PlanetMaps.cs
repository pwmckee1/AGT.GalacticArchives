using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Mapping.ValueResolvers;
using AGT.GalacticArchives.Core.Models.Environments;
using AGT.GalacticArchives.Core.Models.Requests.Environments;
using AGT.GalacticArchives.Core.Models.Responses.Environments;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class PlanetMaps : Profile
{
    public PlanetMaps()
    {
        CreateMap<Dictionary<string, object>, Planet>()
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
            .ForMember(d => d.GalaxyId, o => o.MapFrom<GalaxyValueResolver>())
            .ForMember(d => d.Galaxy, o => o.MapFrom<GalaxyValueResolver>())
            ;

        CreateMap<Planet, PlanetResponseEntity>()
            ;
    }
}