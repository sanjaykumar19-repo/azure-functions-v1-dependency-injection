using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;

namespace AzureFunctionsV1.DependencyInjection.NETFramework.Examples
{
    internal class DummyServices : IDummyServices
    {
        private readonly HttpClient httpClient;
        private readonly IConfiguration configuration;
        public DummyServices(HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;
            this.configuration = configuration;
        }

        public async Task<HttpResponseMessage> GetResponse()
        {
            // parse query parameter
            var url = configuration["RequestGet"];
            return await httpClient.GetAsync(url);
        }
    }
}
