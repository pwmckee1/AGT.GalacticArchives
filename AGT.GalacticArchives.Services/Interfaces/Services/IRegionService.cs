using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Interfaces.Services;

public interface IRegionService
{
    Task<RegionResponse?> GetRegionByIdAsync(Guid regionId);

    Task<PagedResponse<RegionResponse>> GetRegionsAsync(RegionSearchRequest request);

    Task<RegionResponse> UpsertRegionAsync(RegionRequest request);

    Task DeleteRegionAsync(Guid regionId);
}