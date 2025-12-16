using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class PlayerBaseSubmissionRequest : BaseSubmissionRequest
{
    public string PlayerBaseName { get; set; } = null!;

    public PlayerBaseClassificationTypes? Classification { get; set; }

    public string? PlanetGlyph { get; set; }

    public string? NameOfPlayerBaseBuilder { get; set; }

    public PlayerBaseTypes? BaseType { get; set; }

    public bool? HasFarmProduction { get; set; }

    public bool? HasGeobay { get; set; }

    public bool? HasPvpArena { get; set; }

    public bool? HasLandingPad { get; set; }

    public bool? HasRaceTrack { get; set; }

    public bool? HasTradeTerminal { get; set; }

    public LocationTypes NearbyPOITypes { get; set; }

    public DateTimeOffset? ConstructionStarted { get; set; }

    public DateTimeOffset? ConstructionEnded { get; set; }

    public PlayerBasePowerTypes? PowerConditions { get; set; }

    public PlayerBaseTerrainTypes? TerrainSituation { get; set; }

    public HashSet<HarvestedMaterialTypes> MineralExtractorContents { get; set; } = [];

    public string? MineralExtractorCapacity { get; set; }

    public HashSet<AtmosphereGasTypes> GasExtractorContents { get; set; } = [];

    public string? GasExtractorCapacity { get; set; }

    public HashSet<PlayerBaseElementTypes> PlayerBaseElements { get; set; } = [];
}