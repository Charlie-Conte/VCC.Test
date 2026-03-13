using VCC.ProductPricing.Common.Api;

namespace VCC.ProductPricing.Api;

public interface IBusinessLogicHelper
{
    public (DiscountResponse?, string) ApplyProductDiscount(int id, int discountPercentage);
    public (UpdatePriceResponse?, string) UpdatePriceResponse(int id, decimal newPrice);
}