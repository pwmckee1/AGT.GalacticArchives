using AGT.GalacticArchives.Core.Mapping.TypeConverters;
using AGT.GalacticArchives.Core.Models.Metadata;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class GameReleaseMaps : Profile
{
    public GameReleaseMaps()
    {
        CreateMap<Dictionary<string, object?>, GameRelease>().ConvertUsing<DatabaseEntityTypeConverter>();

        CreateMap<Dictionary<string, object?>, GameReleaseResponse>().ConvertUsing<DatabaseEntityTypeConverter>();

        CreateMap<GameRelease, GameReleaseRequest>()
            .ForMember(d => d.ReleaseId, o => o.MapFrom(s => s.EntityId))
            .ForMember(d => d.ReleaseName, o => o.MapFrom(s => s.Name));

        CreateMap<GameReleaseRequest, GameRelease>()
            .ForMember(d => d.EntityId, o => o.MapFrom(s => s.ReleaseId))
            .ForMember(d => d.Name, o => o.MapFrom(s => s.ReleaseName))
            .ForMember(d => d.NormalizedName, o => o.Ignore());

        CreateMap<GameRelease, GameReleaseResponse>()
            .ForMember(d => d.ReleaseId, o => o.MapFrom(s => s.EntityId))
            .ForMember(d => d.ReleaseName, o => o.MapFrom(s => s.Name));

        CreateMap<GameReleaseResponse, GameRelease>()
            .ForMember(d => d.EntityId, o => o.MapFrom(s => s.ReleaseId))
            .ForMember(d => d.Name, o => o.MapFrom(s => s.ReleaseName))
            .ForMember(d => d.NormalizedName, o => o.Ignore());
    }
}