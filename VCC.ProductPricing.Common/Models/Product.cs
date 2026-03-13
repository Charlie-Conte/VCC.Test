using System.Text.Json.Serialization;

namespace VCC.ProductPricing.Common.Models;

public class Product
{
    public required int Id { get; init; }

    public required string Name { get; set; }

    public required decimal Price { get; set; }

    public required DateTime LastUpdated { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<PriceHistory>? PriceHistory { get; set; }
}