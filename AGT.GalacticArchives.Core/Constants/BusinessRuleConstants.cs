namespace AGT.GalacticArchives.Core.Constants;

public static class BusinessRuleConstants
{
    public const int CacheDurationInMinutes = 5;
    public const int DayInMinutes = 1440;
    public const string ObfuscationStringSequence = "********";
    public const string ValueFieldName = "value__";

    public static readonly IEnumerable<string> ObfuscateFieldList = new HashSet<string>
    {
        "password",
        "currentPassword",
        "confirmPassword",
    };

    public static readonly IEnumerable<string> SanitizerRouteWhiteList = new HashSet<string>
    {
        "/galaxy",
    };
}