using _01_Lerlings_Aufgabe;
using _01_Lerlings_Aufgabe.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DevExpress.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSingleton<TodoService>();
builder.Services.AddSingleton<TostPrebuildPorvider>();
builder.Services.AddSingleton<CalcService>();
builder.Services.AddSingleton<MovieByStudioProvider>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddDevExpressBlazor();
await builder.Build().RunAsync();
