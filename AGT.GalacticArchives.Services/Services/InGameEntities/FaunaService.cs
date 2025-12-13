using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.InGameEntities;

public class FaunaService(IFaunaManager faunaManager, IMapper mapper) : IFaunaService
{
    public async Task<FaunaResponse?> GetFaunaByIdAsync(Guid faunaId)
    {
        var fauna = await faunaManager.GetFaunaByIdAsync(faunaId);
        return fauna != null ? mapper.Map<FaunaResponse>(fauna) : null;
    }

    public async Task<HashSet<FaunaResponse>> GetFaunaAsync(FaunaRequest request)
    {
        var fauna = await faunaManager.GetFaunaAsync(request);
        return mapper.Map<HashSet<FaunaResponse>>(fauna);
    }

    public async Task<FaunaResponse> UpsertFaunaAsync(FaunaRequest request)
    {
        var fauna = mapper.Map<Fauna>(request);
        if (request.FaunaId.HasValue)
        {
            var existingFauna = await faunaManager.GetFaunaByIdAsync(request.FaunaId.Value);
            if (!existingFauna!.ToDictionary().Matches(fauna.ToDictionary()))
            {
                var updatedFauna = await faunaManager.UpsertFaunaAsync(fauna);
                return mapper.Map<FaunaResponse>(updatedFauna);
            }
        }

        var newFauna = await faunaManager.UpsertFaunaAsync(fauna);
        return mapper.Map<FaunaResponse>(newFauna);
    }

    public async Task DeleteFaunaAsync(Guid faunaId)
    {
        await faunaManager.DeleteFaunaAsync(faunaId);
    }
}