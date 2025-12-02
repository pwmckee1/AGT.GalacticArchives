using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Services.GameData.Interfaces;

public interface IRegionService
{
    Task<RegionResponse?> GetRegionByIdAsync(Guid regionId);

    Task<HashSet<RegionResponse>> GetRegionsAsync(RegionRequest request);

    Task<RegionResponse> UpsertRegionAsync(RegionRequest region);

    Task DeleteRegionAsync(Guid regionId);
}