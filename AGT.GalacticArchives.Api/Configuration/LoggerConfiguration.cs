using AGT.GalacticArchives.Core.Models.Application;
using NLog;
using NLog.Config;
using NLog.Extensions.Logging;
using LogLevel = NLog.LogLevel;
using Targets = NLog.Targets;

namespace AGT.GalacticArchives.Configuration;

public static class LoggerConfiguration
{
    public static void ConfigureNLog(WebApplicationBuilder builder)
    {
        var config = new LoggingConfiguration();

        var nlogConfig = builder.Configuration.GetSection($"{nameof(ApplicationSettings)}:{nameof(NLog)}");
        var targetsSection = nlogConfig.GetSection("targets");
        foreach (var target in targetsSection.GetChildren())
        {
            switch (target["type"]!)
            {
                case "File":
                    var fileTarget = new Targets.FileTarget
                    {
                        Name = target.Key,
                        FileName = target["fileName"]!,
                    };
                    config.AddTarget(fileTarget);
                    break;
                case "ColoredConsole":
                    var consoleTarget = new Targets.ColoredConsoleTarget
                    {
                        Name = target.Key,
                    };
                    config.AddTarget(consoleTarget);
                    break;
            }
        }

        var rulesSection = nlogConfig.GetSection("rules");
        if (rulesSection.Exists())
        {
            foreach (var rule in rulesSection.GetChildren())
            {
                string logger = rule["logger"] ?? "*";
                string writeTo = rule["writeTo"]!;
                var minLevel = LogLevel.FromString(rule["minLevel"]!);

                config.AddRule(minLevel, LogLevel.Fatal, writeTo, logger);
            }
        }

        LogManager.Configuration = config;

        builder.Services.AddLogging(cfg => { cfg.AddNLog(); });
    }
}