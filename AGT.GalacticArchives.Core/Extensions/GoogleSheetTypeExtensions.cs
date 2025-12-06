using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Models.Enums;

namespace AGT.GalacticArchives.Core.Extensions;

public static class GoogleSheetTypeExtensions
{
    public static string ToGoogleSheetImportServiceKey(this GoogleSheetTypes googleSheetType)
    {
        return googleSheetType switch
        {
            GoogleSheetTypes.Region => NamedKeys.Services.RegionService,
            GoogleSheetTypes.StarSystem => NamedKeys.Services.StarSystemService,
            GoogleSheetTypes.Planet => NamedKeys.Services.PlanetService,
            GoogleSheetTypes.Fauna => NamedKeys.Services.FaunaService,
            GoogleSheetTypes.MultiTool => NamedKeys.Services.MultiToolService,
            GoogleSheetTypes.PlayerBase => NamedKeys.Services.PlayerBaseService,
            GoogleSheetTypes.POI => NamedKeys.Services.PointOfInterestService,
            GoogleSheetTypes.Settlement => NamedKeys.Services.SettlementService,
            GoogleSheetTypes.Starship => NamedKeys.Services.StarshipService,
            _ => throw new ArgumentOutOfRangeException(nameof(googleSheetType), googleSheetType, null),
        };
    }
}