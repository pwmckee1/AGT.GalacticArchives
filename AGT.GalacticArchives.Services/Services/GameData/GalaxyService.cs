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
        return galaxy != null ? mapper.Map<GalaxyResponse>(galaxy) : new GalaxyResponse();
    }

    public async Task<GalaxyResponse> UpsertGalaxyAsync(GalaxyRequest request)
    {
        var galaxy = mapper.Map<Galaxy>(request);
        if (request.GalaxyId.HasValue)
        {
            var existingGalaxy = await galaxyManager.GetGalaxyByIdAsync(request.GalaxyId.Value);

            if (existingGalaxy!.ToDictionary().HasAnyChanges(galaxy.ToDictionary()))
            {
                galaxy = await galaxyManager.UpsertGalaxyAsync(galaxy);
            }
        }
        else
        {
            galaxy =  await galaxyManager.UpsertGalaxyAsync(galaxy);
        }

        return mapper.Map<GalaxyResponse>(galaxy);
    }

    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await galaxyManager.DeleteGalaxyAsync(galaxyId);
    }
}
