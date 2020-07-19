using Microsoft.Extensions.DependencyInjection;

namespace AzureFunctionsV1.DependencyInjection.Infra
{
    public abstract class FunctionAppStartup : IFunctionAppStartup
    {
        public abstract void Configure(IServiceCollection services);
    }
}