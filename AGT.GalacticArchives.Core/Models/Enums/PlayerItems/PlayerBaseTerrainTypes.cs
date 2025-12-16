using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

public enum PlayerBaseTerrainTypes
{
    [Display(ResourceType = typeof(PlayerBaseResource), Description = nameof(PlayerBaseResource.NoObstruction))]
    NoObstruction = 1,
    [Display(ResourceType = typeof(PlayerBaseResource), Description = nameof(PlayerBaseResource.InaccessibleEntryways))]
    InaccessibleEntryways,
    [Display(ResourceType = typeof(PlayerBaseResource), Description = nameof(PlayerBaseResource.MinorObstructionNoFunctionalImpairment))]
    MinorObstructionNoFunctionalImpairment,
    [Display(ResourceType = typeof(PlayerBaseResource), Description = nameof(PlayerBaseResource.SomeObstructionSomeFunctionalImpairment))]
    SomeObstructionSomeFunctionalImpairment,
    [Display(ResourceType = typeof(PlayerBaseResource), Description = nameof(PlayerBaseResource.MajorObstructionSignificantFunctionalImpairment))]
    MajorObstructionSignificantFunctionalImpairment,
}