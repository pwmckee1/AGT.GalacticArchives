using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameEntities;

public class MultiToolManager(
    IFirestoreManager firestoreManager,
    IMapper mapper,
    IGalacticEntityManager galacticEntityManager) : GameEntityManager(firestoreManager), IMultiToolManager
{
    protected override string Collection => DatabaseConstants.MultiToolCollection;

    public async Task<MultiTool?> GetMultiToolByIdAsync(Guid multiToolId)
    {
        var multiToolDoc = await FirestoreManager.GetByIdAsync(multiToolId, Collection);
        var multiTool = mapper.Map<MultiTool>(multiToolDoc);

        if (multiTool == null)
        {
            return null;
        }

        var parentId = multiTool.PlanetId ?? multiTool.StarSystemId!.Value;
        await SetMultiToolHierarchies(multiTool, parentId);

        return multiTool;
    }

    public async Task<HashSet<MultiTool>> GetMultiToolsAsync(MultiToolSearchRequest request)
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
                ? await FirestoreManager.GetByNameAsync(request.Name, parentIdName!, parentId, Collection)
                : await FirestoreManager.GetByNameAsync(request.Name, Collection);

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
        await UpdateMultiToolHierarchy(request);
        await FirestoreManager.UpsertAsync(request, Collection);
        return request;
    }

    public async Task<HashSet<MultiTool>> UpsertMultiToolAsync(HashSet<MultiTool> request, CancellationToken ct)
    {
        return await FirestoreManager.UpsertAsync(request, Collection, ct);
    }

    public async Task DeleteMultiToolAsync(Guid multiToolId)
    {
        await FirestoreManager.DeleteAsync(multiToolId, Collection);
    }

    private async Task SetMultiToolHierarchies(MultiTool multiTool, Guid parentId)
    {
        if (multiTool.PlanetId.HasValue)
        {
            multiTool.Planet = multiTool.PlanetId.HasValue
                ? await galacticEntityManager.GetPlanetaryHierarchyAsync(parentId)
                : null;
        }
        else
        {
            multiTool.StarSystem = multiTool.StarSystemId.HasValue
                ? await galacticEntityManager.GetStarSystemHierarchyAsync(parentId)
                : null;
        }
    }

    private async Task UpdateMultiToolHierarchy(MultiTool multiTool)
    {
        if (multiTool.Planet == null && multiTool.StarSystem == null)
        {
            return;
        }

        StarSystem? starSystem = null;
        if (multiTool.Planet != null)
        {
            await galacticEntityManager.UpsertPlanetAsync(multiTool.Planet);
            starSystem = multiTool.Planet!.StarSystem;
        }
        else if (multiTool.StarSystem != null)
        {
            starSystem = multiTool.StarSystem;
        }

        await galacticEntityManager.UpsertStarSystemAsync(starSystem);
        await galacticEntityManager.UpsertRegionAsync(multiTool.Planet!.StarSystem!.Region);
    }
}