using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface IFaunaManager : IGameDataManager<Fauna>
{
    Task<Fauna?> GetFaunaByIdAsync(Guid faunaId);

    Task<HashSet<Fauna>> GetFaunaAsync(FaunaRequest request);

    Task<Fauna> UpsertFaunaAsync(Fauna fauna);

    Task DeleteFaunaAsync(Guid faunaId);
}