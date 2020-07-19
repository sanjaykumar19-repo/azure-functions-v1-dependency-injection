using Microsoft.Extensions.DependencyInjection;

namespace AzureFunctionsV1.DependencyInjection.Infrastructure
{
    public interface IFunctionAppStartup
    {
        void Configure(IServiceCollection services);
    }
}
