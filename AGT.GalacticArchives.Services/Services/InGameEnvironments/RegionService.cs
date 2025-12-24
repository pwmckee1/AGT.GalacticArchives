using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.InGameEnvironments;

public class RegionService(IRegionManager regionManager, IMapper mapper) : IRegionService
{
    public async Task<RegionResponse?> GetRegionByIdAsync(Guid regionId)
    {
        var region = await regionManager.GetRegionByIdAsync(regionId);
        return region != null ? mapper.Map<RegionResponse>(region) : null;
    }

    public async Task<HashSet<RegionResponse>> GetRegionsAsync(RegionRequest request)
    {
        var region = await regionManager.GetRegionsAsync(request);
        return mapper.Map<HashSet<RegionResponse>>(region);
    }

    public async Task<RegionResponse> UpsertRegionAsync(RegionRequest request)
    {
        var region = mapper.Map<Region>(request);
        if (request.RegionId.HasValue)
        {
            var existingRegion = await regionManager.GetRegionByIdAsync(request.RegionId.Value);
            if (!existingRegion!.ToDictionary().Matches(region.ToDictionary()))
            {
                var updatedRegion = await regionManager.UpsertRegionAsync(region);
                return mapper.Map<RegionResponse>(updatedRegion);
            }
        }

        var newRegion = await regionManager.UpsertRegionAsync(region);
        return mapper.Map<RegionResponse>(newRegion);
    }

    public async Task DeleteRegionAsync(Guid regionId)
    {
        await regionManager.DeleteRegionAsync(regionId);
    }
}