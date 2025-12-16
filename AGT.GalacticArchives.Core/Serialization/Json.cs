using System.Collections;
using System.Reflection;
using System.Text;
using AGT.GalacticArchives.Core.Constants;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace AGT.GalacticArchives.Core.Serialization;

public static class Json
{
    /// <summary>
    ///     Searches the given json and removes any nodes with the fields specified
    /// </summary>
    /// <returns></returns>
    /// <param name="token"></param>
    /// <param name="fields"></param>
    public static JToken RemoveFields(this JToken token, string[] fields)
    {
        if (!(token is JContainer container))
        {
            return token;
        }

        var removeList = new List<JToken>();
        foreach (var el in container.Children())
        {
            if (el is JProperty p && ((IList)fields).Contains(p.Name))
            {
                removeList.Add(el);
            }

            el.RemoveFields(fields);
        }

        foreach (var el in removeList)
        {
            el.Remove();
        }

        return token;
    }

    /// <summary>
    /// Obfuscates the specified fields within the given json
    /// </summary>
    /// <param name="token"></param>
    /// <param name="fields"></param>
    /// <returns></returns>
    public static JToken ObfuscateFields(this JToken token, IList<string> fields)
    {
        if (!(token is JContainer container))
        {
            return token;
        }

        var removeList = new List<JProperty>();
        foreach (var el in container.Children())
        {
            if (el is JProperty p && fields.Contains(p.Name, StringComparer.CurrentCultureIgnoreCase))
            {
                removeList.Add(p);
            }

            el.ObfuscateFields(fields);
        }

        foreach (var el in removeList)
        {
            el.Value = BusinessRuleConstants.ObfuscationStringSequence;
        }

        return token;
    }

    public static bool TryParseJson<T>(
        this string item,
        out T result,
        MissingMemberHandling missingMemberHandling = MissingMemberHandling.Error) where T : class
    {
        var success = true;
        var settings = new JsonSerializerSettings
        {
            Error = (_, args) =>
            {
                success = false;
                args.ErrorContext.Handled = true;
            },
            MissingMemberHandling = missingMemberHandling,
        };
        var parsedResult = JsonConvert.DeserializeObject<T>(item, settings);

        if (parsedResult == null)
        {
            success = false;
        }

        result = parsedResult ?? null!;
        return success;
    }

    public static bool TryParseJson<T>(
        object? item,
        out T result,
        MissingMemberHandling missingMemberHandling = MissingMemberHandling.Error) where T : class
    {
        // ReSharper disable once MergeCastWithTypeCheck
        if (item is T)
        {
            result = (T)item;
            return true;
        }

        var itemBuilder = new StringBuilder();
        itemBuilder.Append(item);

        return TryParseJson(itemBuilder.ToString(), out result, missingMemberHandling);
    }

    public static bool CanParseJson<T>(this string item) where T : class
    {
        return item.TryParseJson(out T _);
    }

    public static T ParseJson<T>(
        this string item,
        MissingMemberHandling missingMemberHandling = MissingMemberHandling.Error) where T : class
    {
        return item.TryParseJson(out T jsonObject, missingMemberHandling) ? jsonObject : default!;
    }

    public static T ParseJson<T>(
        object? item,
        MissingMemberHandling missingMemberHandling = MissingMemberHandling.Error) where T : class
    {
        var itemBuilder = new StringBuilder();
        itemBuilder.Append(item);

        return item as T ?? ParseJson<T>(itemBuilder.ToString(), missingMemberHandling);
    }

    public class IgnorePropertiesResolver(IEnumerable<string> propNamesToIgnore) : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            property.ShouldSerialize = _ => !propNamesToIgnore.Contains(property.PropertyName);

            return property;
        }
    }
}