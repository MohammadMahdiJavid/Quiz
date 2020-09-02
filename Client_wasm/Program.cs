using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.Authorization;
using Console_shared;
using Tewr.Blazor.FileReader;
using Blazor.Extensions.Storage;
using BlazorBrowserStorage;
using Client_wasm.Components;
using Microsoft.JSInterop;

namespace Client_wasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, UserModel>();
            /* Cookies */
            // builder.Services.AddStorage();
            // builder.Services.AddSingleton<LocalStorage>();
            builder.Services.AddSingleton<UserModel>();
            builder.Services.AddBlazorBrowserStorage();
            /* Cookies */

            /* IMAGE */
            builder.Services.AddFileReaderService(options => options.UseWasmSharedBuffer = true);
            /* IMAGE */

            builder.Services.AddSingleton<QuizzModel>();



            builder.RootComponents.Add<App>("app");
            // builder.RootComponents.Add<AuthorizationUser>("Auth");

            // Task t = Task.Run(() => builder.Services.AddSingleton<UserModel>(provider => provider.GetService<LocalStorage>().GetItem<UserModel>("token").Result));
            builder.Services.AddSingleton<UserModel>();


            await builder.Build().RunAsync();
        }
    }
}
