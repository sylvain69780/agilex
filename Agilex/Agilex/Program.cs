using Agilex;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSingleton(provider => provider.GetRequiredService<IConfiguration>().Get<AppSettings>()!);
builder.Services.AddSingleton(new AppSettingsDemo()
{
    AgileValues =
    [
        new()
        {
            WordToGuess = "demo",
            InsteadOf = "Ne pas faire la demo !",
            Phrase ="Ceci est une demo !",
            Value = "Entrainez-vous à Agilex en mode DEMO"
        }
    ]
});
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
