using System;

namespace AzureFunctionsV1.DependencyInjection.Infrastructure
{
    public interface IFunctionsStartupServices
    {
        IServiceProvider Create();
    }
}
