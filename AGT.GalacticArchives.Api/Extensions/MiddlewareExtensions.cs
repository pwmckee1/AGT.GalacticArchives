using System.Net.Mime;
using System.Reflection;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Constants.Application;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Application.Exceptions;
using AGT.GalacticArchives.Core.Serialization;
using AGT.GalacticArchives.Middleware;
using Microsoft.AspNetCore.Http.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using NLog;
using ILogger = NLog.ILogger;
using LogLevel = NLog.LogLevel;

namespace AGT.GalacticArchives.Extensions;

public static class MiddlewareExtensions
{
    public static bool IsHealthCheckRequest(this HttpContext context)
    {
        return context.Request.Path.StartsWithSegments("/health-checks");
    }

    public static bool IsSwaggerRequest(this HttpContext context)
    {
        return context.Request.Path.StartsWithSegments("/index.html") ||
               context.Request.Path.StartsWithSegments("/swagger");
    }

    public static MiddlewareException HandleException(this HttpContext context, Exception exception, ILogger logger)
    {
        var userIdClaim = context.User.Claims.FirstOrDefault(c => c.Type == Claims.UserId);
        var logEvent = new LogEventInfo(LogLevel.Error, logger.Name, null, exception.Message, null, exception);
        var requestBody = context.Items["RequestBody"]?.ToString();

        var middlewareException = new ExceptionDetail(exception.Message, exception.StackTrace);
        if (exception is { InnerException: not null, Message.Length: > 0 })
        {
            middlewareException.InnerException = new ExceptionDetail(
                exception.InnerException.Message,
                exception.InnerException.StackTrace);
        }

        var errorDetail = new MiddlewareException(
            $"{context.Request.Method} {context.Request.GetDisplayUrl().Replace($"/{Assembly.GetExecutingAssembly().GetName().Name}", null)}",
            userIdClaim?.Value ?? string.Empty,
            RenderRequestBody(context.Request, requestBody),
            context.Request.Headers["User-Agent"],
            middlewareException);

        logEvent.Properties["detail"] = JsonConvert.SerializeObject(
            errorDetail,
            new JsonSerializerSettings { Formatting = Formatting.Indented });

        logger.Log(logEvent);

        return errorDetail;
    }

    public static string SerializeResponse<T>(this T response)
    {
        return JsonConvert.SerializeObject(
            response,
            new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented,
            });
    }

    public static IApplicationBuilder UseMessageResponseMiddleware(this IApplicationBuilder builder)
    {
        builder.UseWhen(
            httpContext => !httpContext.IsHealthCheckRequest() &&
                           !httpContext.IsSwaggerRequest() &&
                           BusinessRuleConstants.SanitizerRouteWhiteList.Any(r =>
                               httpContext.Request.Path.ContainsRoute(r)),
            app => app.UseMiddleware<MessageResponseMiddleware>());

        builder.UseWhen(
            httpContext => !httpContext.IsHealthCheckRequest() &&
                           !httpContext.IsSwaggerRequest() &&
                           BusinessRuleConstants.SanitizerRouteWhiteList.All(r =>
                               !httpContext.Request.Path.ContainsRoute(r)),
            app => app.UseMiddleware<SanitizedMessageResponseMiddleware>());

        return builder;
    }

    private static object? RenderRequestBody(HttpRequest request, string? requestBody)
    {
        if (string.IsNullOrEmpty(requestBody))
        {
            return null;
        }

        return request.ContentType == MediaTypeNames.Application.Json
            ? new JRaw(JToken.Parse(requestBody).ObfuscateFields(BusinessRuleConstants.ObfuscateFieldList))
            : requestBody;
    }
}