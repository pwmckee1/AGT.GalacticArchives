using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Models;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class SettlementImport : IGoogleSheetImport
{
    [Name(SettlementSheetFields.Building1)]
    public string? Building1 { get; set; }

    [Name(SettlementSheetFields.Building2)]
    public string? Building2 { get; set; }

    [Name(SettlementSheetFields.Building3)]
    public string? Building3 { get; set; }

    [Name(SettlementSheetFields.Building4)]
    public string? Building4 { get; set; }

    [Name(SettlementSheetFields.Building5)]
    public string? Building5 { get; set; }

    [Name(SettlementSheetFields.Building6)]
    public string? Building6 { get; set; }

    [Name(SettlementSheetFields.Class)]
    public string? Class { get; set; }

    [Name(SettlementSheetFields.Civilized)]
    public string? Civilized { get; set; }

    [Name(SettlementSheetFields.DateObserved)]
    public string? DateObserved { get; set; }

    [Name(SettlementSheetFields.Economy)]
    public string? Economy { get; set; }

    [Name(SettlementSheetFields.GameRelease)]
    public string? GameRelease { get; set; }

    [Name(SettlementSheetFields.Happiness)]
    public string? Happiness { get; set; }

    [Name(SettlementSheetFields.Industry)]
    public string? Industry { get; set; }

    [Name(SettlementSheetFields.Maintenance)]
    public string? Maintenance { get; set; }

    [Name(SettlementSheetFields.Mode)]
    public string? Mode { get; set; }

    [Name(SettlementSheetFields.Name)]
    public string? Name { get; set; }

    [Name(SettlementSheetFields.OriginalName)]
    public string? OriginalName { get; set; }

    [Name(SettlementSheetFields.Overseer)]
    public string? Overseer { get; set; }

    [Name(SettlementSheetFields.OverseerLink)]
    public string? OverseerLink { get; set; }

    [Name(SettlementSheetFields.Planet)]
    public string? Planet { get; set; }

    [Name(SettlementSheetFields.Population)]
    public string? Population { get; set; }

    [Name(SettlementSheetFields.Production)]
    public string? Production { get; set; }

    [Name(SettlementSheetFields.Productivity)]
    public string? Productivity { get; set; }

    [Name(SettlementSheetFields.Profitable)]
    public string? Profitable { get; set; }

    [Name(SettlementSheetFields.Sentinel)]
    public string? Sentinel { get; set; }

    [Name(SettlementSheetFields.Surveyor)]
    public string? Surveyor { get; set; }

    [Name(SettlementSheetFields.System)]
    public string? System { get; set; }

    [Name(SettlementSheetFields.WikiLink)]
    public string? WikiLink { get; set; }

    [Name(SettlementSheetFields.XXSecondCoordinate)]
    public string? XXSecondCoordinate { get; set; }

    [Name(SettlementSheetFields.YYFirstCoordinate)]
    public string? YYFirstCoordinate { get; set; }
}