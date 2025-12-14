using AGT.GalacticArchives.Core.Constants.ImportFields;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class MultiToolImport : IImportFormFile
{
    [Name(MultiToolSheetFields.MultiToolId)]
    public Guid? MultiToolId { get; set; }

    [Name(MultiToolSheetFields.AcquisitionGuidance)]
    public string? AcquisitionGuidance { get; set; }

    [Name(MultiToolSheetFields.Category)]
    public MultiToolCategoryTypes? Category { get; set; }

    [Name(MultiToolSheetFields.Class)]
    public ItemClassTypes? Class { get; set; }

    [Name(MultiToolSheetFields.Civilization)]
    public string? Civilization { get; set; }

    [Name(MultiToolSheetFields.Coordinates)]
    public string? Coordinates { get; set; }

    [Name(MultiToolSheetFields.Cost)]
    public int? Cost { get; set; }

    [Name(MultiToolSheetFields.Damage)]
    public float? Damage { get; set; }

    [Name(MultiToolSheetFields.DiscoveredBy)]
    public string? DiscoveredBy { get; set; }

    [Name(MultiToolSheetFields.DiscoveredLinkOnWiki)]
    public string? DiscoveredLinkOnWiki { get; set; }

    [Name(MultiToolSheetFields.DiscoveryDate)]
    public DateTime? DiscoveryDate { get; set; }

    [Name(MultiToolSheetFields.DocumentSequence)]
    public int? DocumentSequence { get; set; }

    [Name(MultiToolSheetFields.Galaxy)]
    public GalaxyTypes? Galaxy { get; set; }

    [Name(MultiToolSheetFields.HasCrystals)]
    public bool? HasCrystals { get; set; }

    [Name(MultiToolSheetFields.HasGlowTubes)]
    public bool? HasGlowTubes { get; set; }

    [Name(MultiToolSheetFields.HasHorns)]
    public bool? HasHorns { get; set; }

    [Name(MultiToolSheetFields.Location)]
    public LocationTypes? Location { get; set; }

    [Name(MultiToolSheetFields.Mining)]
    public float? Mining { get; set; }

    [Name(MultiToolSheetFields.GameModeType)]
    public GameModeTypes? GameModeType { get; set; }

    [Name(MultiToolSheetFields.MultiToolName)]
    public string? MultiToolName { get; set; }

    [Name(MultiToolSheetFields.PlanetName)]
    public string? PlanetName { get; set; }

    [Name(MultiToolSheetFields.Platform)]
    public GamePlatformTypes? Platform { get; set; }

    [Name(MultiToolSheetFields.PortalGlyphs)]
    public string? PortalGlyphs { get; set; }

    [Name(MultiToolSheetFields.PrimaryColor)]
    public ItemColorTypes? PrimaryColor { get; set; }

    [Name(MultiToolSheetFields.RegionName)]
    public string? RegionName { get; set; }

    [Name(MultiToolSheetFields.Release)]
    public string? Release { get; set; }

    [Name(MultiToolSheetFields.ResearchTeam)]
    public string? ResearchTeam { get; set; }

    [Name(MultiToolSheetFields.Scanner)]
    public float? Scanner { get; set; }

    [Name(MultiToolSheetFields.SecondaryColor)]
    public ItemColorTypes? SecondaryColor { get; set; }

    [Name(MultiToolSheetFields.TechSlots)]
    public int? TechSlots { get; set; }

    [Name(MultiToolSheetFields.StarSystem)]
    public string? StarSystemName { get; set; }

    [Name(MultiToolSheetFields.MultiToolType)]
    public MultiToolTypes? MultiToolType { get; set; }

    [Name(MultiToolSheetFields.UserNotes)]
    public string? UserNotes { get; set; }

    [Name(MultiToolSheetFields.WikiLink)]
    public string? WikiLink { get; set; }

    [Name(MultiToolSheetFields.XAxisPlanetCoordinate)]
    public float? XAxisPlanetCoordinate { get; set; }

    [Name(MultiToolSheetFields.YAxisPlanetCoordinate)]
    public float? YAxisPlanetCoordinate { get; set; }
}