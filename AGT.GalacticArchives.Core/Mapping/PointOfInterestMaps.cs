using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class PointOfInterestMaps : Profile
{
    public PointOfInterestMaps()
    {
        CreateMap<Dictionary<string, object?>, PointOfInterest>().ConvertUsing<DatabaseEntityTypeConverter>();

        CreateMap<PointOfInterestImport, PointOfInterest>()
            .ForMember(d => d.Name, o => o.MapFrom(s => s.StarSystemName))
            .ForMember(d => d.RegionId, o => o.Ignore())
            .ForMember(d => d.Region, o => o.Ignore())
            .ForMember(d => d.StarSystemId, o => o.Ignore())
            .ForMember(d => d.StarSystem, o => o.Ignore())
            .ForMember(d => d.PlanetId, o => o.Ignore())
            .ForMember(d => d.Planet, o => o.Ignore());

        CreateMap<PointOfInterest, PointOfInterestRequest>();
        CreateMap<PointOfInterestRequest, PointOfInterest>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore());

        CreateMap<PointOfInterest, PointOfInterestResponse>();
        CreateMap<PointOfInterestResponse, PointOfInterest>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore());
    }
}