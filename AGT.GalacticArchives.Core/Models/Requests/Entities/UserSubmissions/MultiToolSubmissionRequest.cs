using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.Meta;

namespace AGT.GalacticArchives.Core.Models.Requests.Entities.UserSubmissions;

public class MultiToolSubmissionRequest : BaseSubmissionRequest
{
    public string MultiToolName { get; set; } = null!;

    public MultiToolLocationTypes MultiToolLocationType { get; set; }

    public MultiToolTypes MultiToolType { get; set; }

    public ItemClassTypes Class { get; set; }

    // Between 8 and 60
    public int InventorySlots { get; set; }

    public string? Cost { get; set; }

    public bool? HasCrystals { get; set; }

    public bool? HasGlowtubes { get; set; }

    public float? Damage { get; set; }

    public float? Mining { get; set; }

    public float? Scanner { get; set; }

    public EntityColorTypes PrimaryColor { get; set; }

    public EntityColorTypes SecondaryColor { get; set; }
}