using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;
using AGT.GalacticArchives.Services.Services.Entities;

namespace AGT.GalacticArchives.Services.Decorators;

public class ValidatedStarshipServiceDecorator(IStarshipService starshipService) : IStarshipService
{
    public async Task<StarshipResponse?> GetStarshipByIdAsync(Guid starshipId)
    {
        return await starshipService.GetStarshipByIdAsync(starshipId);
    }

    public async Task<HashSet<StarshipResponse>> GetStarshipsAsync(StarshipRequest request)
    {
        return await starshipService.GetStarshipsAsync(request);
    }

    public async Task<StarshipResponse> UpsertStarshipAsync(StarshipRequest request)
    {
        return await starshipService.UpsertStarshipAsync(request);
    }

    public async Task DeleteStarshipAsync(Guid starshipId)
    {
        await starshipService.DeleteStarshipAsync(starshipId);
    }
}