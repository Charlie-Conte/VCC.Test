using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
namespace VCC.ProductPricing.Common;


public static class LoggingConfiguration
{
    public static IHostApplicationBuilder AddSerilog(this IHostApplicationBuilder builder)
    {
        var logPath = Path.Combine(AppContext.BaseDirectory, "log.txt");

        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Warning()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("System", LogEventLevel.Warning)
            .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .WriteTo.File(logPath)
            .ReadFrom.Configuration(builder.Configuration)
            .CreateLogger();

        builder.Services.AddSerilog();

        return builder;
    }
}