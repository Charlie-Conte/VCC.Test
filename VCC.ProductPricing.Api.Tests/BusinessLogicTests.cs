using VCC.ProductPricing.Api.Database;
using VCC.ProductPricing.Common.Models;

namespace VCC.ProductPricing.Api.Tests;

[TestFixture]
public class BusinessLogicTests
{
    private BusinessLogicHelper BusinessLogicHelper { get; set; } = null!;
    private const decimal DefaultPrice = 12.50m;

    [OneTimeSetUp]
    public void Setup()
    {
        var inMemoryDatabase = new InMemoryDatabase();
        BusinessLogicHelper = new BusinessLogicHelper(inMemoryDatabase);

        inMemoryDatabase.AddProduct(new NewProduct() { Name = "Test", Price = DefaultPrice }, 999);
    }

    [TestCase(10, ExpectedResult = 11.25)]
    [TestCase(20, ExpectedResult = 10)]
    [TestCase(50, ExpectedResult = 6.25)]
    [TestCase(80, ExpectedResult = 2.5)]
    [TestCase(90, ExpectedResult = 1.25)]
    public double AddDiscount_Success(int percent)
    {
        var result = BusinessLogicHelper.ApplyProductDiscount(999, percent);

        Assert.That(result.Item1, Is.Not.Null);
        Assert.That(result.Item1.OriginalPrice, Is.EqualTo(DefaultPrice));
        return Convert.ToDouble(result.Item1.DiscountedPrice);
    }

    [TestCase(-1)]
    [TestCase(0)]
    public void AddDiscount_BadId(int id)
    {
        var result = BusinessLogicHelper.ApplyProductDiscount(id, 10);

        Assert.That(result.Item1, Is.Null);
    }

    [TestCase(-1)]
    [TestCase(101)]
    [TestCase(999)]
    public void AddDiscount_BadDiscount(int percent)
    {
        var result = BusinessLogicHelper.ApplyProductDiscount(999, percent);

        Assert.That(result.Item1, Is.Null);
        Assert.That(result.Item2, Is.Not.Null);
        Assert.That(result.Item2, Is.Not.Empty);
    }

    [TestCase(10.00)]
    [TestCase(20.20)]
    [TestCase(50.50)]
    [TestCase(80.80)]
    [TestCase(90.90)]
    public void UpdatePrice_Success(decimal newPrice)
    {
        var startTime = DateTime.Now;
        var result = BusinessLogicHelper.UpdatePrice(999, newPrice);

        Assert.That(result.Item1, Is.Not.Null);
        Assert.That(result.Item1.NewPrice, Is.EqualTo(newPrice));
        Assert.That(result.Item1.LastUpdated, Is.GreaterThanOrEqualTo(startTime));
    }

    [TestCase(-1)]
    [TestCase(0)]
    public void UpdatePrice_BadId(int id)
    {
        var result = BusinessLogicHelper.UpdatePrice(id, 10);

        Assert.That(result.Item1, Is.Null);
    }

    [TestCase(-10.00)]
    [TestCase(-20.20)]
    [TestCase(-50.50)]
    [TestCase(-80.80)]
    [TestCase(-90.90)]
    public void UpdatePrice_BadPrice(decimal newPrice)
    {
        var result = BusinessLogicHelper.UpdatePrice(999, newPrice);

        Assert.That(result.Item1, Is.Null);
        Assert.That(result.Item2, Is.Not.Null);
        Assert.That(result.Item2, Is.Not.Empty);
    }
}