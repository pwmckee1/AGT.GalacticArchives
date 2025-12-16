using Microsoft.AspNetCore.WebUtilities;

namespace AGT.GalacticArchives.Extensions;

public static class HttpContextExtensions
{
    public static string GetRequestParameters(this HttpContext httpContext, string parameterName)
    {
        var parameter = httpContext.Request.Headers[parameterName];
        if (parameter.Count == 0 && httpContext.Request.RouteValues.TryGetValue(parameterName, out object? value))
        {
            parameter = value?.ToString();
        }
        else if (!parameter.Any() && httpContext.Request.QueryString.HasValue)
        {
            var queryStringDictionary = QueryHelpers.ParseQuery(httpContext.Request.QueryString.Value);
            queryStringDictionary.TryGetValue(parameterName, out parameter);
        }

        return parameter!;
    }

    public static bool ContainsRoute(this PathString path, string route)
    {
        return path.HasValue && path.ToString().Contains(route);
    }
}