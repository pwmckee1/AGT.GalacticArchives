using AGT.GalacticArchives.Core.Constants.ImportFields;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class PlayerBaseImport : IImportFormFile
{
    [Name(PlayerBaseSheetFields.PlayerBaseId)]
    public Guid? PlayerBaseId { get; set; }

    [Name(PlayerBaseSheetFields.AccessOrTerrainSituation)]
    public PlayerBaseTerrainTypes? AccessOrTerrainSituation { get; set; }

    [Name(PlayerBaseSheetFields.AdditionalNotes)]
    public string? AdditionalNotes { get; set; }

    [Name(PlayerBaseSheetFields.AllowsDeconstruction)]
    public bool? AllowsDeconstruction { get; set; }

    [Name(PlayerBaseSheetFields.AestheticsRating)]
    public int? AestheticsRating { get; set; }

    [Name(PlayerBaseSheetFields.BaseComplexity)]
    public int? BaseComplexity { get; set; }

    [Name(PlayerBaseSheetFields.BaseElements)]
    public HashSet<PlayerBaseElementTypes> BaseElements { get; set; } = [];

    [Name(PlayerBaseSheetFields.PlayerBaseClassification)]
    public PlayerBaseClassificationTypes? PlayerBaseClassification { get; set; }

    [Name(PlayerBaseSheetFields.BuilderName)]
    public string? BuilderName { get; set; }

    [Name(PlayerBaseSheetFields.BuilderLinkOnWiki)]
    public string? BuilderLinkOnWiki { get; set; }

    [Name(PlayerBaseSheetFields.Civilization)]
    public string? Civilization { get; set; }

    [Name(PlayerBaseSheetFields.GalacticCoordinates)]
    public string? GalacticCoordinates { get; set; }

    [Name(PlayerBaseSheetFields.DateFinished)]
    public DateTimeOffset? DateFinished { get; set; }

    [Name(PlayerBaseSheetFields.SurveyDate)]
    public DateTimeOffset? SurveyDate { get; set; }

    [Name(PlayerBaseSheetFields.DateStarted)]
    public DateTimeOffset? DateStarted { get; set; }

    [Name(PlayerBaseSheetFields.DocumentSequence)]
    public int? DocumentSequence { get; set; }

    [Name(PlayerBaseSheetFields.ExternalLink1)]
    public string? ExternalLink1 { get; set; }

    [Name(PlayerBaseSheetFields.ExternalLink2)]
    public string? ExternalLink2 { get; set; }

    [Name(PlayerBaseSheetFields.Galaxy)]
    public GalaxyTypes? Galaxy { get; set; }

    [Name(PlayerBaseSheetFields.GasExtractorContents)]
    public HashSet<AtmosphereGasTypes> GasExtractorContents { get; set; } = [];

    [Name(PlayerBaseSheetFields.GasExtractorCapacity)]
    public int? GasExtractorCapacity { get; set; }

    [Name(PlayerBaseSheetFields.GlyphHexCode)]
    public string? GlyphHexCode { get; set; }

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

    [Name(PlayerBaseSheetFields.MineralExtractorContents)]
    public HashSet<HarvestedMaterialTypes> MineralExtractorContents { get; set; } = [];

    [Name(PlayerBaseSheetFields.MineralExtractorCapacity)]
    public int? MineralExtractorCapacity { get; set; }

    [Name(PlayerBaseSheetFields.GameModeType)]
    public GameModeTypes? GameModeType { get; set; }

    [Name(PlayerBaseSheetFields.Name)]
    public string? PlayerBaseName { get; set; }

    [Name(PlayerBaseSheetFields.NearByPointsOfInterest)]
    public HashSet<LocationTypes> NearByPointsOfInterest { get; set; } = [];

    [Name(PlayerBaseSheetFields.PersonalNotes)]
    public string? PersonalNotes { get; set; }

    [Name(PlayerBaseSheetFields.Planet)]
    public string? PlanetName { get; set; }

    [Name(PlayerBaseSheetFields.GamePlatformType)]
    public GamePlatformTypes? GamePlatformType { get; set; }

    [Name(PlayerBaseSheetFields.PortalRepositoryLink)]
    public string? PortalRepositoryLink { get; set; }

    [Name(PlayerBaseSheetFields.PowerSituation)]
    public PlayerBasePowerTypes? PowerSituation { get; set; }

    [Name(PlayerBaseSheetFields.Region)]
    public string? RegionName { get; set; }

    [Name(PlayerBaseSheetFields.GameRelease)]
    public string? GameRelease { get; set; }

    [Name(PlayerBaseSheetFields.GameReleaseVersionNumber)]
    public string? GameReleaseVersionNumber { get; set; }

    [Name(PlayerBaseSheetFields.SummaryText)]
    public string? SummaryText { get; set; }

    [Name(PlayerBaseSheetFields.SurveyedBy)]
    public string? SurveyedBy { get; set; }

    [Name(PlayerBaseSheetFields.StarSystem)]
    public string? StarSystemName { get; set; }

    [Name(PlayerBaseSheetFields.TypeOfBase)]
    public PlayerBaseTypes? TypeOfBase { get; set; }

    [Name(PlayerBaseSheetFields.Videos)]
    public string? Videos { get; set; }

    [Name(PlayerBaseSheetFields.WikiLink)]
    public string? WikiLink { get; set; }

    [Name(PlayerBaseSheetFields.XXSecondCoordinate)]
    public float? XAxisPlanetCoordinate { get; set; }

    [Name(PlayerBaseSheetFields.YAxisPlanetCoordinate)]
    public float? YAxisPlanetCoordinate { get; set; }

    [Name(PlayerBaseSheetFields.RegionId)]
    public Guid? RegionId { get; set; }

    [Name(PlayerBaseSheetFields.StarSystemId)]
    public Guid? StarSystemId { get; set; }

    [Name(PlayerBaseSheetFields.PlanetId)]
    public Guid? PlanetId { get; set; }
}