using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database;
using AGT.GalacticArchives.Core.Models.Environments;
using AGT.GalacticArchives.Core.Models.Requests.Environments;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AGT.GalacticArchives.Core.Managers.Environments;

public class GalaxyManager(IFirestoreManager firestoreManager, IMapper mapper, ILogger<GalaxyManager> logger) : IGalaxyManager
{
    private const string Collection = DatabaseConstants.GalaxyCollection;

    public async Task<HashSet<Galaxy>> GetGalaxiesAsync()
    {
        logger.LogInformation("Getting all galaxies");
        var galaxyDocs = await firestoreManager.GetAllAsync(Collection);
        return mapper.Map<HashSet<Galaxy>>(galaxyDocs);
    }

    public async Task<HashSet<Galaxy>> GetGalaxiesAsync(GalaxyRequest request)
    {
        if (request.GalaxyId.HasValue)
        {
            var galaxy = await GetGalaxyByIdAsync(request.GalaxyId!.Value);
            return galaxy != null ? [galaxy] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var records = firestoreManager.GetByNameAsync(request.Name, Collection);

            return mapper.Map<HashSet<Galaxy>>(records);
        }

        return [];
    }

    public async Task<Galaxy?> GetGalaxyByIdAsync(Guid galaxyId)
    {
        var galaxyDoc = await firestoreManager.GetByIdAsync(galaxyId, Collection);
        return galaxyDoc != null ? mapper.Map<Galaxy>(galaxyDoc) : null;
    }

    public async Task<Galaxy> UpsertGalaxyAsync(Galaxy galaxy)
    {
        return (Galaxy)await firestoreManager.UpsertAsync(galaxy, Collection);
    }

    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await firestoreManager.DeleteAsync(galaxyId, Collection);
    }
}