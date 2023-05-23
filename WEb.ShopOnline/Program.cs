using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WEb.ShopOnline;
using WEb.ShopOnline.Services;
using WEb.ShopOnline.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7254/") });//HttpClient is available as a preconfigured service for making requests back to the origin server.
builder.Services.AddScoped<IProductService, ProductService>();

await builder.Build().RunAsync();
