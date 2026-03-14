using MudBlazor;
using System.Text.Json;

namespace VCC.ProductPricing;

public class VccSnackbarService(ISnackbar snackbar)
{
    private readonly Action<SnackbarOptions> _config = config =>
    {
        config.ShowCloseIcon = true;
        config.RequireInteraction = true;
        config.SnackbarVariant = Variant.Filled;
        config.DuplicatesBehavior = SnackbarDuplicatesBehavior.Prevent;
    };

    public void ShowError(string responseContent, string? reasonPhrase = null)
    {
        snackbar.Clear();
        snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopCenter;

        string message;
        try
        {
            var problem = JsonSerializer.Deserialize<JsonElement>(responseContent);
            message = problem.TryGetProperty("errors", out var errors)
                ? string.Join("\n", errors.EnumerateObject().SelectMany(e => e.Value.EnumerateArray().Select(v => v.GetString() ?? "")))
                : problem.TryGetProperty("title", out var title)
                    ? title.GetString() ?? responseContent
                    : responseContent;
        }
        catch
        {
            message = string.IsNullOrWhiteSpace(responseContent) ? reasonPhrase ?? "An error occurred" : responseContent;
        }

        snackbar.Add(message, Severity.Error, _config);
    }
}