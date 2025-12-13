using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Entities;

public class StarshipService(IStarshipManager starshipManager, IMapper mapper) : IStarshipService
{
    public async Task<StarshipResponse?> GetStarshipByIdAsync(Guid starshipId)
    {
        var starship = await starshipManager.GetStarshipByIdAsync(starshipId);
        return starship != null ? mapper.Map<StarshipResponse>(starship) : null;
    }

    public async Task<HashSet<StarshipResponse>> GetStarshipsAsync(StarshipRequest request)
    {
        var starship = await starshipManager.GetStarshipsAsync(request);
        return mapper.Map<HashSet<StarshipResponse>>(starship);
    }

    public async Task<StarshipResponse> UpsertStarshipAsync(StarshipRequest request)
    {
        var starship = mapper.Map<Starship>(request);
        if (request.StarshipId.HasValue)
        {
            var existingStarship = await starshipManager.GetStarshipByIdAsync(request.StarshipId.Value);
            if (!existingStarship!.ToDictionary().Matches(starship.ToDictionary()))
            {
                var updatedStarship = await starshipManager.UpsertStarshipAsync(starship);
                return mapper.Map<StarshipResponse>(updatedStarship);
            }
        }

        var newStarship = await starshipManager.UpsertStarshipAsync(starship);
        return mapper.Map<StarshipResponse>(newStarship);
    }

    public async Task DeleteStarshipAsync(Guid starshipId)
    {
        await starshipManager.DeleteStarshipAsync(starshipId);
    }
}