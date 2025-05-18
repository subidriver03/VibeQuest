using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VibeQuest;
using VibeQuest.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite("Data Source=vibequest.db"));


builder.Services.AddSingleton<TaskService>(); // This line registers your service

await builder.Build().RunAsync();
