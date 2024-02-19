using DemoCQRSMedi.Application.Contrats;
using DemoCQRSMedi.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DemoCQRSMedi.Persistence
{
    public static class PersistenceContainer
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection services)
        {
            services.AddScoped<ICommandeRepos , CommandeRepository>();
            services.AddScoped<IClientRepos, ClientRepository>();

            services.AddScoped(typeof(IAsyncRepos<>), typeof(GenericRepository<>));


            return services;
        }
    }
}
