using DemoCQRSMedi.Application.Contrats;
using DemoCQRSMedi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCQRSMedi.Persistence.Repositories
{
    public class ClientRepository :  GenericRepository<Client>, IClientRepos
    {
        public ClientRepository(LibraryDbContext dbContext) : base(dbContext)
        {

        }

        public Task<IReadOnlyList<Client>> GetAllAsync(bool inculdeCommande)
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetAsync(string id, bool inculdeCommande)
        {
            throw new NotImplementedException();
        }
    }
}
