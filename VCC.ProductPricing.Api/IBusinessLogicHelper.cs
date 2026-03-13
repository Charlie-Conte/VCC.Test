using VCC.ProductPricing.Common.Api;

namespace VCC.ProductPricing.Api;

public interface IBusinessLogicHelper
{
    public DiscountResponse? ApplyProductDiscount(int id, int discountPercentage);
    public UpdatePriceResponse? UpdatePriceResponse(int id, decimal newPrice);
}