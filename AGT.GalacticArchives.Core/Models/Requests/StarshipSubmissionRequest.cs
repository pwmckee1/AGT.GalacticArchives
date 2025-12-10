using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class StarshipSubmissionRequest : BaseSubmissionRequest
{
    public string StarshipName { get; set; } = null!;

    public string? PilotName { get; set; }

    public StarshipLocationTypes StarshipLocationType { get; set; }

    public StarshipModelTypes? StarShipModelType { get; set; }

    public StarshipSubModelTypes? StarshipSubtype { get; set; }

    public StarshipThrusterTypes? StarshipThrusterType { get; set; }

    public bool? IsLivingShip { get; set; }

    public QualityClassTypes? ItemClass { get; set; }

    public int? InventorySlots { get; set; }

    public int? TechSlots { get; set; }

    public float? Damage { get; set; }

    public float? Shield { get; set; }

    public float? Warp { get; set; }

    public float? Maneuver { get; set; }

    public ItemColorTypes? PrimaryColor { get; set; }

    public ItemColorTypes? SecondaryColor { get; set; }

    public ItemColorTypes? AccentColor { get; set; }
}