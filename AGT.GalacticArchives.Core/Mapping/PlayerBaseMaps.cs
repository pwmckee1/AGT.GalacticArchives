using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class PlayerBaseMaps : Profile
{
    public PlayerBaseMaps()
    {
        CreateMap<Dictionary<string, object>, PlayerBase>()
            .ConvertUsing<DatabaseEntityTypeConverter>()
            ;

        CreateMap<PlayerBase, PlayerBaseRequest>()
            ;
        CreateMap<PlayerBaseRequest, PlayerBase>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<PlayerBase, PlayerBaseResponse>()
            ;
        CreateMap<PlayerBaseResponse, PlayerBase>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;
    }
}