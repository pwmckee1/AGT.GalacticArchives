using AGT.GalacticArchives.Core.Constants.ImportFields;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class FaunaImport : IImportFormFile
{
    [Name(FaunaSheetFields.ActivityType)]
    public FaunaCircadianTypes? ActivityType { get; set; }

    [Name(FaunaSheetFields.AdditionalNotes)]
    public string? AdditionalNotes { get; set; }

    [Name(FaunaSheetFields.AppearanceNotes)]
    public string? AppearanceNotes { get; set; }

    [Name(FaunaSheetFields.FaunaBaitType)]
    public FaunaBaitTypes? FaunaBaitType { get; set; }

    [Name(FaunaSheetFields.BehaviourType)]
    public FaunaBehaviorTypes? BehaviourType { get; set; }

    [Name(FaunaSheetFields.BehaviourArchetype)]
    public FaunaBehaviorArchetypes? BehaviourArchetype { get; set; }

    [Name(FaunaSheetFields.Civilization)]
    public string? Civilization { get; set; }

    [Name(FaunaSheetFields.FaunaDietType)]
    public FaunaDietTypes? FaunaDietType { get; set; }

    [Name(FaunaSheetFields.FaunaDietArchetype)]
    public FaunaDietArchetypes? FaunaDietArchetype { get; set; }

    [Name(FaunaSheetFields.DiscoveredBy)]
    public string? DiscoveredBy { get; set; }

    [Name(FaunaSheetFields.DiscoveredDate)]
    public DateTime? DiscoveredDate { get; set; }

    [Name(FaunaSheetFields.DiscoveredLinkOnWiki)]
    public string? DiscoveredLinkOnWiki { get; set; }

    [Name(FaunaSheetFields.DiscoveryMenuNotes)]
    public string? DiscoveryMenuNotes { get; set; }

    [Name(FaunaSheetFields.GamePlatformType)]
    public GamePlatformTypes? GamePlatformType { get; set; }

    [Name(FaunaSheetFields.DiscoveryScreenHeight)]
    public float? DiscoveryScreenHeight { get; set; }

    [Name(FaunaSheetFields.DiscoveryScreenWeight)]
    public float? DiscoveryScreenWeight { get; set; }

    [Name(FaunaSheetFields.DocumentSequence)]
    public int? DocumentSequence { get; set; }

    [Name(FaunaSheetFields.EcosystemType)]
    public FaunaEcosystemTypes? EcosystemType { get; set; }

    [Name(FaunaSheetFields.IsExtinct)]
    public bool? IsExtinct { get; set; }

    [Name(FaunaSheetFields.Galaxy)]
    public GalaxyTypes? Galaxy { get; set; }

    [Name(FaunaSheetFields.Gender1)]
    public FaunaGenderTypes? Gender1 { get; set; }

    [Name(FaunaSheetFields.Gender1ScanMaxHeight)]
    public float? Gender1ScanMaxHeight { get; set; }

    [Name(FaunaSheetFields.Gender1ScanMaxWeight)]
    public float? Gender1ScanMaxWeight { get; set; }

    [Name(FaunaSheetFields.Gender2)]
    public FaunaGenderTypes? Gender2 { get; set; }

    [Name(FaunaSheetFields.Gender2ScanMaxHeight)]
    public float? Gender2ScanMaxHeight { get; set; }

    [Name(FaunaSheetFields.Gender2ScanMaxWeight)]
    public float? Gender2ScanMaxWeight { get; set; }

    [Name(FaunaSheetFields.GenusType)]
    public FaunaGenusTypes? GenusType { get; set; }

    [Name(FaunaSheetFields.GenusSubtype)]
    public FaunaGenusSubtypes? GenusSubtype { get; set; }

    [Name(FaunaSheetFields.HemisphereType)]
    public HemisphereTypes? HemisphereType { get; set; }

    [Name(FaunaSheetFields.LegacyFaunaDatePC)]
    public DateTime? LegacyFaunaDatePC { get; set; }

    [Name(FaunaSheetFields.LegacyFaunaDatePS)]
    public DateTime? LegacyFaunaDatePS { get; set; }

    [Name(FaunaSheetFields.LegacyFaunaDateXbox)]
    public DateTime? LegacyFaunaDateXbox { get; set; }

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

    [Name(FaunaSheetFields.GameModeType)]
    public GameModeTypes? GameModeType { get; set; }

    [Name(FaunaSheetFields.FaunaName)]
    public string? FaunaName { get; set; }

    [Name(FaunaSheetFields.NameAfterExpeditions)]
    public string? NameAfterExpeditions { get; set; }

    [Name(FaunaSheetFields.NMSWikiLink)]
    public string? NMSWikiLink { get; set; }

    [Name(FaunaSheetFields.Notes)]
    public string? Notes { get; set; }

    [Name(FaunaSheetFields.OriginalName)]
    public string? OriginalName { get; set; }

    [Name(FaunaSheetFields.Planet)]
    public string? PlanetName { get; set; }

    [Name(FaunaSheetFields.ProductionType)]
    public FaunaProductionTypes? ProductionType { get; set; }

    [Name(FaunaSheetFields.FaunaRarityType)]
    public FaunaRarityTypes? FaunaRarityType { get; set; }

    [Name(FaunaSheetFields.Region)]
    public string? RegionName { get; set; }

    [Name(FaunaSheetFields.Release)]
    public string? Release { get; set; }

    [Name(FaunaSheetFields.ResearchTeam)]
    public string? ResearchTeam { get; set; }

    [Name(FaunaSheetFields.SummaryNotes)]
    public string? SummaryNotes { get; set; }

    [Name(FaunaSheetFields.StarSystemName)]
    public string? StarSystemName { get; set; }

    [Name(FaunaSheetFields.VersionRelease)]
    public string? VersionRelease { get; set; }
}