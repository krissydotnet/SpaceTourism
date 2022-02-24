using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SpaceTourism;
using SpaceTourism.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICrewDataService, CrewDataService>();
builder.Services.AddScoped<IDestinationDataService, DestinationDataService>();
builder.Services.AddScoped<ITerminologyDataService, TerminologyDataService>();


await builder.Build().RunAsync();
