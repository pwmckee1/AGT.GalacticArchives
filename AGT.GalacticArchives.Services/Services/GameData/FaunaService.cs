using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.GameData;

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
        if (request.EntityId.HasValue)
        {
            var existingFauna = await faunaManager.GetFaunaByIdAsync(request.EntityId.Value);

            if (existingFauna!.ToDictionary().HasAnyChanges(fauna.ToDictionary()))
            {
                fauna = await faunaManager.UpsertFaunaAsync(fauna);
            }
        }
        else
        {
            fauna = await faunaManager.UpsertFaunaAsync(fauna);
        }

        return mapper.Map<FaunaResponse>(fauna);
    }

    public async Task DeleteFaunaAsync(Guid faunaId)
    {
        await faunaManager.DeleteFaunaAsync(faunaId);
    }
}