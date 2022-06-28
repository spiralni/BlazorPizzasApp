using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PizzaPlaceWebAssembly.Client;
using PizzaPlaceWebAssembly.Shared.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<IMenuService, MenuService>();
builder.Services.AddTransient<IOrderService, ConsoleOrderService>();

await builder.Build().RunAsync();
