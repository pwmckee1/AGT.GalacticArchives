using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Constants.Application;

public static class NamedKeys
{
    public static class Services
    {
        public const string RegionService = nameof(RegionService);
        public const string StarSystemService = nameof(StarSystemService);
        public const string PlanetService = nameof(PlanetService);
        public const string FaunaService = nameof(FaunaService);
        public const string MultiToolService = nameof(MultiToolService);
        public const string PlayerBaseService = nameof(PlayerBaseService);
        public const string PointOfInterestService = nameof(PointOfInterestService);
        public const string SettlementService = nameof(SettlementService);
        public const string StarshipService = nameof(StarshipService);
        public const string FaunaImportService = nameof(FaunaImportService);
        public const string MultiToolImportService = nameof(PlanetImportService);
        public const string PlanetImportService = nameof(PlanetImportService);

        [Display(ResourceType = typeof(ImportResource), Description = nameof(ImportResource.PlayerBaseSheetName))]
        public const string PlayerBaseImportService = nameof(PlayerBaseImportService);
        [Display(ResourceType = typeof(ImportResource), Description = nameof(ImportResource.PointOfInterestSheetName))]
        public const string PointOfInterestImportService = nameof(PointOfInterestImportService);
        [Display(ResourceType = typeof(ImportResource), Description = nameof(ImportResource.RegionSheetName))]
        public const string RegionImportService = nameof(RegionImportService);
        [Display(ResourceType = typeof(ImportResource), Description = nameof(ImportResource.SettlementSheetName))]
        public const string SettlementImportService = nameof(SettlementImportService);
        [Display(ResourceType = typeof(ImportResource), Description = nameof(ImportResource.StarshipSheetName))]
        public const string StarshipImportService = nameof(StarshipImportService);
        [Display(ResourceType = typeof(ImportResource), Description = nameof(ImportResource.StarSystemSheetName))]
        public const string StarSystemImportService = nameof(StarSystemImportService);
    }

    public static class Managers
    {
        public const string FirestoreManager = nameof(FirestoreManager);
        public const string RegionManager = nameof(RegionManager);
        public const string StarSystemManager = nameof(StarSystemManager);
        public const string PlanetManager = nameof(PlanetManager);
        public const string EntityHierarchyManager = nameof(EntityHierarchyManager);
        public const string FaunaManager = nameof(FaunaManager);
        public const string GameDataManager = nameof(GameDataManager);
        public const string MultiToolManager = nameof(MultiToolManager);
        public const string PlayerBaseManager = nameof(PlayerBaseManager);
        public const string PointOfInterestManager = nameof(PointOfInterestManager);
        public const string SettlementManager = nameof(SettlementManager);
        public const string StarshipManager = nameof(StarshipManager);
    }

    public static class Handlers
    {
        public const string BaseImportValidationHandler = nameof(BaseImportValidationHandler);
        public const string FaunaImportValidationHandler = nameof(FaunaImportValidationHandler);
        public const string MultiToolImportValidationHandler = nameof(MultiToolImportValidationHandler);
        public const string PlanetImportValidationHandler = nameof(PlanetImportValidationHandler);
        public const string PlayerBaseImportValidationHandler = nameof(PlayerBaseImportValidationHandler);
        public const string PointOfInterestImportValidationHandler = nameof(PointOfInterestImportValidationHandler);
        public const string RegionImportValidationHandler = nameof(RegionImportValidationHandler);
        public const string SettlementImportValidationHandler = nameof(SettlementImportValidationHandler);
        public const string StarshipImportValidationHandler = nameof(StarshipImportValidationHandler);
        public const string StarSystemImportValidationHandler = nameof(StarSystemImportValidationHandler);
    }
}