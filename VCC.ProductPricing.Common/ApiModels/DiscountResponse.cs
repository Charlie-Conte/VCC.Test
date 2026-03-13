namespace VCC.ProductPricing.Common.Api;

public class DiscountResponse
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required decimal OriginalPrice { get; set; }
    public required decimal DiscountedPrice { get; set; }
}