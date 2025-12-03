namespace AGT.GalacticArchives.Core.Constants;

public static class BusinessRuleConstants
{
    public const int CacheDurationInMinutes = 5;
    public const int DayInMinutes = 1440;
    public const string ObfuscationStringSequence = "********";
    public const string ValueFieldName = "value__";

#pragma warning disable S3887
#pragma warning disable S2386
    public static readonly IList<string> ObfuscateFieldList =
    [
        "password",
        "currentPassword",
        "confirmPassword",
    ];

    public static readonly IList<string> SanitizerRouteWhiteList =
    [
        "/galaxy",
    ];
#pragma warning restore S2386
#pragma warning restore S3887
}