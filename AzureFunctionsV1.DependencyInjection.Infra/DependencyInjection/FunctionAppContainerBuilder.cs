using Microsoft.Extensions.DependencyInjection;
using System;

namespace AzureFunctionsV1.DependencyInjection.Infra
{
    public class FunctionAppContainerBuilder : IFunctionAppContainerBuilder
    {
        private readonly IServiceCollection _services;

        public FunctionAppContainerBuilder() =>
         _services = new ServiceCollection();

        public IFunctionAppContainerBuilder Register(IFunctionAppStartup startup = null)
        {
            if (startup is null)
                return this;
            else
                startup.Configure(_services);

            return this;
        }

        public IServiceProvider Build() =>
            _services.BuildServiceProvider();
    }
}
