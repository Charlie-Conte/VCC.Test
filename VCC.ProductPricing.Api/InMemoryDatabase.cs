using VCC.ProductPricing.Common.Models;

namespace VCC.ProductPricing.Api;

public static class InMemoryDatabase
{
    private static List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "9ct Gold Diamond Engagement Ring", Price = 285.00m, LastUpdated = new DateTime(2024, 10, 14) },
        new Product { Id = 2, Name = "Victorian Silver Brooch with Cameo", Price = 74.99m, LastUpdated = new DateTime(2024, 9, 22) },
        new Product { Id = 3, Name = "WW2 Military Service Medal Set", Price = 145.00m, LastUpdated = new DateTime(2024, 11, 1) },
        new Product { Id = 4, Name = "Omega Seamaster Vintage Gents Watch", Price = 620.00m, LastUpdated = new DateTime(2024, 10, 7) },
        new Product { Id = 5, Name = "Victorian Sterling Silver Tea Set (3-piece)", Price = 340.00m, LastUpdated = new DateTime(2024, 8, 19) },
        new Product { Id = 6, Name = "Pre-Decimal British Coin Collection (85 coins)", Price = 110.00m, LastUpdated = new DateTime(2024, 9, 30) },
        new Product { Id = 7, Name = "Antique Leatherbound Charles Dickens First Edition", Price = 890.00m, LastUpdated = new DateTime(2024, 7, 25) },
        new Product { Id = 8, Name = "1960s Polaroid Land Camera Model 250", Price = 55.00m, LastUpdated = new DateTime(2024, 10, 18) },
        new Product { Id = 9, Name = "Gold 18ct Charm Bracelet with 12 Charms", Price = 410.00m, LastUpdated = new DateTime(2024, 11, 5) },
        new Product { Id = 10, Name = "Vintage Pelikan 100N Fountain Pen", Price = 88.00m, LastUpdated = new DateTime(2024, 6, 11) },
        new Product { Id = 11, Name = "Pre-War Steiff Teddy Bear (1930s)", Price = 320.00m, LastUpdated = new DateTime(2024, 9, 4) },
        new Product { Id = 12, Name = "WW1 Trench Art Lighter", Price = 65.00m, LastUpdated = new DateTime(2024, 8, 28) },
        new Product { Id = 13, Name = "Silver Plated Candelabra (pair)", Price = 95.00m, LastUpdated = new DateTime(2024, 7, 15) },
        new Product { Id = 14, Name = "Vintage Rolex Tudor Oyster Pocket Watch", Price = 1150.00m, LastUpdated = new DateTime(2024, 10, 29) },
        new Product { Id = 15, Name = "Gold Sovereign Coin 1912", Price = 480.00m, LastUpdated = new DateTime(2024, 9, 12) },
        new Product { Id = 16, Name = "Author-Signed Agatha Christie Novel", Price = 245.00m, LastUpdated = new DateTime(2024, 8, 6) },
        new Product { Id = 17, Name = "1970s Bakelite Rotary Telephone", Price = 42.00m, LastUpdated = new DateTime(2024, 7, 21) },
        new Product { Id = 18, Name = "Victorian Gold Locket with Hair Keepsake", Price = 175.00m, LastUpdated = new DateTime(2024, 10, 3) },
        new Product { Id = 19, Name = "WW2 German Military Binoculars", Price = 210.00m, LastUpdated = new DateTime(2024, 9, 17) },
        new Product { Id = 20, Name = "Victorian Silver Calling Card Case", Price = 58.00m, LastUpdated = new DateTime(2024, 6, 28) },
        new Product { Id = 21, Name = "1950s Hornby OO Gauge Train Set", Price = 135.00m, LastUpdated = new DateTime(2024, 8, 14) },
        new Product { Id = 22, Name = "Gold Cufflinks Hallmarked 9ct (Edwardian)", Price = 155.00m, LastUpdated = new DateTime(2024, 10, 22) },
        new Product { Id = 23, Name = "Antique Compass Brass Military Issue", Price = 78.00m, LastUpdated = new DateTime(2024, 7, 9) },
        new Product { Id = 24, Name = "Victorian Silver Sugar Tongs & Caddy Spoon Set", Price = 44.00m, LastUpdated = new DateTime(2024, 9, 25) },
        new Product { Id = 25, Name = "1980s Nintendo Game & Watch Handheld", Price = 98.00m, LastUpdated = new DateTime(2024, 8, 31) },
        new Product { Id = 26, Name = "Edwardian Sapphire & Pearl Brooch (silver)", Price = 220.00m, LastUpdated = new DateTime(2024, 10, 10) },
        new Product { Id = 27, Name = "Vintage Dunhill Gold-Plated Cigarette Case", Price = 115.00m, LastUpdated = new DateTime(2024, 7, 3) },
        new Product { Id = 28, Name = "Leica M3 Rangefinder Camera (1955)", Price = 740.00m, LastUpdated = new DateTime(2024, 11, 8) },
        new Product { Id = 29, Name = "Pre-1920 British Silver Coinage Collection", Price = 185.00m, LastUpdated = new DateTime(2024, 9, 6) },
        new Product { Id = 30, Name = "Vintage Bisque Porcelain Doll (1890s)", Price = 265.00m, LastUpdated = new DateTime(2024, 8, 22) },
        new Product { Id = 31, Name = "Silver Pocket Watch Full Hunter (1903)", Price = 195.00m, LastUpdated = new DateTime(2024, 10, 16) },
        new Product { Id = 32, Name = "Victorian Mourning Jet Pendant Necklace", Price = 82.00m, LastUpdated = new DateTime(2024, 6, 17) },
        new Product { Id = 33, Name = "WW1 Campaign Medal Trio with Ribbons", Price = 310.00m, LastUpdated = new DateTime(2024, 9, 11) },
        new Product { Id = 34, Name = "1960s Hornby Dublo Electric Train Set Boxed", Price = 160.00m, LastUpdated = new DateTime(2024, 7, 30) },
        new Product { Id = 35, Name = "Sterling Silver Napkin Ring Set (6)", Price = 68.00m, LastUpdated = new DateTime(2024, 10, 24) },
        new Product { Id = 36, Name = "Vintage Parker 51 Fountain Pen (Gold Fill)", Price = 145.00m, LastUpdated = new DateTime(2024, 8, 7) },
        new Product { Id = 37, Name = "Edwardian 18ct Gold Tie Pin with Seed Pearl", Price = 130.00m, LastUpdated = new DateTime(2024, 9, 20) },
        new Product { Id = 38, Name = "Antique Brass Sextant in Mahogany Case", Price = 285.00m, LastUpdated = new DateTime(2024, 11, 4) },
        new Product { Id = 39, Name = "1930s Wind-Up Tin Plate Car (Märklin)", Price = 395.00m, LastUpdated = new DateTime(2024, 7, 13) },
        new Product { Id = 40, Name = "Gold Half Sovereign Coin 1896", Price = 255.00m, LastUpdated = new DateTime(2024, 10, 28) },
        new Product { Id = 41, Name = "Victorian Silver Serving Tray (hallmarked)", Price = 175.00m, LastUpdated = new DateTime(2024, 8, 15) },
        new Product { Id = 42, Name = "WW2 RAF Pilot Wings Badge (silver)", Price = 88.00m, LastUpdated = new DateTime(2024, 6, 29) },
        new Product { Id = 43, Name = "1970s Kodak Instamatic 500 Camera", Price = 35.00m, LastUpdated = new DateTime(2024, 9, 8) },
        new Product { Id = 44, Name = "Edwardian Garnet & Gold Cluster Ring", Price = 210.00m, LastUpdated = new DateTime(2024, 10, 21) },
        new Product { Id = 45, Name = "Vintage DuPont Silver-Plated Lighter", Price = 92.00m, LastUpdated = new DateTime(2024, 7, 18) },
        new Product { Id = 46, Name = "Victorian Sovereign Case 9ct Gold", Price = 165.00m, LastUpdated = new DateTime(2024, 9, 26) },
        new Product { Id = 47, Name = "1940s Merrythought Cheeky Mohair Bear", Price = 275.00m, LastUpdated = new DateTime(2024, 8, 3) },
        new Product { Id = 48, Name = "Antique Inkwell Set with Silver Lid (pair)", Price = 120.00m, LastUpdated = new DateTime(2024, 10, 9) },
        new Product { Id = 49, Name = "WW2 Home Guard Officer's Swagger Stick", Price = 55.00m, LastUpdated = new DateTime(2024, 7, 27) },
        new Product { Id = 50, Name = "Victorian Gold & Enamel Mourning Brooch", Price = 195.00m, LastUpdated = new DateTime(2024, 11, 9) },
    };

    private static List<PriceHistory> _priceHistories = new List<PriceHistory>
    {
        new PriceHistory { ProductId = 1, Price = 320.00m, Date = new DateOnly(2024, 3, 5) },
        new PriceHistory { ProductId = 1, Price = 295.00m, Date = new DateOnly(2024, 7, 18) },
        new PriceHistory { ProductId = 1, Price = 295.00m, Date = new DateOnly(2024, 7, 20) },
        new PriceHistory { ProductId = 1, Price = 295.00m, Date = new DateOnly(2024, 7, 19) },
        new PriceHistory { ProductId = 1, Price = 295.00m, Date = new DateOnly(2024, 8, 17) },
        new PriceHistory { ProductId = 1, Price = 295.00m, Date = new DateOnly(2024, 10, 14) },
        new PriceHistory { ProductId = 1, Price = 295.00m, Date = new DateOnly(2025, 7, 2) },
        new PriceHistory { ProductId = 1, Price = 295.00m, Date = new DateOnly(2025, 8, 12) },
        new PriceHistory { ProductId = 2, Price = 89.99m, Date = new DateOnly(2024, 2, 14) },
        new PriceHistory { ProductId = 3, Price = 175.00m, Date = new DateOnly(2024, 1, 9) },
        new PriceHistory { ProductId = 3, Price = 160.00m, Date = new DateOnly(2024, 6, 3) },
        new PriceHistory { ProductId = 4, Price = 699.00m, Date = new DateOnly(2024, 2, 28) },
        new PriceHistory { ProductId = 4, Price = 650.00m, Date = new DateOnly(2024, 7, 11) },
        new PriceHistory { ProductId = 6, Price = 130.00m, Date = new DateOnly(2024, 4, 16) },
        new PriceHistory { ProductId = 7, Price = 975.00m, Date = new DateOnly(2024, 1, 20) },
        new PriceHistory { ProductId = 7, Price = 930.00m, Date = new DateOnly(2024, 5, 8) },
        new PriceHistory { ProductId = 9, Price = 460.00m, Date = new DateOnly(2024, 3, 22) },
        new PriceHistory { ProductId = 9, Price = 435.00m, Date = new DateOnly(2024, 8, 14) },
        new PriceHistory { ProductId = 10, Price = 105.00m, Date = new DateOnly(2024, 1, 30) },
        new PriceHistory { ProductId = 11, Price = 380.00m, Date = new DateOnly(2024, 2, 7) },
        new PriceHistory { ProductId = 11, Price = 350.00m, Date = new DateOnly(2024, 6, 19) },
        new PriceHistory { ProductId = 13, Price = 115.00m, Date = new DateOnly(2024, 3, 1) },
        new PriceHistory { ProductId = 14, Price = 1299.00m, Date = new DateOnly(2024, 1, 14) },
        new PriceHistory { ProductId = 14, Price = 1199.00m, Date = new DateOnly(2024, 6, 25) },
        new PriceHistory { ProductId = 16, Price = 290.00m, Date = new DateOnly(2024, 2, 19) },
        new PriceHistory { ProductId = 16, Price = 265.00m, Date = new DateOnly(2024, 5, 27) },
        new PriceHistory { ProductId = 17, Price = 55.00m, Date = new DateOnly(2024, 3, 11) },
        new PriceHistory { ProductId = 19, Price = 250.00m, Date = new DateOnly(2024, 4, 5) },
        new PriceHistory { ProductId = 19, Price = 230.00m, Date = new DateOnly(2024, 7, 29) },
        new PriceHistory { ProductId = 20, Price = 72.00m, Date = new DateOnly(2024, 1, 17) },
        new PriceHistory { ProductId = 22, Price = 185.00m, Date = new DateOnly(2024, 3, 28) },
        new PriceHistory { ProductId = 22, Price = 168.00m, Date = new DateOnly(2024, 7, 6) },
        new PriceHistory { ProductId = 23, Price = 95.00m, Date = new DateOnly(2024, 2, 23) },
        new PriceHistory { ProductId = 25, Price = 120.00m, Date = new DateOnly(2024, 4, 13) },
        new PriceHistory { ProductId = 25, Price = 108.00m, Date = new DateOnly(2024, 7, 20) },
        new PriceHistory { ProductId = 26, Price = 260.00m, Date = new DateOnly(2024, 2, 4) },
        new PriceHistory { ProductId = 26, Price = 238.00m, Date = new DateOnly(2024, 6, 17) },
        new PriceHistory { ProductId = 28, Price = 850.00m, Date = new DateOnly(2024, 1, 25) },
        new PriceHistory { ProductId = 28, Price = 795.00m, Date = new DateOnly(2024, 6, 10) },
        new PriceHistory { ProductId = 29, Price = 215.00m, Date = new DateOnly(2024, 3, 19) },
        new PriceHistory { ProductId = 31, Price = 235.00m, Date = new DateOnly(2024, 2, 10) },
        new PriceHistory { ProductId = 31, Price = 215.00m, Date = new DateOnly(2024, 6, 30) },
        new PriceHistory { ProductId = 32, Price = 99.00m, Date = new DateOnly(2024, 1, 6) },
        new PriceHistory { ProductId = 33, Price = 360.00m, Date = new DateOnly(2024, 3, 24) },
        new PriceHistory { ProductId = 33, Price = 335.00m, Date = new DateOnly(2024, 7, 2) },
        new PriceHistory { ProductId = 35, Price = 82.00m, Date = new DateOnly(2024, 4, 8) },
        new PriceHistory { ProductId = 36, Price = 170.00m, Date = new DateOnly(2024, 2, 15) },
        new PriceHistory { ProductId = 36, Price = 157.00m, Date = new DateOnly(2024, 6, 4) },
        new PriceHistory { ProductId = 38, Price = 330.00m, Date = new DateOnly(2024, 3, 30) },
        new PriceHistory { ProductId = 38, Price = 305.00m, Date = new DateOnly(2024, 8, 1) },
        new PriceHistory { ProductId = 39, Price = 445.00m, Date = new DateOnly(2024, 1, 22) },
        new PriceHistory { ProductId = 39, Price = 415.00m, Date = new DateOnly(2024, 5, 14) },
        new PriceHistory { ProductId = 41, Price = 205.00m, Date = new DateOnly(2024, 2, 26) },
        new PriceHistory { ProductId = 41, Price = 190.00m, Date = new DateOnly(2024, 6, 23) },
        new PriceHistory { ProductId = 42, Price = 108.00m, Date = new DateOnly(2024, 1, 12) },
        new PriceHistory { ProductId = 44, Price = 245.00m, Date = new DateOnly(2024, 3, 16) },
        new PriceHistory { ProductId = 44, Price = 225.00m, Date = new DateOnly(2024, 7, 24) },
        new PriceHistory { ProductId = 45, Price = 112.00m, Date = new DateOnly(2024, 2, 3) },
        new PriceHistory { ProductId = 47, Price = 315.00m, Date = new DateOnly(2024, 2, 21) },
        new PriceHistory { ProductId = 47, Price = 295.00m, Date = new DateOnly(2024, 6, 12) },
        new PriceHistory { ProductId = 48, Price = 145.00m, Date = new DateOnly(2024, 4, 28) },
        new PriceHistory { ProductId = 50, Price = 230.00m, Date = new DateOnly(2024, 3, 6) },
        new PriceHistory { ProductId = 50, Price = 212.00m, Date = new DateOnly(2024, 7, 31) },
    };
    public static IQueryable<Product> GetProducts() => _products.AsQueryable();

    /// <summary>
    /// Helper method that links the products and price histories together similar to entity framework
    /// </summary>
    /// <returns></returns>
    public static IQueryable<Product> GetProductsWithHistories()
    {
        var products = _products.ToList();
        var priceHistories = _priceHistories.ToList();

        foreach (var product in products)
        {
            var history = priceHistories.Where(ph => ph.ProductId == product.Id).ToList();
            product.PriceHistory = history.Count > 0 ? history : null;
        }

        return products.AsQueryable();
    }

    public static Product? GetProductWithHistory(int productId) =>
        GetProductsWithHistories().FirstOrDefault(p => p.Id == productId);

    public static Product? UpdateProductPrice(int productId, decimal newPrice)
    {
        var product = _products.FirstOrDefault(p => p.Id == productId);
        if(product == null) return null;


        _priceHistories.Add(new PriceHistory{ Date = DateOnly.FromDateTime(DateTime.Today), Price = product.Price, ProductId = productId});

        product.Price = newPrice;
        product.LastUpdated = DateTime.Now;

        return product;
    }


    public static Product AddProduct(NewProduct product, int? customId = null)
    {
        var lastId = _products.OrderByDescending(p => p.Id).FirstOrDefault()?.Id ?? 0;

        var productToAdd = new Product()
            { Id = customId ?? lastId + 1, LastUpdated = DateTime.Now, Price = product.Price, Name = product.Name };
        _products.Add(productToAdd);
        return productToAdd;
    }

}