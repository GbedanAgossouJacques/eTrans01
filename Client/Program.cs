using eTrans.Client.Services.ServicesChauffeur;
using eTrans.Client.Services.ServicesClient;
using eTrans.Client.Services.ServicesTranssport;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace eTrans.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IClientService, ClientService>();
            builder.Services.AddScoped<IChauffeurService, ChauffeurService>();
            builder.Services.AddScoped<ITransportService, TransportService>();

            await builder.Build().RunAsync();
        }
    }
}
