using AGT.GalacticArchives.Core.Models.Environments;
using AGT.GalacticArchives.Core.Models.Requests.Environments;
using AGT.GalacticArchives.Core.Models.Responses.Environments;
using AGT.GalacticArchives.Globalization;
using AGT.GalacticArchives.Services.Services.Environments;

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
        if (string.IsNullOrEmpty(request.Name))
        {
            throw new ArgumentNullException(
                string.Format(
                    GeneralErrorResource.PropertyMissing,
                    $"{nameof(Galaxy)} => {nameof(Galaxy.Name)}"));
        }

        if (request.Sequence is null or < 0)
        {
            throw new ArgumentOutOfRangeException(GalaxyResource.InvalidSequence);
        }

        return await galaxyService.UpsertGalaxyAsync(request);
    }

    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await galaxyService.DeleteGalaxyAsync(galaxyId);
    }
}