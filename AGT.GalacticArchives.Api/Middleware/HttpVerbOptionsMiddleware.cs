using Ganss.Xss;

namespace AGT.GalacticArchives.Middleware;

#pragma warning disable CS9113 // Parameter is unread.
public class HttpVerbOptionsMiddleware(RequestDelegate next)
#pragma warning restore CS9113 // Parameter is unread.
{
    public async Task Invoke(HttpContext context)
    {
        var origin = context.Request.Headers.Origin;
        string? requestHeader = origin.Any() ? origin[0] : string.Empty;
        var sanitizer = new HtmlSanitizer();
        requestHeader = sanitizer.Sanitize(requestHeader!);
        context.Response.Headers.Append("Access-Control-Allow-Origin", new[] { requestHeader });
        context.Response.Headers.Append("X-Frame-Options", "DENY");

        if (context.Request.Method == "OPTIONS")
        {
            context.Response.Headers.Append(
                "Access-Control-Allow-Headers",
                new[]
                {
                    "Origin, X-Requested-With, Content-Type, Accept, Authorization, x-http-method-override, zbportal-long-polling",
                });
            context.Response.Headers.Append(
                "Access-Control-Allow-Methods",
                new[] { "GET, PATCH, POST, PUT, DELETE, OPTIONS" });
            context.Response.Headers.Append("Access-Control-Allow-Credentials", new[] { "true" });
            context.Response.StatusCode = 200;
            await context.Response.WriteAsync("OK");
        }
        else
        {
            context.Response.Headers.Append("Access-Control-Allow-Credentials", new[] { "true" });
            await next.Invoke(context);
        }
    }
}