using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlazorFrontend;
using MyBlazorFrontend.Models;
using MyBlazorFrontend.Services;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register the HTTP client
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:5110/") // Your backend URL
});

// Register other services
builder.Services.AddSingleton<SummarizeService>(); // Add SummarizerService

// Register UserState
builder.Services.AddScoped<UserState>();

await builder.Build().RunAsync();
