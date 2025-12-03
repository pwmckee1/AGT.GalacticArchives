using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;
using AutoMapper;
using Starship = AGT.GalacticArchives.Core.Models.GameData.Starship;

namespace AGT.GalacticArchives.Services.Services.GameData;

public class StarshipService(IStarshipManager starshipManager, IMapper mapper) : IStarshipService
{
    public async Task<StarshipResponse?> GetStarshipByIdAsync(Guid starshipId)
    {
        var starship = await starshipManager.GetStarshipByIdAsync(starshipId);
        return starship != null ? mapper.Map<StarshipResponse>(starship) : null;
    }

    public async Task<HashSet<StarshipResponse>> GetStarshipsAsync(StarshipDatabaseEntityRequest databaseEntityRequest)
    {
        var starship = await starshipManager.GetStarshipsAsync(databaseEntityRequest);
        return mapper.Map<HashSet<StarshipResponse>>(starship);
    }

    public async Task<StarshipResponse> UpsertStarshipAsync(StarshipDatabaseEntityRequest databaseEntityRequest)
    {
        var starship = mapper.Map<Starship>(databaseEntityRequest);
        if (databaseEntityRequest.EntityId.HasValue)
        {
            var existingStarship = await starshipManager.GetStarshipByIdAsync(databaseEntityRequest.EntityId.Value);

            if (existingStarship!.ToDictionary().HasAnyChanges(starship.ToDictionary()))
            {
                starship = await starshipManager.UpsertStarshipAsync(starship);
            }
        }
        else
        {
            starship = await starshipManager.UpsertStarshipAsync(starship);
        }

        return mapper.Map<StarshipResponse>(starship);
    }

    public async Task DeleteStarshipAsync(Guid starshipId)
    {
        await starshipManager.DeleteStarshipAsync(starshipId);
    }
}