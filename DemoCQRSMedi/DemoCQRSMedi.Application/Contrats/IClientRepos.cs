
using DemoCQRSMedi.Domain;

namespace DemoCQRSMedi.Application.Contrats
{
    public interface IClientRepos : IAsyncRepos<Client>
    {
        Task<IReadOnlyList<Client>> GetAllAsync(bool inculdeCommande);
        Task<Client> GetAsync(string id, bool inculdeCommande);
    }
}
