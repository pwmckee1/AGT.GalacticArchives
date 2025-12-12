using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.InGameLocations;

public class StarSystemManager(IFirestoreManager firestoreManager, IMapper mapper) : IStarSystemManager
{
    private const string Collection = DatabaseConstants.StarSystemCollection;

    public async Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId)
    {
        var starSystemDoc = await firestoreManager.GetByIdAsync(starSystemId, Collection);
        var starSystem = starSystemDoc.Count > 0 ? mapper.Map<StarSystem>(starSystemDoc) : null;

        if (starSystem == null)
        {
            return null;
        }

        return await GetStarSystemHierarchyAsync(starSystem);
    }

    public async Task<HashSet<StarSystem>> GetStarSystemsAsync(StarSystemRequest request)
    {
        if (request.StarSystemId.HasValue)
        {
            var region = await GetStarSystemByIdAsync(request.StarSystemId!.Value);
            return region != null ? [region] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var starSystemDocs = request.RegionId.HasValue
                ? await firestoreManager.GetByNameAsync(request.Name, nameof(StarSystem.RegionId), request.RegionId!.Value, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var starSystems = mapper.Map<HashSet<StarSystem>>(starSystemDocs);

            foreach (var starSystem in starSystems)
            {
                var regionData = await firestoreManager.GetByIdAsync(
                    starSystem.RegionId!.Value,
                    DatabaseConstants.RegionCollection);
                starSystem.Region = mapper.Map<Region>(regionData);
            }
        }

        return [];
    }

    public async Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem)
    {
        var updatedStarSystem = await firestoreManager.UpsertAsync(starSystem, Collection);

        var regionData = await firestoreManager.GetByIdAsync(
            updatedStarSystem.RegionId!.Value,
            DatabaseConstants.RegionCollection);
        starSystem.Region = mapper.Map<Region>(regionData);

        return starSystem;
    }

    public async Task DeleteStarSystemAsync(Guid starSystemId)
    {
        await firestoreManager.DeleteAsync(starSystemId, Collection);
    }

    private async Task<StarSystem> GetStarSystemHierarchyAsync(StarSystem starSystem)
    {
        var regionData = await firestoreManager.GetByIdAsync(
            starSystem.RegionId!.Value,
            DatabaseConstants.RegionCollection);
        starSystem.Region = mapper.Map<Region>(regionData);

        return starSystem;
    }
}