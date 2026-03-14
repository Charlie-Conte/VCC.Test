using MudBlazor.Services;
using System.Globalization;
using System.Text.Json;
using VCC.ProductPricing.Common;
using VCC.ProductPricing.Common.Json;
using VCC.ProductPricing.UI.Components;

namespace VCC.ProductPricing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // Add MudBlazor services
            builder.Services.AddMudServices();

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            builder.Services.AddScoped<HttpClient>();

            JsonSerializerOptions jsonOptions = new JsonSerializerOptions();
            jsonOptions.ApplyDefaultOptions();
            builder.Services.AddSingleton(jsonOptions);

            builder.Services.AddScoped<VccSnackbarService>();

            builder.AddSerilog();


            var app = builder.Build();


            var cultureInfo = new CultureInfo("en-GB");

            // the NumberFormat can now also be customized...
            // ...

            // set global CultureInfo 
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);

            app.UseHttpsRedirection();

            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
