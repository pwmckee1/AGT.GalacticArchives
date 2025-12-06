using AGT.GalacticArchives.Core.Models.Requests.Environments;
using AGT.GalacticArchives.Core.Models.Responses.Environments;

namespace AGT.GalacticArchives.Services.Services.Environments;

public interface IGalaxyService
{
    Task<HashSet<GalaxyResponse>> GetGalaxiesAsync();

    Task<HashSet<GalaxyResponse>> GetGalaxiesAsync(GalaxyRequest request);

    Task<GalaxyResponse?> GetGalaxyByIdAsync(Guid galaxyId);

    Task<GalaxyResponse> UpsertGalaxyAsync(GalaxyRequest request);

    Task DeleteGalaxyAsync(Guid galaxyId);
}