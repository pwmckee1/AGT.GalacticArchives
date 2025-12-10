using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class StarSystemMaps : Profile
{
    public StarSystemMaps()
    {
        CreateMap<Dictionary<string, object>, StarSystem>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<StarSystem, StarSystemRequest>()
            ;
        CreateMap<StarSystemRequest, StarSystem>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<StarSystem, StarSystemResponse>()
            ;
        CreateMap<StarSystemResponse, StarSystem>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;
    }
}