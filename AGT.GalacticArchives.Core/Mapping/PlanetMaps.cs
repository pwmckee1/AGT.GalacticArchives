using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class PlanetMaps : Profile
{
    public PlanetMaps()
    {
        CreateMap<Dictionary<string, object?>, Planet>().ConvertUsing<DatabaseEntityTypeConverter>();

        CreateMap<Planet, PlanetRequest>();
        CreateMap<PlanetRequest, Planet>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore());

        CreateMap<Planet, PlanetResponse>();
        CreateMap<PlanetResponse, Planet>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore());
    }
}