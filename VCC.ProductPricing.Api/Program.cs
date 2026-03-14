using VCC.ProductPricing.Common;
using VCC.ProductPricing.Common.Json;

namespace VCC.ProductPricing.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ApplyDefaultOptions();
        });

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<IBusinessLogicHelper, BusinessLogicHelper>();

        builder.AddSerilog();

        var origins = builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("UI", policy =>
            {
                policy.WithOrigins(origins!)
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseCors("UI");
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}