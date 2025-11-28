using Newtonsoft.Json;

namespace AGT.GalacticArchives.Core.Extensions;

public static class DictionaryExtensions
{
    public static bool HasAnyChanges(this Dictionary<string, object> first, Dictionary<string, object?> second)
    {
        if (first.Count == 0 && second.Count == 0)
            return true;

        if (first.Count == 0 || second.Count == 0)
            return false;

        var firstJson = JsonConvert.SerializeObject(first, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore
        });

        var secondJson = JsonConvert.SerializeObject(second, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore
        });

        return firstJson == secondJson;
    }
}