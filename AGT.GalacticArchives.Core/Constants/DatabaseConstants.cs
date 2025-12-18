using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Constants;

public static class DatabaseConstants
{
    public const int FirestoreInLimit = 10;
    public const string RegionCollection = "Regions";
    public const string StarSystemCollection = "Systems";
    public const string PlanetCollection = "Planets";
    public const string FaunaCollection = "Fauna";
    public const string MultiToolCollection = "MultiTools";
    public const string PlayerBaseCollection = "PlayerBases";
    public const string PointOfInterestCollection = "PointsOfInterest";
    public const string SettlementCollection = "Settlements";
    public const string StarshipCollection = "Starships";

    public static readonly string[] ExcludedQueryParameters =
    [
        nameof(BaseSearchRequest.PageNumber), nameof(BaseSearchRequest.PageSize), nameof(BaseSearchRequest.OrderBy),
    ];
}