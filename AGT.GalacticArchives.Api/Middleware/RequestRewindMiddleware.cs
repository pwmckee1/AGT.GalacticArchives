namespace AGT.GalacticArchives.Middleware;

public class RequestRewindMiddleware
{
    private readonly RequestDelegate _next;

    public RequestRewindMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        context.Request.EnableBuffering();

        using var stream = new StreamReader(context.Request.Body).ReadToEndAsync();
        context.Items["RequestBody"] = await stream;
        context.Request.Body.Position = 0;

        await _next(context);
    }
}