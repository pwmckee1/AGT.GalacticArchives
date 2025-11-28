using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Enums;
using AGT.GalacticArchives.Core.Interfaces.GameData;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class StarSystemManager(FirestoreDb firestoreDb, IMapper mapper) : GameDataManager<IGameData>(firestoreDb, mapper), IStarSystemManager
{
    public async Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId)
    {
        var starSystemdata = await GetByIdAsync(starSystemId, DatabaseConstants.StarSystemCollection);

        if (starSystemdata == null)
        {
            return null;
        }

        var starSystem = Mapper.Map<StarSystem>(starSystemdata);

        if (starSystem.RegionId.HasValue)
        {
            var regionData = await GetByIdAsync(starSystem.RegionId.Value, DatabaseConstants.RegionCollection);
            var region = Mapper.Map<Region>(regionData);

            if (region.GalaxyId.HasValue)
            {
                var galaxyData = await GetByIdAsync(starSystem.RegionId.Value, DatabaseConstants.RegionCollection);
                region.Galaxy = Mapper.Map<Galaxy>(galaxyData);
            }

            starSystem.Region = region;
        }

        return starSystem;
    }

    public async Task CreateOrUpdateStarSystemAsync(StarSystem starSystem)
    {
        await CreateOrUpdateAsync(starSystem, DatabaseConstants.StarSystemCollection);
    }

    public async Task DeleteStarSystemAsync(Guid starSystemId)
    {
        await DeleteAsync(starSystemId, DatabaseConstants.StarSystemCollection);
    }
}