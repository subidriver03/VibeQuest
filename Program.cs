using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VibeQuest;
using VibeQuest.Services; // Add this if missing

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddSingleton<TaskService>(); // This line registers your service

await builder.Build().RunAsync();
