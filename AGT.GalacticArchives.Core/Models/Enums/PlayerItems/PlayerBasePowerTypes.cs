using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

public enum PlayerBasePowerTypes
{
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.DoesNotRequirePower))]
    DoesNotRequirePower = 1,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.UnderpoweredResultingInPeriodsOfNoPower))]
    UnderpoweredResultingInPeriodsOfNoPower,
    Unpowered,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.PartiallyPoweredSomeElementsAppearUnpowered))]
    PartiallyPoweredSomeElementsAppearUnpowered,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.SufficientlyPowered))]
    SufficientlyPowered,
    [Display(
        ResourceType = typeof(PlayerBaseResource),
        Description = nameof(PlayerBaseResource.OverpoweredSignificantly))]
    OverpoweredSignificantly,
}