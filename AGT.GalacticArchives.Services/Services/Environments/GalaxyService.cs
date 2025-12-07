using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Managers.Environments;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Environments;
using AGT.GalacticArchives.Core.Models.Responses.Environments;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Environments;

public class GalaxyService(IGalaxyManager galaxyManager, IMapper mapper) : IGalaxyService
{
    public async Task<HashSet<GalaxyResponse>> GetGalaxiesAsync()
    {
        var galaxies = await galaxyManager.GetGalaxiesAsync();
        return mapper.Map<HashSet<GalaxyResponse>>(galaxies);
    }

    public async Task<HashSet<GalaxyResponse>> GetGalaxiesAsync(GalaxyRequest request)
    {
        if (!request.GalaxyId.HasValue && string.IsNullOrEmpty(request.Name))
        {
            return await GetGalaxiesAsync();
        }

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
        var galaxy = mapper.Map<Galaxy>(request);
        if (request.GalaxyId.HasValue)
        {
            var existingGalaxy = await galaxyManager.GetGalaxyByIdAsync(request.GalaxyId.Value);
            if (!existingGalaxy!.ToDictionary().Matches(galaxy.ToDictionary()))
            {
                var updatedGalaxy = await galaxyManager.UpsertGalaxyAsync(galaxy);
                return mapper.Map<GalaxyResponse>(updatedGalaxy);
            }
        }

        var newGalaxy = await galaxyManager.UpsertGalaxyAsync(galaxy);
        return mapper.Map<GalaxyResponse>(newGalaxy);
    }

    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await galaxyManager.DeleteGalaxyAsync(galaxyId);
    }
}