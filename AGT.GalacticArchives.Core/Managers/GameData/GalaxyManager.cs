using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.GameData;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class GalaxyManager(FirestoreDb firestoreDb) : GameDataManager<IGameData>(firestoreDb), IGalaxyManager
{
    public async Task<Galaxy?> GetGalaxyByIdAsync(Guid galaxyId)
    {
        var data = await GetByIdAsync(galaxyId, DatabaseConstants.GalaxyCollection);

        if (data == null)
        {
            return null;
        }

        return new Galaxy
        {
            GalaxyId = (Guid)data[nameof(Galaxy.GalaxyId)],
            Sequence = (int)data[nameof(Galaxy.Sequence)],
            Name = (string)data[nameof(Galaxy.Name)],
        };
    }

    public async Task CreateOrUpdateGalaxyAsync(Galaxy galaxy)
    {
        await CreateOrUpdateAsync(galaxy, DatabaseConstants.GalaxyCollection);
    }

    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await DeleteAsync(galaxyId, DatabaseConstants.GalaxyCollection);
    }
}