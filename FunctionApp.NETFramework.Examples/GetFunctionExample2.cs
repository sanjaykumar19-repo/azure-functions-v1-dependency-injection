using AzureFunctionsV1.DependencyInjection.Infrastructure;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace AzureFunctionsV1.DependencyInjection.NETFramework.Examples
{
    public static class GetFunctionExample2
    {
        public static IServiceProvider serviceProvider
           = new CoreFunctionsStartupServices(new Startup()).Create();

        [FunctionName(nameof(GetFunctionExample2))]
        public static async Task<HttpResponseMessage> Run
                (
                [HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestMessage req,
                ILogger log
                )
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            var greeterServices = serviceProvider.GetService<IDummyServices>();
            var resp = await greeterServices.GetResponse();
            var data = JsonConvert.DeserializeObject<object>(await resp.Content?.ReadAsStringAsync());
            return req.CreateResponse(resp.StatusCode, data, mediaType: "application/json");
        }
    }
}
