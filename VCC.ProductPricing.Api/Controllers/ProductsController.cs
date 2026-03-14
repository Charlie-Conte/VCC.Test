using Microsoft.AspNetCore.Mvc;
using VCC.ProductPricing.Api.Database;
using VCC.ProductPricing.Common.Api;
using VCC.ProductPricing.Common.Models;

namespace VCC.ProductPricing.Api.Controllers;

[Route("api/products")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IBusinessLogicHelper _businessLogicHelper;
    private readonly IProductDatabase _productDatabase;

    public ProductsController(IBusinessLogicHelper businessLogicHelper, IProductDatabase productDatabase)
    {
        _businessLogicHelper = businessLogicHelper;
        _productDatabase = productDatabase;
    }

    /// <summary>
    /// Retrieve a list of products with their current prices
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAllProducts()
    {
        var result = _productDatabase.GetProducts().ToArray();
        if (result.Length == 0) return NotFound("Nothing in database");
        return result;
    }

    /// <summary>
    /// Retrieve a product's price history.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public ActionResult<Product> GetProductWithHistory([FromRoute] int id)
    {
        var result = _productDatabase.GetProductWithHistory(id);
        if (result == null) return NotFound($"Could not find product with id {id}");
        return result;
    }

    /// <summary>
    /// Apply a discount to a product. The discount should be applied in percentage terms.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost("{id}/apply-discount")]
    public ActionResult<DiscountResponse> ApplyDiscount([FromRoute] int id, [FromBody] DiscountRequest request)
    {
        var result = _businessLogicHelper.ApplyProductDiscount(id, request.DiscountPercentage);
        if (result.Item1 == null)
        {
            if (!string.IsNullOrWhiteSpace(result.Item2))
            {
                ModelState.AddModelError(result.Item3, result.Item2);
                return ValidationProblem(ModelState);
            }
            return NotFound($"Could not find product with id {id}");
        }
        return result.Item1;
    }

    /// <summary>
    /// Update the price of a product.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPut("{id}/update-price")]
    public ActionResult<UpdatePriceResponse> UpdateProductPrice([FromRoute] int id, [FromBody] UpdatePriceRequest request)
    {
        var result = _businessLogicHelper.UpdatePrice(id, request.NewPrice);
        if (result.Item1 == null)
        {
            if (!string.IsNullOrWhiteSpace(result.Item2))
            {
                ModelState.AddModelError(result.Item3, result.Item2);
                return ValidationProblem(ModelState);
            }
            return NotFound($"Could not find product with id {id}");
        }
        return result.Item1;
    }

}