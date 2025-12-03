using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class MultiToolManager(
    IFirestoreManager firestoreManager,
    IMapper mapper,
    IInnerSystemEntityManager innerSystemEntityManager) : IMultiToolManager
{
    private const string Collection = DatabaseConstants.MultiToolCollection;

    public async Task<MultiTool?> GetMultiToolByIdAsync(Guid multiToolId)
    {
        var multiToolDoc = await firestoreManager.GetByIdAsync(multiToolId, Collection);
        var multiTool = multiToolDoc != null ? mapper.Map<MultiTool>(multiToolDoc) : null;

        if (multiTool == null)
        {
            return null;
        }

        await SetMultiToolHierarchies(multiTool);

        return multiTool;
    }

    public async Task<HashSet<MultiTool>> GetMultiToolsAsync(MultiToolRequest request)
    {
        if (request.EntityId.HasValue)
        {
            var multiTool = await GetMultiToolByIdAsync(request.EntityId!.Value);

            return multiTool != null ? [multiTool] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var multiToolDocs = request.ParentId.HasValue
                ? await firestoreManager.GetByNameAsync(request.Name, request.ParentId!.Value, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var multiTools = mapper.Map<HashSet<MultiTool>>(multiToolDocs);

            foreach (var multiTool in multiTools)
            {
                await SetMultiToolHierarchies(multiTool);
            }
        }

        return [];
    }

    public async Task<MultiTool> UpsertMultiToolAsync(MultiTool multiTool)
    {
        var updatedMultiTool = (MultiTool)await firestoreManager.UpsertAsync(multiTool, Collection);

        await SetMultiToolHierarchies(updatedMultiTool);

        return updatedMultiTool;
    }

    public async Task DeleteMultiToolAsync(Guid multiToolId)
    {
        await firestoreManager.DeleteAsync(multiToolId, Collection);
    }

    private async Task SetMultiToolHierarchies(MultiTool multiTool)
    {
        if (multiTool.PlanetId.HasValue)
        {
            multiTool.Planet = await innerSystemEntityManager.GetPlanetWithHierarchyAsync(multiTool.ParentId);
        }
        else
        {
            multiTool.StarSystem = await innerSystemEntityManager.GetStarSystemWithHierarchyAsync(multiTool.ParentId);
        }
    }
}