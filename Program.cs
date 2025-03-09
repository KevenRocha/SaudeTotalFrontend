using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SaudeTotalFrontend;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configurar HttpClient para se comunicar com o backend
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5217") });

await builder.Build().RunAsync();