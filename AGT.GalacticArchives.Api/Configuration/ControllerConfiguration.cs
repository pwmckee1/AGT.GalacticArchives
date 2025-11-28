using System.Text.Json.Serialization;
using AGT.GalacticArchives.Core.Attributes;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Application.Exceptions;
using AGT.GalacticArchives.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AGT.GalacticArchives.Configuration;

public static class ControllerConfiguration
{
    public static void AddControllers(IServiceCollection services)
    {
        services.AddControllers(options =>
            {
                options.Filters.Add<ModelStatePropertyValidationFilter>();
            })
            .ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressModelStateInvalidFilter = false;
                options.SuppressMapClientErrors = true;
                options.SuppressInferBindingSourcesForParameters = true;
                options.SuppressConsumesConstraintForFormFileParameters = true;
                options.InvalidModelStateResponseFactory = context =>
                {
                    var response = new MessageResponse<string>();
                    foreach (var (key, value) in context.ModelState)
                    {
                        foreach (var error in value.Errors)
                        {
                            response.Messages.Add($"{error.ErrorMessage}");
                        }
                    }

                    throw new HttpBadRequestException(string.Join(Environment.NewLine, response.Messages));
                };
            })
            .AddControllersAsServices()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                options.JsonSerializerOptions.Converters.Add(new DisplayAttributeEnumConverter());
            })
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.Converters.Add(new StringEnumConverter());
                options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
            });
    }
}