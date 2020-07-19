using Microsoft.Extensions.DependencyInjection;
using System;

namespace AzureFunctionsV1.DependencyInjection.Infrastructure
{
    internal class FunctionAppContainerBuilder
    {
        private readonly IServiceCollection _services;

        protected internal FunctionAppContainerBuilder() =>
         _services = new ServiceCollection();

        protected internal FunctionAppContainerBuilder Register(IFunctionAppStartup startup = null)
        {
            if (startup is null)
                return this;
            else
                startup.Configure(_services);

            return this;
        }

        protected internal IServiceProvider Build() =>
            _services.BuildServiceProvider();
    }
}
