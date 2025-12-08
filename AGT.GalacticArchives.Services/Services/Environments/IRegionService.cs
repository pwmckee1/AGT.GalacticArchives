using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;

namespace AGT.GalacticArchives.Services.Services.Environments;

public interface IRegionService
{
    Task<RegionResponse?> GetRegionByIdAsync(Guid regionId);

    Task<HashSet<RegionResponse>> GetRegionsAsync(RegionRequest request);

    Task<RegionResponse> UpsertRegionAsync(RegionRequest request);

    Task DeleteRegionAsync(Guid regionId);
}