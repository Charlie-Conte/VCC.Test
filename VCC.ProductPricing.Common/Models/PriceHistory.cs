namespace VCC.ProductPricing.Common.Models;

public class PriceHistory
{
    public required int ProductId { get; set; }

    public required decimal Price { get; set; }

    public required DateOnly Date { get; set; }
}