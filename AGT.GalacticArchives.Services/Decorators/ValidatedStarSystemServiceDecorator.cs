using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;
using AGT.GalacticArchives.Services.Services.Environments;

namespace AGT.GalacticArchives.Services.Decorators;

public class ValidatedStarSystemServiceDecorator(IStarSystemService starSystemService) : IStarSystemService
{
    public async Task<StarSystemResponse?> GetStarSystemByIdAsync(Guid starSystemId)
    {
        return await starSystemService.GetStarSystemByIdAsync(starSystemId);
    }

    public async Task<HashSet<StarSystemResponse>> GetStarSystemsAsync(StarSystemRequest request)
    {
        return await starSystemService.GetStarSystemsAsync(request);
    }

    public async Task<StarSystemResponse> UpsertStarSystemAsync(StarSystemRequest request)
    {
        return await starSystemService.UpsertStarSystemAsync(request);
    }

    public async Task DeleteStarSystemAsync(Guid starSystemId)
    {
        await starSystemService.DeleteStarSystemAsync(starSystemId);
    }
}