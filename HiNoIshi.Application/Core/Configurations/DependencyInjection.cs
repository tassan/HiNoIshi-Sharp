using HiNoIshi.Application.Core.Registries;
using Microsoft.Extensions.DependencyInjection;

namespace HiNoIshi.Application.Core.Configurations
{
    public class DependencyInjection
    {
        public static void Load(IServiceCollection services)
        {
            InfraRegistry.Register(services);
            RepositoryRegistry.Register(services);
            ServiceRegistry.Register(services);
        }
    }
}