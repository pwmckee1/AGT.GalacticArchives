using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
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
            .ForMember(d => d.Name, o => o.MapFrom(s => s.StarshipName))
            .ForMember(d => d.Region, o => o.Ignore())
            .ForMember(d => d.StarSystem, o => o.Ignore())
            .ForMember(d => d.Planet, o => o.Ignore());

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