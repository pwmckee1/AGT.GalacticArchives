using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Services.Interfaces.GameData;

public interface IStarSystemService
{
    Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId);

    Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem);

    Task DeleteStarSystemAsync(Guid starSystemId);
}