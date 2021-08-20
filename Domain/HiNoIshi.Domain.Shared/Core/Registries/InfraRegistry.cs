using Microsoft.Extensions.DependencyInjection;

namespace HiNoIshi.Domain.Shared.Core.Registries
{
    public static class InfraRegistry
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IMongoContext, MongoContext>();
            MongoDbPersistence.Configure();
        }
    }
}