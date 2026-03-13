namespace VCC.ProductPricing.Common.Api;

public class UpdatePriceResponse
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required decimal NewPrice { get; set; }
    public required DateTime LastUpdated { get; set; }
}