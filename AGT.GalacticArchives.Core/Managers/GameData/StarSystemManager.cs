using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class StarSystemManager(IFirestoreManager firestoreManager, IMapper mapper) : IStarSystemManager
{
    private const string Collection = DatabaseConstants.StarSystemCollection;

    public async Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId)
    {
        var starSystemDoc = await firestoreManager.GetByIdAsync(starSystemId, Collection);
        var starSystem = starSystemDoc != null ? mapper.Map<StarSystem>(starSystemDoc) : null;

        if (starSystem == null)
        {
            return null;
        }

        return await GetStarSystemHierarchyAsync(starSystem);
    }

    public async Task<HashSet<StarSystem>> GetStarSystemsAsync(StarSystemRequest request)
    {
        if (request.EntityId.HasValue)
        {
            var region = await GetStarSystemByIdAsync(request.EntityId!.Value);
            return region != null ? [region] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var starSystemDocs = request.ParentId.HasValue
                ? await firestoreManager.GetByNameAsync(request.Name, request.ParentId!.Value, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var starSystems = mapper.Map<HashSet<StarSystem>>(starSystemDocs);

            foreach (var starSystem in starSystems)
            {
                var regionData = await firestoreManager.GetByIdAsync(
                    starSystem.RegionId,
                    DatabaseConstants.RegionCollection);
                var region = mapper.Map<Region>(regionData);

                var galaxyData = await firestoreManager.GetByIdAsync(
                    region.GalaxyId,
                    DatabaseConstants.GalaxyCollection);
                region.Galaxy = mapper.Map<Galaxy>(galaxyData);

                starSystem.Region = region;
            }
        }

        return [];
    }

    public async Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem)
    {
        var updatedStarSystem = (StarSystem)await firestoreManager.UpsertAsync(starSystem, Collection);

        var regionData = await firestoreManager.GetByIdAsync(
            updatedStarSystem.RegionId,
            DatabaseConstants.RegionCollection);
        starSystem.Region = mapper.Map<Region>(regionData);

        var galaxyData = await firestoreManager.GetByIdAsync(
            starSystem.Region.GalaxyId,
            DatabaseConstants.GalaxyCollection);
        starSystem.Region.Galaxy = mapper.Map<Galaxy>(galaxyData);

        return starSystem;
    }

    public async Task DeleteStarSystemAsync(Guid starSystemId)
    {
        await firestoreManager.DeleteAsync(starSystemId, Collection);
    }

    private async Task<StarSystem> GetStarSystemHierarchyAsync(StarSystem starSystem)
    {
        var regionData = await firestoreManager.GetByIdAsync(
            starSystem.RegionId,
            DatabaseConstants.RegionCollection);
        var region = mapper.Map<Region>(regionData);

        var galaxyData = await firestoreManager.GetByIdAsync(
            region.GalaxyId,
            DatabaseConstants.GalaxyCollection);

        region.Galaxy = mapper.Map<Galaxy>(galaxyData);
        starSystem.Region = region;

        return starSystem;
    }
}