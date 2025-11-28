namespace AGT.GalacticArchives.Core.Constants;

public static class BusinessRuleConstants
{
    public const int CacheDurationInMinutes = 5;
    public const int DayInMinutes = 1440;
    public const string ObfuscationStringSequence = "********";

    public static readonly IList<string> ObfuscateFieldList = new List<string>
    {
        "password",
        "currentPassword",
        "confirmPassword",
    };

    public static readonly IList<string> SanitizerRouteWhiteList = new List<string>
    {
        "/galaxy",
    };
}