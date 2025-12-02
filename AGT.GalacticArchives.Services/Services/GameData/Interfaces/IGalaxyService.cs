using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Services.GameData.Interfaces;

public interface IGalaxyService
{
    Task<HashSet<GalaxyResponse>> GetGalaxiesAsync();

    Task<HashSet<GalaxyResponse>> GetGalaxiesAsync(GalaxyRequest request);

    Task<GalaxyResponse?> GetGalaxyByIdAsync(Guid galaxyId);

    Task<GalaxyResponse> UpsertGalaxyAsync(GalaxyRequest request);

    Task DeleteGalaxyAsync(Guid galaxyId);
}