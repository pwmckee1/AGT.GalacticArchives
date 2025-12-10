using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class PointOfInterestMaps : Profile
{
    public PointOfInterestMaps()
    {
        CreateMap<Dictionary<string, object>, PointOfInterest>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<PointOfInterest, PointOfInterestRequest>()
            ;
        CreateMap<PointOfInterestRequest, PointOfInterest>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<PointOfInterest, PointOfInterestResponse>()
            ;
        CreateMap<PointOfInterestResponse, PointOfInterest>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;
    }
}