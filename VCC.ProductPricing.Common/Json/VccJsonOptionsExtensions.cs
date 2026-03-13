using System.Text.Json;
using System.Text.Json.Serialization;

namespace VCC.ProductPricing.Common.Json;

public static class VccJsonOptionsExtensions
{
    public static void ApplyDefaultOptions(this JsonSerializerOptions options)
    {
        options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        options.WriteIndented = true;
        options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    }
}
