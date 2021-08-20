using System;
using HiNoIshi.Application.Core.Configurations;
using Microsoft.Extensions.DependencyInjection;

namespace HiNoIshi.Application.Core.Extensions
{
    public static class ServiceProviderExtensions
    {
        /// <summary>
        /// Load all Registries in Dependency Injection
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureDependencyInjection(this IServiceCollection services) =>
            DependencyInjection.Load(services);
        
        
    }
}