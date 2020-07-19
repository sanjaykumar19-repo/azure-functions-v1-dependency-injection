namespace AzureFunctionsV1.DependencyInjection.Infrastructure
{
    using System;

    public interface IFunctionAppContainerBuilder
    {
        IFunctionAppContainerBuilder Register(IFunctionAppStartup startup = null);

        IServiceProvider Build();
    }
}
