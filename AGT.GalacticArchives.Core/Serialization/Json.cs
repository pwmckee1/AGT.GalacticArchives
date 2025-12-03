namespace AGT.GalacticArchives.Core.Serialization;

using System.Collections;
using System.Reflection;
using System.Text;
using AGT.GalacticArchives.Core.Constants;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

public static class Json
{
    /// <summary>
    ///     Searches the given json and removes any nodes with the fields specified
    /// </summary>
    /// <param name="token"></param>
    /// <param name="fields"></param>
    /// <returns></returns>
    public static JToken RemoveFields(this JToken token, string[] fields)
    {
        if (!(token is JContainer container)) return token;

        var removeList = new List<JToken>();
        foreach (var el in container.Children())
        {
            if (el is JProperty p && ((IList)fields).Contains(p.Name)) removeList.Add(el);

            el.RemoveFields(fields);
        }

        foreach (var el in removeList) el.Remove();

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
        if (!(token is JContainer container)) return token;

        var removeList = new List<JProperty>();
        foreach (var el in container.Children())
        {
            if (el is JProperty p && fields.Contains(p.Name, StringComparer.CurrentCultureIgnoreCase))
                removeList.Add(p);

            el.ObfuscateFields(fields);
        }

        foreach (var el in removeList) el.Value = BusinessRuleConstants.ObfuscationStringSequence;

        return token;
    }

    public static bool TryParseJson<T>(
        this string item,
        out T result,
        MissingMemberHandling missingMemberHandling = MissingMemberHandling.Error)
        where T : class
    {
        var success = true;
        var settings = new JsonSerializerSettings
        {
            Error = (sender, args) =>
            {
                success = false;
                args.ErrorContext.Handled = true;
            },
            MissingMemberHandling = missingMemberHandling,
        };
        var parsedResult = JsonConvert.DeserializeObject<T>(item, settings);

        if (parsedResult == null) success = false;

        result = parsedResult ?? default!;
        return success;
    }

    public static bool TryParseJson<T>(
        this object? item,
        out T result,
        MissingMemberHandling missingMemberHandling = MissingMemberHandling.Error)
        where T : class
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

    public static bool CanParseJson<T>(this string item)
        where T : class
    {
        return item.TryParseJson(out T _);
    }

    public static T ParseJson<T>(
        this string item,
        MissingMemberHandling missingMemberHandling = MissingMemberHandling.Error)
        where T : class
    {
        return item.TryParseJson(out T jsonObject, missingMemberHandling)
            ? jsonObject
            : default!;
    }

    public static T ParseJson<T>(
        this object? item,
        MissingMemberHandling missingMemberHandling = MissingMemberHandling.Error)
        where T : class
    {
        var itemBuilder = new StringBuilder();
        itemBuilder.Append(item);

        return item as T ?? ParseJson<T>(itemBuilder.ToString(), missingMemberHandling);
    }

    public static bool IsValidJson(this string input)
    {
        input = input.Trim();

        // For object || For array
        if ((input.StartsWith('{') && input.EndsWith('}')) ||
            (input.StartsWith('[') && input.EndsWith(']')))
            try
            {
                _ = JToken.Parse(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        return false;
    }

    public class IgnorePropertiesResolver : DefaultContractResolver
    {
        private readonly IEnumerable<string> _propsToIgnore;

        public IgnorePropertiesResolver(IEnumerable<string> propNamesToIgnore)
        {
            _propsToIgnore = propNamesToIgnore;
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            property.ShouldSerialize = x => !_propsToIgnore.Contains(property.PropertyName);

            return property;
        }
    }
}