using AzureFunctionsV1.DependencyInjection.Infra;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace AzureFunctionsV1.DependencyInjection.NETFramework.Examples
{
    public class Startup : FunctionAppStartup
    {
        public override void Configure(IServiceCollection services)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables().Build();
            // services.AddLogging();
            services.AddSingleton<ILogger>(
                log => new LoggerFactory()
                .AddConsole()
                .AddDebug()
                .AddEventLog()
                .CreateLogger<Startup>()
            );

            services.AddSingleton(config);
            var getUrl = config["GetBaseUrl"];
            services.AddSingleton<HttpClient>(client => new HttpClient()
            {
                BaseAddress = new System.Uri(getUrl)
            });

            services.AddTransient<IDummyServices, DummyServices>();
        }
    }
}
