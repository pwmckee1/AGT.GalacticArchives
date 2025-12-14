using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
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

        CreateMap<PlanetImport, Planet>()
            .ForMember(d => d.Name, o => o.MapFrom(s => s.StarSystemName))
            .ForMember(d => d.RegionId, o => o.Ignore())
            .ForMember(d => d.Region, o => o.Ignore())
            .ForMember(d => d.StarSystemId, o => o.Ignore())
            .ForMember(d => d.StarSystem, o => o.Ignore())
            .ForMember(d => d.Planet, o => o.Ignore())
            .ForMember(d => d.YAxisPlanetCoordinate, o => o.Ignore())
            .ForMember(d => d.XAxisPlanetCoordinate, o => o.Ignore());

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