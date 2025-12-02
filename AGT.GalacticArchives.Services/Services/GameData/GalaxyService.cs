using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.GameData;

public class GalaxyService(IGalaxyManager galaxyManager, IMapper mapper) : IGalaxyService
{
    public async Task<HashSet<GalaxyResponse>> GetGalaxiesAsync()
    {
        var galaxies = await galaxyManager.GetGalaxiesAsync();
        return mapper.Map<HashSet<GalaxyResponse>>(galaxies);
    }

    public async Task<HashSet<GalaxyResponse>> GetGalaxiesAsync(GalaxyRequest request)
    {
        if (!request.EntityId.HasValue && string.IsNullOrEmpty(request.Name)) return await GetGalaxiesAsync();

        var galaxies = await galaxyManager.GetGalaxiesAsync(request);
        return mapper.Map<HashSet<GalaxyResponse>>(galaxies);
    }

    public async Task<GalaxyResponse?> GetGalaxyByIdAsync(Guid galaxyId)
    {
        var galaxy = await galaxyManager.GetGalaxyByIdAsync(galaxyId);
        return galaxy != null ? mapper.Map<GalaxyResponse>(galaxy) : null;
    }

    public async Task<GalaxyResponse> UpsertGalaxyAsync(GalaxyRequest request)
    {
        if (request.EntityId.HasValue)
        {
            var requestedGalaxy = mapper.Map<Galaxy>(request);
            var existingGalaxy = await galaxyManager.GetGalaxyByIdAsync(request.EntityId.Value);

            if (existingGalaxy!.ToDictionary().HasAnyChanges(requestedGalaxy.ToDictionary()))
            {
                var updatedGalaxy = await galaxyManager.UpsertGalaxyAsync(requestedGalaxy);
                return mapper.Map<GalaxyResponse>(updatedGalaxy);
            }
        }

        var newGalaxy = mapper.Map<Galaxy>(request);
        newGalaxy = await galaxyManager.UpsertGalaxyAsync(newGalaxy);
        return mapper.Map<GalaxyResponse>(newGalaxy);
    }

    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await galaxyManager.DeleteGalaxyAsync(galaxyId);
    }
}