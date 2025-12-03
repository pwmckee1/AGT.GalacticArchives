using System.Net.Mime;
using System.Text;
using AGT.GalacticArchives.Core.Attributes;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Serialization;
using AGT.GalacticArchives.Extensions;
using Microsoft.AspNetCore.Http.Features;
using Newtonsoft.Json;

namespace AGT.GalacticArchives.Middleware;

public class MessageResponseMiddleware(RequestDelegate next)
{
    private static readonly HashSet<string> ValidContentTypes =
    [
        MediaTypeNames.Application.Json,
    ];

    public static bool IsSanitizeBypass(HttpContext context)
    {
        // check for the attribute and to bypass the sanitization
        var endpoint = context.Features.Get<IEndpointFeature>()?.Endpoint;
        var attribute = endpoint?.Metadata.GetMetadata<BypassSanitizationAttribute>();
        return attribute != null;
    }

    public virtual string Sanitize(string? responseBody)
    {
        return responseBody!;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var originalResponseBody = context.Response.Body;
        await using var memoryStream = new MemoryStream();
        context.Response.Body = memoryStream;

        await next(context);

        string? contentType = context.Response.ContentType?.ToLower().Split(';', StringSplitOptions.RemoveEmptyEntries)
            .FirstOrDefault();

        using var streamReader = new StreamReader(context.Response.Body);

        // Read the body
        context.Response.Body.Seek(0, SeekOrigin.Begin);
        string? responseBody = await streamReader.ReadToEndAsync();

        // Avoid wrapping non-JSON responses or responses that already inherit from MessageResponse
        // Exclude swagger output
        if (ValidContentTypes.Contains(contentType!) &&
            !responseBody.CanParseJson<MessageResponse<object>>() &&
            !responseBody.CanParseJson<PagedResponse<object>>()
            && context.Request.Path.Value != null && !context.Request.Path.Value.Contains("swagger"))
        {
            // Wrap responseBody in MessageResponse
            object contentBody = JsonConvert.DeserializeObject(responseBody)!;
            responseBody = new MessageResponse<object> { Response = contentBody }.SerializeResponse();
        }

        // add whitelist check and other partial path items
        if (responseBody != null! && !responseBody.Contains("response\": null") && !IsSanitizeBypass(context))
        {
            responseBody = Sanitize(responseBody);
        }

        // Create a new stream with the modified body and reset the content length to match the new stream.
        using var responseContent = new StringContent(responseBody!, Encoding.UTF8, contentType!);
        context.Response.Body = await responseContent.ReadAsStreamAsync();
        context.Response.ContentLength = context.Response.Body.Length;

        // Write modified data to originalBodyStream and set it back as Response.Body value
        context.Response.Body.Seek(0, SeekOrigin.Begin);
        await context.Response.Body.CopyToAsync(originalResponseBody);
        context.Response.Body = originalResponseBody;
    }
}