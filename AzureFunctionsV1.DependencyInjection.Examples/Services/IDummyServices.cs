using System.Net.Http;
using System.Threading.Tasks;

namespace AzureFunctionsV1.DependencyInjection.Examples
{
    internal interface IDummyServices
    {
        Task<HttpResponseMessage> GetResponse();
    }
}
