using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Stores.WEB.Repositories;
using StoresG8.WEB;
using StoresG8.WEB.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<IRepository , Repository>();    

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7094/")


});

await builder.Build().RunAsync();
