using DemoCQRSMedi.Application.Contrats;
using DemoCQRSMedi.Domain;
using Microsoft.EntityFrameworkCore;

namespace DemoCQRSMedi.Persistence.Repositories
{
    public class CommandeRepository : GenericRepository<Commande>, ICommandeRepos
    {
        public CommandeRepository(LibraryDbContext dbContext) : base(dbContext)
        {
            
        }
        public async Task<IReadOnlyList<Commande>> GetAllAsync(bool inculdeCommande)
        {
            throw new NotImplementedException();

            //var list = inculdeCommande ?? await _dbContext.Commandes.Include(a => ) : await _dbContext.....
        }

        public Task<Commande> GetAsync(Guid id, bool inculdeCommande)
        {
            throw new NotImplementedException();
        }
    }
}
