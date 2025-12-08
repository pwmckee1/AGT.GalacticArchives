using AGT.GalacticArchives.Core.Models.Enums;

namespace AGT.GalacticArchives.Core.Models.Requests.Entities.UserSubmissions;

public class StarshipSubmissionRequest : BaseSubmissionRequest
{
    public string StarshipName { get; set; } = null!;

    public string? PilotName { get; set; }

    public StarshipLocationTypes StarshipLocationType { get; set; }

    public StarshipModelTypes? StarShipModelType { get; set; }

    public StarshipSubtypes? StarshipSubtype { get; set; }

    public StarshipThrusterTypes? StarshipThrusterType { get; set; }

    public bool IsLivingShip { get; set; }

    public ItemClassTypes? ItemClass { get; set; }

    public int? InventorySlots { get; set; }

    public int? TechSlots { get; set; }

    public float? Damage { get; set; }

    public float? Shield { get; set; }

    public float? Warp { get; set; }

    public float? Maneuver { get; set; }

    public EntityColorTypes? PrimaryColor { get; set; }

    public EntityColorTypes? SecondaryColor { get; set; }

    public EntityColorTypes? AccentColor { get; set; }
}