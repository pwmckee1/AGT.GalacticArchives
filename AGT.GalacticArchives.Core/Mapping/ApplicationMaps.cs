using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Database;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping;

public class ApplicationMaps : Profile
{
    public ApplicationMaps()
    {
        // Needed to map between PagedResponse instances of a different type
        CreateMap(typeof(PagedResponse<>), typeof(PagedResponse<>));

        CreateMap(typeof(PagedDatabaseResponse), typeof(PagedResponse<>));
    }
}