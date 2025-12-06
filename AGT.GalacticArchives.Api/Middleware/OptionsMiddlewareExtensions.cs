namespace AGT.GalacticArchives.Middleware;

public static class OptionsMiddlewareExtensions
{
    extension(IApplicationBuilder builder)
    {
        public IApplicationBuilder UseOptions()
        {
            return builder.UseMiddleware<HttpVerbOptionsMiddleware>();
        }
    }
}