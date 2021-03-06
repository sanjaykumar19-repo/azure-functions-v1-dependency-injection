﻿using System;

namespace AzureFunctionsV1.DependencyInjection.Infrastructure
{
    public class CoreFunctionsStartupServices : IFunctionsStartupServices
    {
        private readonly IServiceProvider _container;
        private CoreFunctionsStartupServices() { }

        public CoreFunctionsStartupServices(FunctionAppStartup startup = null)
        {
            this._container = new FunctionAppContainerBuilder().Register(startup).Build();
        }

        /// <summary>
        /// Instanciate Services for FunctionAppStartup
        /// </summary>
        /// <returns>IServiceProvider</returns>
        public IServiceProvider Create()
        {
            // Resolve the function instance directly from the container.
            return this._container;
        }
    }
}
