using Microsoft.Extensions.DependencyInjection;

namespace AzureFunctionsV1.DependencyInjection.Infra
{
    public interface IFunctionAppStartup
    {
        void Configure(IServiceCollection services);
    }
}
