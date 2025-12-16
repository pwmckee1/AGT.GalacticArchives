using System.Net.Mime;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Application.Exceptions;
using AGT.GalacticArchives.Extensions;
using AGT.GalacticArchives.Globalization;
using Microsoft.AspNetCore.Diagnostics;
using NLog;
using LogLevel = NLog.LogLevel;

namespace AGT.GalacticArchives.Middleware;

#pragma warning disable CS9113 // Parameter is unread.
public class ErrorHandlingMiddleware(RequestDelegate next)
#pragma warning restore CS9113 // Parameter is unread.
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    public async Task Invoke(HttpContext context)
    {
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Response.ContentType = MediaTypeNames.Application.Json;
        var ex = context.Features.Get<IExceptionHandlerFeature>();
        if (ex != null)
        {
            try
            {
                var exceptionType = ex.Error.GetType();
                if (ex.Error.Message == GeneralErrorResource.InvalidLogin ||
                    exceptionType == typeof(AuthenticationValidationException))
                {
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                }
                else if (ex.Error is HttpBadRequestException exception)
                {
                    context.Response.StatusCode = exception.StatusCode;
                }

                var error = new MessageResponse<MiddlewareException>
                {
                    Messages = [context.HandleException(ex.Error, Logger)],
                };

                await context.Response.WriteAsync(error.SerializeResponse()).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                Logger.Log(LogLevel.Error, ex);
                Logger.Log(LogLevel.Fatal, e);
            }
        }
    }
}