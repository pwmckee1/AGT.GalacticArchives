using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class PlayerBaseImport : IGoogleSheetImport
{
    [Name(PlayerBaseSheetFields.AccessOrTerrainSituation)]
    public PlayerBaseTerrainTypes? AccessOrTerrainSituation { get; set; }

    [Name(PlayerBaseSheetFields.AdditionalNotes)]
    public string? AdditionalNotes { get; set; }

    [Name(PlayerBaseSheetFields.AllowsDeconstruction)]
    public bool? AllowsDeconstruction { get; set; }

    [Name(PlayerBaseSheetFields.Aesthetics)]
    public int? Aesthetics { get; set; }

    [Name(PlayerBaseSheetFields.BaseComplexity)]
    public int? BaseComplexity { get; set; }

    [Name(PlayerBaseSheetFields.BaseElements)]
    public HashSet<PlayerBaseElementTypes> BaseElements { get; set; } = [];

    [Name(PlayerBaseSheetFields.BaseType)]
    public PlayerBaseTypes? BaseType { get; set; }

    [Name(PlayerBaseSheetFields.Builder)]
    public string? Builder { get; set; }

    [Name(PlayerBaseSheetFields.BuilderLinkOnWiki)]
    public string? BuilderLinkOnWiki { get; set; }

    [Name(PlayerBaseSheetFields.CivilizedBy)]
    public string? CivilizedBy { get; set; }

    [Name(PlayerBaseSheetFields.Coordinates)]
    public string? Coordinates { get; set; }

    [Name(PlayerBaseSheetFields.DateFinished)]
    public DateTime? DateFinished { get; set; }

    [Name(PlayerBaseSheetFields.DateOfSurvey)]
    public DateTime? DateOfSurvey { get; set; }

    [Name(PlayerBaseSheetFields.DateStarted)]
    public DateTime? DateStarted { get; set; }

    [Name(PlayerBaseSheetFields.DocSequence)]
    public int? DocSequence { get; set; }

    [Name(PlayerBaseSheetFields.ExternalLink1)]
    public string? ExternalLink1 { get; set; }

    [Name(PlayerBaseSheetFields.ExternalLink2)]
    public string? ExternalLink2 { get; set; }

    [Name(PlayerBaseSheetFields.Galaxy)]
    public GalaxyTypes? Galaxy { get; set; }

    [Name(PlayerBaseSheetFields.GasExtractor)]
    public AtmosphereMaterialTypes? GasExtractor { get; set; }

    [Name(PlayerBaseSheetFields.GasStoreCapacity)]
    public int? GasStoreCapacity { get; set; }

    [Name(PlayerBaseSheetFields.Glyph)]
    public string? Glyph { get; set; }

    [Name(PlayerBaseSheetFields.HasArena)]
    public bool? HasArena { get; set; }

    [Name(PlayerBaseSheetFields.HasFarm)]
    public bool? HasFarm { get; set; }

    [Name(PlayerBaseSheetFields.HasGeoBay)]
    public bool? HasGeoBay { get; set; }

    [Name(PlayerBaseSheetFields.HasLandingPad)]
    public bool? HasLandingPad { get; set; }

    [Name(PlayerBaseSheetFields.HasRacetrack)]
    public bool? HasRacetrack { get; set; }

    [Name(PlayerBaseSheetFields.HasTradeTerminal)]
    public bool? HasTradeTerminal { get; set; }

    [Name(PlayerBaseSheetFields.LayoutDescription)]
    public string? LayoutDescription { get; set; }

    [Name(PlayerBaseSheetFields.MiningExtractorMaterial)]
    public HarvestedMaterialType? MiningExtractorMaterial { get; set; }

    [Name(PlayerBaseSheetFields.MiningStoreCapacity)]
    public int? MiningStoreCapacity { get; set; }

    [Name(PlayerBaseSheetFields.Mode)]
    public GameModeTypes? Mode { get; set; }

    [Name(PlayerBaseSheetFields.Name)]
    public string? Name { get; set; }

    [Name(PlayerBaseSheetFields.NearbyPOI)]
    public HashSet<LocationTypes> NearbyPOI { get; set; } = [];

    [Name(PlayerBaseSheetFields.PersonalNotes)]
    public string? PersonalNotes { get; set; }

    [Name(PlayerBaseSheetFields.Planet)]
    public string? Planet { get; set; }

    [Name(PlayerBaseSheetFields.Platform)]
    public GamePlatformTypes? Platform { get; set; }

    [Name(PlayerBaseSheetFields.PortalRepositoryLink)]
    public string? PortalRepositoryLink { get; set; }

    [Name(PlayerBaseSheetFields.PowerSituation)]
    public PlayerBasePowerTypes? PowerSituation { get; set; }

    [Name(PlayerBaseSheetFields.Region)]
    public string? Region { get; set; }

    [Name(PlayerBaseSheetFields.Release)]
    public string? Release { get; set; }

    [Name(PlayerBaseSheetFields.ReleaseVersion)]
    public string? ReleaseVersion { get; set; }

    [Name(PlayerBaseSheetFields.SummaryText)]
    public string? SummaryText { get; set; }

    [Name(PlayerBaseSheetFields.Surveyor)]
    public string? Surveyor { get; set; }

    [Name(PlayerBaseSheetFields.StarSystem)]
    public string? StarSystem { get; set; }

    [Name(PlayerBaseSheetFields.TypeOfBase)]
    public PlayerBaseTypes? TypeOfBase { get; set; }

    [Name(PlayerBaseSheetFields.Videos)]
    public string? Videos { get; set; }

    [Name(PlayerBaseSheetFields.WikiLink)]
    public string? WikiLink { get; set; }

    [Name(PlayerBaseSheetFields.XXSecondCoordinate)]
    public float? XXSecondCoordinate { get; set; }

    [Name(PlayerBaseSheetFields.YYFirstCoordinate)]
    public float? YYFirstCoordinate { get; set; }
}