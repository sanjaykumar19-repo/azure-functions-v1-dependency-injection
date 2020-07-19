using System.Net.Http;
using System.Threading.Tasks;

namespace AzureFunctionsV1.DependencyInjection.NETFramework.Examples
{
    internal interface IDummyServices
    {
        Task<HttpResponseMessage> GetResponse();
    }
}
