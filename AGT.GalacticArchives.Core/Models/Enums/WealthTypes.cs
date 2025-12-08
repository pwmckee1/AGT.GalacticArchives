using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum WealthTypes
{
    Adequate,
    Advanced,
    Affluent,
    Balanced,
    [Display(ResourceType = typeof(WealthTypeResource), Description = nameof(WealthTypeResource.BlackMarket))]
    BlackMarket,
    Booming,
    Comfortable,
    [Display(ResourceType = typeof(WealthTypeResource), Description = nameof(WealthTypeResource.DataUnavailable))]
    DataUnavailable,
    Declining,
    Destitute,
    Developing,
    Failing,
    Fledgling,
    Flourishing,
    [Display(ResourceType = typeof(WealthTypeResource), Description = nameof(WealthTypeResource.HighSupply))]
    HighSupply,
    [Display(ResourceType = typeof(WealthTypeResource), Description = nameof(WealthTypeResource.LowSupply))]
    LowSupply,
    [Display(ResourceType = typeof(WealthTypeResource), Description = nameof(WealthTypeResource.MediumSupply))]
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