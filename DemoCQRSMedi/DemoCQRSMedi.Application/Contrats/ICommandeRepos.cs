using DemoCQRSMedi.Domain;

namespace DemoCQRSMedi.Application.Contrats
{
    public interface ICommandeRepos : IAsyncRepos<Commande>
    {
        Task<IReadOnlyList<Commande>> GetAllAsync(bool inculdeCommande);
        Task<Commande> GetAsync(Guid id, bool inculdeCommande);
    }
}
