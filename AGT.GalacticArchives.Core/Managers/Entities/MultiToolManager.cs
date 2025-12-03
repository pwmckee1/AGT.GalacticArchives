using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public class MultiToolManager(
    IFirestoreManager firestoreManager,
    IMapper mapper,
    IEntityHierarchyManager entityHierarchyManager) : IMultiToolManager
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

        var parentId = multiTool.PlanetId ?? multiTool.StarSystemId!.Value;
        await SetMultiToolHierarchies(multiTool, parentId);

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
            bool hasParentPlanet = request.PlanetId.HasValue;
            var parentId = request.PlanetId ?? request.StarSystemId!.Value;

            string? parentIdName = hasParentPlanet switch
            {
                true when !request.StarSystemId.HasValue => nameof(MultiToolRequest.PlanetId),
                false when request.StarSystemId.HasValue => nameof(MultiToolRequest.StarSystemId),
                _ => null,
            };

            var multiToolDocs = hasParentPlanet
                ? await firestoreManager.GetByNameAsync(request.Name, parentIdName!, parentId, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var multiTools = mapper.Map<HashSet<MultiTool>>(multiToolDocs);

            foreach (var multiTool in multiTools)
            {
                await SetMultiToolHierarchies(multiTool, parentId);
            }
        }

        return [];
    }

    public async Task<MultiTool> UpsertMultiToolAsync(MultiTool request)
    {
        var updatedMultiTool = (MultiTool)await firestoreManager.UpsertAsync(request, Collection);

        var parentId = request.PlanetId ?? request.StarSystemId!.Value;
        await SetMultiToolHierarchies(updatedMultiTool, parentId);

        return updatedMultiTool;
    }

    public async Task DeleteMultiToolAsync(Guid multiToolId)
    {
        await firestoreManager.DeleteAsync(multiToolId, Collection);
    }

    private async Task SetMultiToolHierarchies(MultiTool multiTool, Guid parentId)
    {
        if (multiTool.PlanetId.HasValue)
        {
            multiTool.Planet = await entityHierarchyManager.GetPlanetWithHierarchyAsync(parentId);
        }
        else
        {
            multiTool.StarSystem = await entityHierarchyManager.GetStarSystemWithHierarchyAsync(parentId);
        }
    }
}