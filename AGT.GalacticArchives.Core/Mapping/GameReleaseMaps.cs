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

        CreateMap<GameRelease, GameReleaseRequest>();

        CreateMap<GameReleaseRequest, GameRelease>()
            .ForMember(d => d.GameReleaseId, o => o.MapFrom(s => s.GameReleaseId ?? Guid.NewGuid()))
            .ForMember(d => d.NormalizedName, o => o.Ignore());

        CreateMap<GameRelease, GameReleaseResponse>();

        CreateMap<GameReleaseResponse, GameRelease>()
            .ForMember(d => d.NormalizedName, o => o.Ignore());
    }
}