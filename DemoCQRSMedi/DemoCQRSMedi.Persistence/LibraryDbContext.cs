
using DemoCQRSMedi.Domain;
using Microsoft.EntityFrameworkCore;

namespace DemoCQRSMedi.Persistence
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }

        

    }
}
