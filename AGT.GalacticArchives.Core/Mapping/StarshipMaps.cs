using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class StarshipMaps : Profile
{
    public StarshipMaps()
    {
        CreateMap<Dictionary<string, object?>, Starship>().ConvertUsing<DatabaseEntityTypeConverter>();

        CreateMap<StarshipImport, Starship>()
            .ForMember(d => d.Name, o => o.MapFrom(s => s.StarSystemName))
            .ForMember(d => d.RegionId, o => o.Ignore())
            .ForMember(d => d.Region, o => o.Ignore())
            .ForMember(d => d.StarSystemId, o => o.Ignore())
            .ForMember(d => d.StarSystem, o => o.Ignore())
            .ForMember(d => d.PlanetId, o => o.Ignore())
            .ForMember(d => d.Planet, o => o.Ignore())

        CreateMap<Starship, StarshipRequest>();
        CreateMap<StarshipRequest, Starship>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore());

        CreateMap<Starship, StarshipResponse>();
        CreateMap<StarshipResponse, Starship>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore());
    }
}