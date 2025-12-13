using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Services.InGameEnvironments;

public interface IRegionService
{
    Task<RegionResponse?> GetRegionByIdAsync(Guid regionId);

    Task<HashSet<RegionResponse>> GetRegionsAsync(RegionRequest request);

    Task<RegionResponse> UpsertRegionAsync(RegionRequest request);

    Task DeleteRegionAsync(Guid regionId);
}