using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SmartPlantPot;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// --- NEUER CODE START ---

var apiUrl = builder.Configuration["ApiBaseUrl"];

if (string.IsNullOrEmpty(apiUrl))
{
    apiUrl = builder.HostEnvironment.BaseAddress;
}

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiUrl) });


builder.Services.AddSingleton<UserService>();

await builder.Build().RunAsync();