using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Models;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class FaunaImport : IGoogleSheetImport
{
    public string? Activity { get; set; }

    [Name(FaunaSheetFields.AdditionalNotes)]
    public string? AdditionalNotes { get; set; }

    public string? Appearance { get; set; }

    public string? Bait { get; set; }

    public string? Behaviour { get; set; }

    [Name(FaunaSheetFields.BehaviourType)]
    public string? BehaviourType { get; set; }

    [Name(FaunaSheetFields.CivilizedBy)]
    public string? CivilizedBy { get; set; }

    public string? Diet { get; set; }

    [Name(FaunaSheetFields.DietType)]
    public string? DietType { get; set; }

    [Name(FaunaSheetFields.DiscoveredBy)]
    public string? DiscoveredBy { get; set; }

    [Name(FaunaSheetFields.DiscoveredDate)]
    public string? DiscoveredDate { get; set; }

    [Name(FaunaSheetFields.DiscoveredLinkOnWiki)]
    public string? DiscoveredLinkOnWiki { get; set; }

    [Name(FaunaSheetFields.DiscoveryMenu)]
    public string? DiscoveryMenu { get; set; }

    [Name(FaunaSheetFields.DiscoveryPlatform)]
    public string? DiscoveryPlatform { get; set; }

    [Name(FaunaSheetFields.DiscoveryScreenHeight)]
    public string? DiscoveryScreenHeight { get; set; }

    [Name(FaunaSheetFields.DiscoveryScreenWeight)]
    public string? DiscoveryScreenWeight { get; set; }

    [Name(FaunaSheetFields.DocSeq)]
    public string? DocSeq { get; set; }

    public string? Ecosystem { get; set; }

    [Name(FaunaSheetFields.ExtinctionStatus)]
    public string? ExtinctionStatus { get; set; }

    public string? Galaxy { get; set; }

    [Name(FaunaSheetFields.Gender1)]
    public string? Gender1 { get; set; }

    [Name(FaunaSheetFields.Gender1ScanMaxHeight)]
    public string? Gender1ScanMaxHeight { get; set; }

    [Name(FaunaSheetFields.Gender1ScanMaxWeight)]
    public string? Gender1ScanMaxWeight { get; set; }

    [Name(FaunaSheetFields.Gender2)]
    public string? Gender2 { get; set; }

    [Name(FaunaSheetFields.Gender2ScanMaxHeight)]
    public string? Gender2ScanMaxHeight { get; set; }

    [Name(FaunaSheetFields.Gender2ScanMaxWeight)]
    public string? Gender2ScanMaxWeight { get; set; }

    public string? Genus { get; set; }

    [Name(FaunaSheetFields.GenusSubtype)]
    public string? GenusSubtype { get; set; }

    public string? Hemisphere { get; set; }

    [Name(FaunaSheetFields.LegacyFaunaDatePC)]
    public string? LegacyFaunaDatePC { get; set; }

    [Name(FaunaSheetFields.LegacyFaunaDatePS)]
    public string? LegacyFaunaDatePS { get; set; }

    [Name(FaunaSheetFields.LegacyFaunaDateXbox)]
    public string? LegacyFaunaDateXbox { get; set; }

    [Name(FaunaSheetFields.LegacyFaunaDiscovererPC)]
    public string? LegacyFaunaDiscovererPC { get; set; }

    [Name(FaunaSheetFields.LegacyFaunaDiscovererPS)]
    public string? LegacyFaunaDiscovererPS { get; set; }

    [Name(FaunaSheetFields.LegacyFaunaDiscovererXbox)]
    public string? LegacyFaunaDiscovererXbox { get; set; }

    [Name(FaunaSheetFields.LegacyFaunaNamePC)]
    public string? LegacyFaunaNamePC { get; set; }

    [Name(FaunaSheetFields.LegacyFaunaNamePS)]
    public string? LegacyFaunaNamePS { get; set; }

    [Name(FaunaSheetFields.LegacyFaunaNameXbox)]
    public string? LegacyFaunaNameXbox { get; set; }

    [Name(FaunaSheetFields.LocationNotes)]
    public string? LocationNotes { get; set; }

    public string? Mode { get; set; }

    [Name(FaunaSheetFields.Name)]
    public string? Name { get; set; }

    [Name(FaunaSheetFields.NameAfterExpeditions)]
    public string? NameAfterExpeditions { get; set; }

    [Name(FaunaSheetFields.NMSWikiLink)]
    public string? NMSWikiLink { get; set; }

    public string? Notes { get; set; }

    [Name(FaunaSheetFields.OriginalName)]
    public string? OriginalName { get; set; }

    public string? Planet { get; set; }

    public string? Produces { get; set; }

    public string? Rarity { get; set; }

    public string? Region { get; set; }

    public string? Release { get; set; }

    [Name(FaunaSheetFields.ResearchTeam)]
    public string? ResearchTeam { get; set; }

    [Name(FaunaSheetFields.SummaryNotes)]
    public string? SummaryNotes { get; set; }

    public string? System { get; set; }

    [Name(FaunaSheetFields.VersionRelease)]
    public string? VersionRelease { get; set; }
}