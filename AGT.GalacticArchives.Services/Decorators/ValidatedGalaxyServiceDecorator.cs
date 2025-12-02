using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;

namespace AGT.GalacticArchives.Services.Decorators;

public class ValidatedGalaxyServiceDecorator(IGalaxyService galaxyService) : IGalaxyService
{
    public async Task<GalaxyResponse?> GetGalaxyByIdAsync(Guid galaxyId)
    {
        return await galaxyService.GetGalaxyByIdAsync(galaxyId);
    }

    public async Task<HashSet<GalaxyResponse>> GetGalaxiesAsync()
    {
        return await galaxyService.GetGalaxiesAsync();
    }

    public async Task<HashSet<GalaxyResponse>> GetGalaxiesAsync(GalaxyRequest request)
    {
        return await galaxyService.GetGalaxiesAsync(request);
    }

    public async Task<GalaxyResponse> UpsertGalaxyAsync(GalaxyRequest request)
    {
        return await galaxyService.UpsertGalaxyAsync(request);
    }

    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await galaxyService.DeleteGalaxyAsync(galaxyId);
    }
}