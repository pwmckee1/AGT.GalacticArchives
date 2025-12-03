using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.GameData.BaseEntities;
using AGT.GalacticArchives.Core.Models.GameData.Interfaces;
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

        CreateMap<PointOfInterestRequest, DatabaseEntity>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.CollectionName, o => o.Ignore())
            .ForMember(d => d.ParentCollectionName, o => o.Ignore())
            .ForMember(d => d.NormalizedName, o => o.Ignore())
            ;

        CreateMap<PointOfInterestRequest, PointOfInterest>()
            .ForMember(d => d.EntityId, o => o.Ignore())
            .ForMember(d => d.PointOfInterestId, o => o.Ignore())
            ;

        CreateMap<PointOfInterest, PointOfInterestResponse>()
            ;

        CreateMap<IDatabaseEntity, PointOfInterestResponse>()
            ;
    }
}