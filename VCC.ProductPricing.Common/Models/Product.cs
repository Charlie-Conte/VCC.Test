using System.Text.Json.Serialization;

namespace VCC.ProductPricing.Common.Models;

public class Product : NewProduct
{
    public required int Id { get; init; }

    public required DateTime LastUpdated { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<PriceHistory>? PriceHistory { get; set; }
}