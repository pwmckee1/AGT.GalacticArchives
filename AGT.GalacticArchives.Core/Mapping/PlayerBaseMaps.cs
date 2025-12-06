using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class PlayerBaseMaps : Profile
{
    public PlayerBaseMaps()
    {
        CreateMap<Dictionary<string, object>, PlayerBase>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<PlayerBase, PlayerBaseRequest>()
            ;
        CreateMap<PlayerBaseRequest, PlayerBase>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<PlayerBase, PlayerBaseResponse>()
            ;
        CreateMap<PlayerBaseResponse, PlayerBase>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;
    }
}