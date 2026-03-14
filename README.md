# Technical Test Assessment

Two web applications have been put together as per the requirements: a Swagger API and a Blazor UI page that is server-side hosted.

---

## Getting Started

To run the code you can either run it in debug within Visual Studio (or whichever IDE you prefer), or just compile it. All configurations are set up in the app settings to work out of the box, though you can override anything by tweaking the `appsettings.json` files manually. Default ports are set in the settings so cross-origin restrictions will be handled automatically. (Swagger UI and doc generation is only in debug)

---

## Projects

### API

For the products and products-by-ID endpoints the actual product reference held in memory is returned. For the other two endpoints request/response models are used with the specific inputs and outputs as designated by the specification.

Since in-memory data storage was required, everything is placed in a class called `InMemoryDatabase.cs`, which implements `IProductDatabase.cs`. It is registered as a singleton in the DI container, allowing for it to be hotswapped later into something like dapper or efCore (which is kinda how i designed the `InMemoryDatabase.cs`).

All the business logic sitting between the database and the API controller lives in the Business Logic helper. The logic within that helper is unit tested in the **VCC.ProductPricing.Api.Tests** project included, covering both happy path and edge cases such as invalid discount values and out-of-range price inputs.

---

### UI

The Blazor server-side application was written using MudBlazor as its styling and component library. Everything sits on the main page with no additional side pages. On load you'll see a data grid of all the records with three options per row:

| Action | Description |
|---|---|
| Apply Discount | Opens a validated form prompt to apply a discount to the product |
| Change Price | Opens a validated form prompt to update the product price |
| Show Timeline | Opens a drawer on the right-hand side showing the ordered history of previous prices |

There is also a **dark mode toggle** and a **reload button** in the navigation bar to reset the data.

#### Timeline

The timeline is treated as historical only — the current price is never included as the last entry. Only once a price is updated does it get added to the timeline, since it is no longer the active price. This was an intentional interpretation as the specification did not clarify whether the current price should be included. Also no idea why the spec had only date for the timeline as it prevents on any updates the same day.

#### Validation & Error Handling

Given the scope of the project, model validation errors from Api are surfaced via MudBlazor snackbars rather than wiring the full validation pipeline back through to the client. The user is prevented from inputting anything invalid at the form level, and any unexpected errors will also appear in the snackbar.

#### Data Grid Behaviour

- Applying a discount sends the request to the API, gets back the updated price, and reflects it dynamically in the grid.
- Changing a price after discounts have been applied will re-pull that item and clear the discounted price.
- Price changes automatically update both the data grid and the item's own timeline.

---

### Common Library

A common class library holds shared objects used across all projects:

- Product
- PriceHistory
- Discount and price change request/response models
- A logger initialiser usable across both applications — currently configured with Serilog using console and file sinks
- JSON serialisation options, centralised here to keep them consistent across all projects

---