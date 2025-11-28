using Ganss.Xss;

namespace AGT.GalacticArchives.Middleware;

public class SanitizedMessageResponseMiddleware : MessageResponseMiddleware
{
    public SanitizedMessageResponseMiddleware(RequestDelegate next)
        : base(next)
    {
    }

    public override string Sanitize(string? responseBody)
    {
        var sanitizer = new HtmlSanitizer();
        sanitizer.AllowedAttributes.Clear();
        sanitizer.AllowedAttributes.Add("class");
        return sanitizer.Sanitize(responseBody ?? string.Empty);
    }
}