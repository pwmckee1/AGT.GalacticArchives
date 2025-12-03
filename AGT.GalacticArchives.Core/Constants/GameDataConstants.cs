using System.Diagnostics.CodeAnalysis;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.GameData.BaseEntities;

namespace AGT.GalacticArchives.Core.Constants;

public static class GameDataConstants
{
    [SuppressMessage("Style", "IDE0060:Remove unused parameter")]
    public static HashSet<string> PropertiesExcludedFromDatabase<T>(this T entity)
    {
        var exclusions = new HashSet<string>
        {
            nameof(DatabaseEntity.EntityId),
            nameof(DatabaseEntity.CollectionName),
            nameof(DatabaseEntity.ParentCollectionName),
        };

        switch (typeof(T).Name)
        {
            case nameof(Galaxy):
                exclusions.UnionWith([nameof(Galaxy.Regions)]);
                break;
            case nameof(Region):
                exclusions.UnionWith(
                [
                    nameof(Region.StarSystems),
                    nameof(Region.Galaxy),
                ]);
                break;
            case nameof(StarSystem):
                exclusions.UnionWith(
                [
                    nameof(StarSystem.MultiTools),
                    nameof(StarSystem.Planets),
                    nameof(StarSystem.Region),
                    nameof(StarSystem.Starships),
                ]);
                break;
            case nameof(Planet):
                exclusions.UnionWith(
                [
                    nameof(Planet.StarSystem),
                    nameof(Planet.Fauna),
                    nameof(Planet.MultiTools),
                    nameof(Planet.PlayerBases),
                    nameof(Planet.PointsOfInterest),
                    nameof(Planet.Settlements),
                    nameof(Planet.Starships),
                ]);
                break;
            case nameof(MultiTool):
            case nameof(Starship):
                exclusions.UnionWith(
                [
                    nameof(InnerSystemEntity.StarSystem),
                    nameof(InnerSystemEntity.Planet),
                ]);
                break;
            case nameof(Fauna):
            case nameof(PlayerBase):
            case nameof(PointOfInterest):
            case nameof(Settlement):
                exclusions.UnionWith([nameof(InnerSystemEntity.Planet)]);
                break;
        }

        return exclusions;
    }
}