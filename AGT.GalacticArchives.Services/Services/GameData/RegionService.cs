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
        var region = mapper.Map<Region>(request);
        if (request.RegionId.HasValue)
        {
            var existingRegion = await regionManager.GetRegionByIdAsync(request.RegionId.Value);

            if (existingRegion!.ToDictionary().HasAnyChanges(region.ToDictionary()))
            {
                region = await regionManager.UpsertRegionAsync(region);
            }
        }
        else
        {
            region = await regionManager.UpsertRegionAsync(region);
        }

        return mapper.Map<RegionResponse>(region);
    }

    public async Task DeleteRegionAsync(Guid regionId)
    {
        await regionManager.DeleteRegionAsync(regionId);
    }
}