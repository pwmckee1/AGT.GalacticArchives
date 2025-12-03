using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.GameData;

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
        if (request.EntityId.HasValue)
        {
            var requestedRegion = mapper.Map<Region>(request);
            var existingRegion = await regionManager.GetRegionByIdAsync(request.EntityId.Value);

            if (existingRegion!.ToDictionary().HasAnyChanges(requestedRegion.ToDictionary()))
            {
                var updatedRegion = await regionManager.UpsertRegionAsync(requestedRegion);
                return mapper.Map<RegionResponse>(updatedRegion);
            }
        }

        var newRegion = mapper.Map<Region>(request);
        newRegion = await regionManager.UpsertRegionAsync(newRegion);
        return mapper.Map<RegionResponse>(newRegion);
    }

    public async Task DeleteRegionAsync(Guid regionId)
    {
        await regionManager.DeleteRegionAsync(regionId);
    }
}