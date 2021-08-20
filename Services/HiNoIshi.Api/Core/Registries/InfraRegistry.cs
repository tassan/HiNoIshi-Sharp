using HiNoIshi.Domain.Interfaces;
using HiNoIshi.Infra.Context;
using HiNoIshi.Infra.Persistence;
using HiNoIshi.Infra.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace HiNoIshi.Api.Core.Registries
{
    public static class InfraRegistry
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IMongoContext, MongoContext>();
            MongoDbPersistence.Configure();
        }
    }
}