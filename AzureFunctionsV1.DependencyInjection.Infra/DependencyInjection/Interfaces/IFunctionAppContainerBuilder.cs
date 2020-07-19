namespace AzureFunctionsV1.DependencyInjection.Infra
{
    using System;

    public interface IFunctionAppContainerBuilder
    {
        IFunctionAppContainerBuilder Register(IFunctionAppStartup startup = null);

        IServiceProvider Build();
    }
}
