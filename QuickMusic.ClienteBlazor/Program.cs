using QuickMusic.ClienteBlazor.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using MudBlazor.Extensions;

using System.Threading.Tasks;
namespace QuickMusic.ClienteBlazor
{

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.quickmusicsv.somee.com/api/") });

            builder.Services.AddScoped < IArtistaService, ArtistaService>();
            builder.Services.AddScoped<IGeneroService, GeneroService>();
            builder.Services.AddScoped<ICancionesService, CancionesService>();
            builder.Services.AddMudServices();

            await builder.Build().RunAsync();
        }
    }

  
    
}