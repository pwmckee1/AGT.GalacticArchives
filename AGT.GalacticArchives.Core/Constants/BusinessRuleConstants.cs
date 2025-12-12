namespace AGT.GalacticArchives.Core.Constants;

public static class BusinessRuleConstants
{
    public const string? SettlementName = "Settlement Name";
    public const int CacheDurationInMinutes = 5;
    public const int DayInMinutes = 1440;
    public const string ObfuscationStringSequence = "********";
    public const string ValueFieldName = "value__";
    public const int StartingImportSheetLineNumber = 2;
    public const int MaxLengthStandardString = 200;

    public static readonly string[] ValidDateTimeFormats =
    [
        "yyyy-MM-dd",
        "yyyy-MM-dd HH:mm:ss",
        "yyyy-MMMM-dd",
        "yyyy-MMMM-dd HH:mm:ss",
        "dd-MM-yyyy",
        "dd-MM-yyyy HH:mm:ss",
        "dd-MMMM-yyyy",
        "dd-MMMM-yyyy HH:mm:ss",
        "MM/dd/yyyy",
        "MM/dd/yyyy HH:mm:ss",
        "dd/MM/yyyy",
        "dd/MM/yyyy HH:mm:ss",
    ];

    public static readonly IList<string> ObfuscateFieldList = ["password", "currentPassword", "confirmPassword",];

    public static readonly IList<string> SanitizerRouteWhiteList = ["/galaxy",];
}