using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;
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
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<StarSystem, StarSystemResponse>()
            ;
        CreateMap<StarSystemResponse, StarSystem>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;
    }
}