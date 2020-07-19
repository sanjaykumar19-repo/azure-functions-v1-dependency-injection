using System;

namespace AzureFunctionsV1.DependencyInjection.Infra
{
    public interface IFunctionsStartupServices
    {
        IServiceProvider Create();
    }
}
