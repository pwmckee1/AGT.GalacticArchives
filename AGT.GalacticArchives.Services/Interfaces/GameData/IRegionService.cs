using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Services.Interfaces.GameData;

public interface IRegionService
{
    Task<Region?> GetRegionByIdAsync(Guid regionId);

    Task<Region> UpsertRegionAsync(Region region);

    Task DeleteRegionAsync(Guid regionId);
}