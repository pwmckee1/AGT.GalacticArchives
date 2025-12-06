using AGT.GalacticArchives.Core.Constants;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.Imports;

public class PlayerBaseImport : IGoogleSheetImport
{
    [Name(PlayerBaseSheetFields.Name)]
    public string? Name { get; set; }

    [Name(PlayerBaseSheetFields.Planet)]
    public string? Planet { get; set; }

    [Name(PlayerBaseSheetFields.System)]
    public string? System { get; set; }

    [Name(PlayerBaseSheetFields.Region)]
    public string? Region { get; set; }

    [Name(PlayerBaseSheetFields.Galaxy)]
    public string? Galaxy { get; set; }

    [Name(PlayerBaseSheetFields.Coordinates)]
    public string? Coordinates { get; set; }

    [Name(PlayerBaseSheetFields.Glyph)]
    public string? Glyph { get; set; }

    [Name(PlayerBaseSheetFields.CivilizedBy)]
    public string? CivilizedBy { get; set; }

    [Name(PlayerBaseSheetFields.Builder)]
    public string? Builder { get; set; }

    [Name(PlayerBaseSheetFields.BuilderLinkOnWiki)]
    public string? BuilderLinkOnWiki { get; set; }

    [Name(PlayerBaseSheetFields.YYFirstCoordinate)]
    public string? YYFirstCoordinate { get; set; }

    [Name(PlayerBaseSheetFields.XXSecondCoordinate)]
    public string? XXSecondCoordinate { get; set; }

    [Name(PlayerBaseSheetFields.Platform)]
    public string? Platform { get; set; }

    [Name(PlayerBaseSheetFields.Mode)]
    public string? Mode { get; set; }

    [Name(PlayerBaseSheetFields.Release)]
    public string? Release { get; set; }

    [Name(PlayerBaseSheetFields.TypeOfBase)]
    public string? TypeOfBase { get; set; }

    [Name(PlayerBaseSheetFields.HasFarm)]
    public string? HasFarm { get; set; }

    [Name(PlayerBaseSheetFields.HasGeoBay)]
    public string? HasGeoBay { get; set; }

    [Name(PlayerBaseSheetFields.HasArena)]
    public string? HasArena { get; set; }

    [Name(PlayerBaseSheetFields.HasLandingPad)]
    public string? HasLandingPad { get; set; }

    [Name(PlayerBaseSheetFields.HasRacetrack)]
    public string? HasRacetrack { get; set; }

    [Name(PlayerBaseSheetFields.HasTradeTerminal)]
    public string? HasTradeTerminal { get; set; }

    [Name(PlayerBaseSheetFields.NearbyPOI1)]
    public string? NearbyPOI1 { get; set; }

    [Name(PlayerBaseSheetFields.NearbyPOI2)]
    public string? NearbyPOI2 { get; set; }

    [Name(PlayerBaseSheetFields.NearbyPOI3)]
    public string? NearbyPOI3 { get; set; }

    [Name(PlayerBaseSheetFields.NearbyPOI4)]
    public string? NearbyPOI4 { get; set; }

    [Name(PlayerBaseSheetFields.NearbyPOI5)]
    public string? NearbyPOI5 { get; set; }

    [Name(PlayerBaseSheetFields.DateStarted)]
    public string? DateStarted { get; set; }

    [Name(PlayerBaseSheetFields.DateFinished)]
    public string? DateFinished { get; set; }

    [Name(PlayerBaseSheetFields.DateOfSurvey)]
    public string? DateOfSurvey { get; set; }

    [Name(PlayerBaseSheetFields.Surveyor)]
    public string? Surveyor { get; set; }

    [Name(PlayerBaseSheetFields.SummaryText)]
    public string? SummaryText { get; set; }

    [Name(PlayerBaseSheetFields.LayoutDescription)]
    public string? LayoutDescription { get; set; }

    [Name(PlayerBaseSheetFields.AdditionalNotes)]
    public string? AdditionalNotes { get; set; }

    [Name(PlayerBaseSheetFields.PowerSituation)]
    public string? PowerSituation { get; set; }

    [Name(PlayerBaseSheetFields.AccessOrTerrainSituation)]
    public string? AccessOrTerrainSituation { get; set; }

    [Name(PlayerBaseSheetFields.MiningExtractor)]
    public string? MiningExtractor { get; set; }

    [Name(PlayerBaseSheetFields.MiningStoreCapacity)]
    public string? MiningStoreCapacity { get; set; }

    [Name(PlayerBaseSheetFields.GasExtractor)]
    public string? GasExtractor { get; set; }

    [Name(PlayerBaseSheetFields.GasStoreCapacity)]
    public string? GasStoreCapacity { get; set; }

    [Name(PlayerBaseSheetFields.BaseElements1)]
    public string? BaseElements1 { get; set; }

    [Name(PlayerBaseSheetFields.BaseElements2)]
    public string? BaseElements2 { get; set; }

    [Name(PlayerBaseSheetFields.BaseElements3)]
    public string? BaseElements3 { get; set; }

    [Name(PlayerBaseSheetFields.BaseElements4)]
    public string? BaseElements4 { get; set; }

    [Name(PlayerBaseSheetFields.BaseElements5)]
    public string? BaseElements5 { get; set; }

    [Name(PlayerBaseSheetFields.BaseElements6)]
    public string? BaseElements6 { get; set; }

    [Name(PlayerBaseSheetFields.BaseElements7)]
    public string? BaseElements7 { get; set; }

    [Name(PlayerBaseSheetFields.BaseElements8)]
    public string? BaseElements8 { get; set; }

    [Name(PlayerBaseSheetFields.Aesthetics)]
    public string? Aesthetics { get; set; }

    [Name(PlayerBaseSheetFields.BaseComplexity)]
    public string? BaseComplexity { get; set; }

    [Name(PlayerBaseSheetFields.PersonalNotes)]
    public string? PersonalNotes { get; set; }

    [Name(PlayerBaseSheetFields.BaseType)]
    public string? BaseType { get; set; }

    [Name(PlayerBaseSheetFields.WikiLink)]
    public string? WikiLink { get; set; }

    [Name(PlayerBaseSheetFields.DocSequence)]
    public string? DocSequence { get; set; }

    [Name(PlayerBaseSheetFields.Videos)]
    public string? Videos { get; set; }

    [Name(PlayerBaseSheetFields.ExternalLink1)]
    public string? ExternalLink1 { get; set; }

    [Name(PlayerBaseSheetFields.ExternalLink2)]
    public string? ExternalLink2 { get; set; }

    [Name(PlayerBaseSheetFields.PortalRepositoryLink)]
    public string? PortalRepositoryLink { get; set; }

    [Name(PlayerBaseSheetFields.AllowsDeconstruction)]
    public string? AllowsDeconstruction { get; set; }

    [Name(PlayerBaseSheetFields.ReleaseVersion)]
    public string? ReleaseVersion { get; set; }
}