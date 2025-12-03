using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class SettlementMaps : Profile
{
    public SettlementMaps()
    {
        CreateMap<Dictionary<string, object>, Settlement>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<Settlement, SettlementRequest>()
            ;
        CreateMap<SettlementRequest, Settlement>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<Settlement, SettlementResponse>()
            ;
        CreateMap<SettlementResponse, Settlement>()
            .ForMember(d => d.Id, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;
    }
}