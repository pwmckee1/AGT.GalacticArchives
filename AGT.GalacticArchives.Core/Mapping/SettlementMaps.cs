using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class SettlementMaps : Profile
{
    public SettlementMaps()
    {
        CreateMap<Dictionary<string, object?>, Settlement>().ConvertUsing<DatabaseEntityTypeConverter>();

        CreateMap<SettlementImport, Settlement>()
            .ForMember(d => d.Name, o => o.MapFrom(s => s.SettlementName))
            .ForMember(d => d.Region, o => o.Ignore())
            .ForMember(d => d.StarSystem, o => o.Ignore())
            .ForMember(d => d.Planet, o => o.Ignore());

        CreateMap<Settlement, SettlementRequest>();
        CreateMap<SettlementRequest, Settlement>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore());

        CreateMap<Settlement, SettlementResponse>();
        CreateMap<SettlementResponse, Settlement>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore());
    }
}