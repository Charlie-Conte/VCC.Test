namespace VCC.ProductPricing.Common.Api;

public record ValidationProblemDetails(
    string? Title,
    int? Status,
    Dictionary<string, string[]>? Errors
);