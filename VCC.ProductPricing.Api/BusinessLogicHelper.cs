using VCC.ProductPricing.Common.Api;

namespace VCC.ProductPricing.Api;

public class BusinessLogicHelper : IBusinessLogicHelper
{
    public DiscountResponse? ApplyProductDiscount(int id, int discountPercentage)
    {
        var product = InMemoryDatabase.GetProductWithHistory(id);
        if (product == null) return null;

        var result = new DiscountResponse
        {
            Id = product.Id,
            Name = product.Name,
            OriginalPrice = product.Price,
            DiscountedPrice = product.Price * (100m - discountPercentage) / 100m
        };

        return result;
    }

    public UpdatePriceResponse? UpdatePriceResponse(int id, decimal newPrice)
    {
        var updatedProduct = InMemoryDatabase.UpdateProductPrice(id, newPrice);
        if (updatedProduct == null) return null;

        var result = new UpdatePriceResponse
        {
            Id = updatedProduct.Id,
            Name = updatedProduct.Name,
            LastUpdated = updatedProduct.LastUpdated,
            NewPrice = updatedProduct.Price
        };

        return result;
    }
}