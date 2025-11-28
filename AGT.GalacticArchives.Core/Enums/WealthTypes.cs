using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Enums;

public enum WealthTypes
{
    Declining = 1,
    Destitute,
    Failing,
    Fledgling,
    [Display(ResourceType = typeof(WealthTypeResource), Description = nameof(WealthTypeResource.LowSupply))]
    LowSupply,
    Struggling,
    Unsuccessful,
    Unpromising,
    Adequate,
    Balanced,
    [Display(ResourceType = typeof(WealthTypeResource), Description = nameof(WealthTypeResource.BlackMarket))]
    BlackMarket,
    Comfortable,
    Developing,
    [Display(ResourceType = typeof(WealthTypeResource), Description = nameof(WealthTypeResource.MediumSupply))]
    MediumSupply,
    Promising,
    Satisfactory,
    Sustainable,
    Advanced,
    Affluent,
    Booming,
    Flourishing,
    [Display(ResourceType = typeof(WealthTypeResource), Description = nameof(WealthTypeResource.HighSupply))]
    HighSupply,
    Opulent,
    Prosperous,
    Wealthy,
    [Display(ResourceType = typeof(WealthTypeResource), Description = nameof(WealthTypeResource.DataUnavailable))]
    DataUnavailable,
}