using HiNoIshi.Domain.Interfaces.Repositories;
using HiNoIshi.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HiNoIshi.Api.Core.Registries
{
    public static class RepositoryRegistry
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ICharacterRepository, CharacterRepository>();
        }
    }
}