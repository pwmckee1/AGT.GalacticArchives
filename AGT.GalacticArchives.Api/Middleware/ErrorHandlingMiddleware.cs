using System.Net.Mime;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Application.Exceptions;
using AGT.GalacticArchives.Core.Models.AppSettings;
using AGT.GalacticArchives.Globalization;
using AGT.GalacticArchives.Extensions;
using Microsoft.AspNetCore.Diagnostics;
using NLog;
using LogLevel = NLog.LogLevel;

namespace AGT.GalacticArchives.Middleware;

    public class ErrorHandlingMiddleware
    {
        private static readonly NLog.ILogger Logger = LogManager.GetCurrentClassLogger();
        private readonly ApplicationSettings _applicationSettings;
        private readonly IHostEnvironment _hostEnvironment;

        // ReSharper disable once UnusedParameter.Local
        public ErrorHandlingMiddleware(
            ApplicationSettings applicationSettings,
            RequestDelegate next,
            IHostEnvironment hostEnvironment)
        {
            _applicationSettings = applicationSettings;
            _hostEnvironment = hostEnvironment;
        }

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
                    else if (ex.Error is HttpBadRequestException)
                    {
                        context.Response.StatusCode = (ex.Error as HttpBadRequestException)!.StatusCode;
                    }

                    var error = new MessageResponse<MiddlewareException>
                    {
                        Messages = new HashSet<object> { context.HandleException(ex.Error, Logger) },
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

        private MiddlewareException ObfuscateMiddlewareException(MiddlewareException middlewareException)
        {
            if (_hostEnvironment.IsProduction() || !_applicationSettings.EnableDeveloperErrors)
            {
                var isFriendlyError = middlewareException.ExceptionDetail?.InnerException == null;
                middlewareException.RequestBody = null;

                if (middlewareException.ExceptionDetail != null)
                {
                    middlewareException.ExceptionDetail.Message = isFriendlyError ? middlewareException.ExceptionDetail.Message : GeneralErrorResource.BasicError;
                    middlewareException.ExceptionDetail.StackTrace = null;
                    middlewareException.ExceptionDetail.InnerException = null;
                }
            }

            return middlewareException;
        }
    }