namespace AGT.GalacticArchives.Core.Extensions;

using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Models.GameData;

public static class DatabaseExtensions
{
    public static string ToGameDataTypeName(this string collectionName)
    {
        return collectionName switch
        {
            DatabaseConstants.GalaxyCollection => nameof(Galaxy),
            DatabaseConstants.RegionCollection => nameof(Region),
            DatabaseConstants.StarSystemCollection => nameof(StarSystem),
            DatabaseConstants.PlanetCollection => nameof(Planet),
            DatabaseConstants.FaunaCollection => nameof(Fauna),
            DatabaseConstants.MultiToolCollection => nameof(MultiTool),
            DatabaseConstants.PlayerBaseCollection => nameof(PlayerBase),
            DatabaseConstants.PointOfInterestCollection => nameof(PointOfInterest),
            DatabaseConstants.SettlementCollection => nameof(Settlement),
            DatabaseConstants.StarshipCollection => nameof(Starship),
            _ => nameof(GameDataEntity),
        };
    }
}