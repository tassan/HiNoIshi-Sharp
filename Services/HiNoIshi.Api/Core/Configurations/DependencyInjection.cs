using HiNoIshi.Api.Core.Registries;
using Microsoft.Extensions.DependencyInjection;

namespace HiNoIshi.Api.Core.Configurations
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