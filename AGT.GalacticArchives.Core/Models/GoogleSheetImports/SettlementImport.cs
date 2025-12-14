using AGT.GalacticArchives.Core.Constants.ImportFields;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class SettlementImport : IImportFormFile
{
    [Name(SettlementSheetFields.SettlementId)]
    public Guid? SettlementId { get; set; }

    [Name(SettlementSheetFields.Buildings)]
    public HashSet<SettlementBuildingTypes> Buildings { get; set; } = [];

    [Name(SettlementSheetFields.Class)]
    public ItemClassTypes? Class { get; set; }

    [Name(SettlementSheetFields.Civilized)]
    public string? Civilized { get; set; }

    [Name(SettlementSheetFields.DateObserved)]
    public DateTime? DateObserved { get; set; }

    [Name(SettlementSheetFields.Economy)]
    public EconomyTypes? Economy { get; set; }

    [Name(SettlementSheetFields.GameRelease)]
    public string? GameRelease { get; set; }

    [Name(SettlementSheetFields.Happiness)]
    public int? Happiness { get; set; }

    [Name(SettlementSheetFields.Industry)]
    public string? Industry { get; set; }

    [Name(SettlementSheetFields.Maintenance)]
    public int? Maintenance { get; set; }

    [Name(SettlementSheetFields.GameMode)]
    public GameModeTypes? GameMode { get; set; }

    [Name(SettlementSheetFields.SettlementName)]
    public string? SettlementName { get; set; }

    [Name(SettlementSheetFields.OriginalName)]
    public string? OriginalName { get; set; }

    [Name(SettlementSheetFields.Overseer)]
    public string? Overseer { get; set; }

    [Name(SettlementSheetFields.OverseerLink)]
    public string? OverseerLink { get; set; }

    [Name(SettlementSheetFields.Planet)]
    public string? PlanetName { get; set; }

    [Name(SettlementSheetFields.Population)]
    public int? Population { get; set; }

    [Name(SettlementSheetFields.Production)]
    public string? Production { get; set; }

    [Name(SettlementSheetFields.Productivity)]
    public int? Productivity { get; set; }

    [Name(SettlementSheetFields.IsProfitable)]
    public bool? IsProfitable { get; set; }

    [Name(SettlementSheetFields.Sentinels)]
    public int? Sentinels { get; set; }

    [Name(SettlementSheetFields.Surveyor)]
    public string? Surveyor { get; set; }

    [Name(SettlementSheetFields.System)]
    public string? StarSystemName { get; set; }

    [Name(SettlementSheetFields.WikiLink)]
    public string? WikiLink { get; set; }

    [Name(SettlementSheetFields.XXSecondCoordinate)]
    public float? XXSecondCoordinate { get; set; }

    [Name(SettlementSheetFields.YYFirstCoordinate)]
    public float? YYFirstCoordinate { get; set; }
}