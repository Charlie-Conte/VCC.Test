using VCC.ProductPricing.Common.Api;

namespace VCC.ProductPricing.Api;

public interface IBusinessLogicHelper
{
    /// <summary>
    /// Apply a discount to the current product price
    /// </summary>
    /// <param name="id">product id</param>
    /// <param name="discountPercentage">whole number between 0-100</param>
    /// <returns>a response object, error message, error field</returns>
    public (DiscountResponse?, string, string) ApplyProductDiscount(int id, int discountPercentage);

    /// <summary>
    /// Update the price of a product
    /// </summary>
    /// <param name="id">product id</param>
    /// <param name="newPrice">new product price</param>
    /// <returns>a response object, error message, error field</returns>
    public (UpdatePriceResponse?, string, string) UpdatePrice(int id, decimal newPrice);
}