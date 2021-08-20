namespace HiNoIshi.Domain.Shared.Core.Registries
{
    public static class RepositoryRegistry
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ICharacterRepository, CharacterRepository>();
        }
    }
}