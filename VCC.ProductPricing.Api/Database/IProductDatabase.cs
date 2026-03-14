using VCC.ProductPricing.Common.Models;

namespace VCC.ProductPricing.Api.Database;

public interface IProductDatabase
{
    public IQueryable<Product> GetProducts();

    /// <summary>
    /// Helper method that links the products and price histories together similar to entity framework
    /// </summary>
    /// <returns></returns>
    public IQueryable<Product> GetProductsWithHistories();

    public Product? GetProductWithHistory(int productId);
    public Product? UpdateProductPrice(int productId, decimal newPrice);
    public Product AddProduct(NewProduct product, int? customId);

}