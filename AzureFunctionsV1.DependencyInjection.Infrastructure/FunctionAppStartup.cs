using Microsoft.Extensions.DependencyInjection;

namespace AzureFunctionsV1.DependencyInjection.Infrastructure
{
    /// <summary>
    /// Extend this class to use Dependency Injection and Implement services
    /// </summary>
    public abstract class FunctionAppStartup : IFunctionAppStartup
    {
        public abstract void Configure(IServiceCollection services);
    }
}