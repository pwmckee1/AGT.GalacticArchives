namespace AGT.GalacticArchives.Middleware;

public static class OptionsMiddlewareExtensions
{
    public static IApplicationBuilder UseOptions(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<HttpVerbOptionsMiddleware>();
    }
}