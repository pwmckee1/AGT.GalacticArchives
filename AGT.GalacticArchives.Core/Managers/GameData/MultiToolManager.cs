using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class MultiToolManager(FirestoreDb firestoreDb, IMapper mapper) : GameDataManager<MultiTool>(firestoreDb, mapper), IMultiToolManager
{
    public async Task<MultiTool?> GetMultiToolByIdAsync(Guid multiToolId)
    {
        var snapshot = await GetByIdAsync(multiToolId, DatabaseConstants.MultiToolCollection);

        var multiTool = Mapper.Map<MultiTool>(snapshot);

        multiTool.Planet = await GetPlanetWithHierarchyAsync(multiTool.PlanetId!.Value);

        return multiTool;
    }

    public async Task<HashSet<MultiTool>> GetMultiToolsAsync(MultiToolRequest request)
    {
        if (request.MultiToolId.HasValue)
        {
            var multiTool = await GetMultiToolByIdAsync(request.MultiToolId!.Value);
            return multiTool != null ? [multiTool] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var snapshots = request.ParentId.HasValue
                ? await GetByNameAsync(request.Name!, request.ParentId!.Value, DatabaseConstants.MultiToolCollection)
                : await GetByNameAsync(request.Name!, DatabaseConstants.MultiToolCollection);

            var multiToolSet = Mapper.Map<HashSet<MultiTool>>(snapshots);
            foreach (var multiTool in multiToolSet)
            {
                if (multiTool.PlanetId.HasValue)
                {
                    multiTool.Planet = await GetPlanetWithHierarchyAsync(multiTool.PlanetId!.Value);
                }
                else
                {
                    multiTool.StarSystem = await GetStarSystemWithHierarchyAsync(multiTool.StarSystemId);
                }
            }

            return multiToolSet;
        }

        return [];
    }

    public async Task<MultiTool> UpsertMultiToolAsync(MultiTool multiTool)
    {
        return await UpsertAsync(multiTool, DatabaseConstants.MultiToolCollection);
    }

    public async Task DeleteMultiToolAsync(Guid multiToolId)
    {
        await DeleteAsync(multiToolId, DatabaseConstants.MultiToolCollection);
    }
}