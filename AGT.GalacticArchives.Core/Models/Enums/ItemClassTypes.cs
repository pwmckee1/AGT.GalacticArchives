using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum ItemClassTypes
{
    S = 1,
    A,
    B,
    C,
    [Display(ResourceType = typeof(GoogleSheetResource), Description = nameof(GoogleSheetResource.NotApplicable))]
    NotApplicable,
}