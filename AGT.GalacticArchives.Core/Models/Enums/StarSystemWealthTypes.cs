using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum StarSystemWealthTypes
{
    [Display(ResourceType = typeof(ApplicationResources), Description = nameof(ApplicationResources.NotApplicable))]
    NotApplicable,
    Adequate,
    Advanced,
    Affluent,
    Balanced,
    BlackMarket,
    Booming,
    Comfortable,
    DataUnavailable,
    Declining,
    Destitute,
    Developing,
    Failing,
    Fledgling,
    Flourishing,
    HighSupply,
    LowSupply,
    MediumSupply,
    Opulent,
    Promising,
    Prosperous,
    Satisfactory,
    Struggling,
    Sustainable,
    Unpromising,
    Unsuccessful,
    Wealthy,
}