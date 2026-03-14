using VCC.ProductPricing.Api.Database;
using VCC.ProductPricing.Common.Api;

namespace VCC.ProductPricing.Api;

public class BusinessLogicHelper : IBusinessLogicHelper
{
    private readonly IProductDatabase _productDatabase;

    public BusinessLogicHelper(IProductDatabase productDatabase)
    {
        _productDatabase = productDatabase;
    }

    public (DiscountResponse?, string, string) ApplyProductDiscount(int id, int discountPercentage)
    {
        if (discountPercentage > 100) return (null, "Discount cannot be greater than 100%", "discountPercentage");
        if (discountPercentage < 0) return (null, "Discount cannot be negative", "discountPercentage");

        var product = _productDatabase.GetProductWithHistory(id);
        if (product == null) return (null, string.Empty, string.Empty);

        var result = new DiscountResponse
        {
            Id = product.Id,
            Name = product.Name,
            OriginalPrice = product.Price,
            DiscountedPrice = product.Price * (100m - discountPercentage) / 100m
        };

        return (result, string.Empty, string.Empty);
    }

    public (UpdatePriceResponse?, string, string) UpdatePrice(int id, decimal newPrice)
    {
        if (newPrice < 0) return (null, "New Price cannot be less than 0", "newPrice");

        var updatedProduct = _productDatabase.UpdateProductPrice(id, newPrice);
        if (updatedProduct == null) return (null, string.Empty, string.Empty);

        var result = new UpdatePriceResponse
        {
            Id = updatedProduct.Id,
            Name = updatedProduct.Name,
            LastUpdated = updatedProduct.LastUpdated,
            NewPrice = updatedProduct.Price
        };

        return (result, string.Empty, string.Empty);
    }
}