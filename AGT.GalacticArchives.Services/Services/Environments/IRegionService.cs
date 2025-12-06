using AGT.GalacticArchives.Core.Models.Requests.Environments;
using AGT.GalacticArchives.Core.Models.Responses.Environments;

namespace AGT.GalacticArchives.Services.Services.Environments;

public interface IRegionService
{
    Task<RegionResponse?> GetRegionByIdAsync(Guid regionId);

    Task<HashSet<RegionResponse>> GetRegionsAsync(RegionRequest request);

    Task<RegionResponse> UpsertRegionAsync(RegionRequest request);

    Task DeleteRegionAsync(Guid regionId);
}