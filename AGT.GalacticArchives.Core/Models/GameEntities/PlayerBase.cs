using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

namespace AGT.GalacticArchives.Core.Models.GameEntities;

public class PlayerBase : DatabaseGameEntity
{
    public Guid PlayerBaseId { get; set; } = Guid.NewGuid();

    public override Guid EntityId => PlayerBaseId;

    public string? BuilderName { get; set; }

    public string? BuilderLinkOnWiki { get; set; }

    public PlayerBaseTypes? TypeOfBase { get; set; }

    public bool? HasFarm { get; set; }

    public bool? HasGeobay { get; set; }

    public bool? HasArena { get; set; }

    public bool? HasLandingPad { get; set; }

    public bool? HasRacetrack { get; set; }

    public bool? HasTradeTerminal { get; set; }

    public HashSet<LocationTypes?> NearByPointsOfInterest { get; set; } = [];

    public DateTimeOffset? DateStarted { get; set; }

    public DateTimeOffset? DateFinished { get; set; }

    public string? SummaryText { get; set; }

    public string? LayoutDescription { get; set; }

    public PlayerBasePowerTypes? PowerSituation { get; set; }

    public PlayerBaseTerrainTypes? AccessOrTerrainSituation { get; set; }

    public HashSet<HarvestedMaterialTypes> MineralExtractorContents { get; set; } = [];

    public int? MineralExtractorCapacity { get; set; }

    public HashSet<AtmosphereGasTypes> GasExtractorContents { get; set; } = [];

    public int? GasExtractorCapacity { get; set; }

    public HashSet<PlayerBaseElementTypes> BaseElements { get; set; } = [];

    public int? AestheticsRating { get; set; }

    public int? BaseComplexity { get; set; }

    public string? PersonalNotes { get; set; }

    public PlayerBaseClassificationTypes? PlayerBaseClassification { get; set; }

    public string? Videos { get; set; }

    public string? ExternalLink1 { get; set; }

    public string? ExternalLink2 { get; set; }

    public string? PortalRepositoryLink { get; set; }

    public bool? AllowsDeconstruction { get; set; }
}