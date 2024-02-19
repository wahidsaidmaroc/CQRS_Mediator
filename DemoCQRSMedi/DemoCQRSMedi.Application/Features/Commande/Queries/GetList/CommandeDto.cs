namespace DemoCQRSMedi.Application.Features.Commande.Queries.GetList
{
    public class CommandeDto
    {
        public Guid Id { get; set; }
        public int Numero { get; set; } = 0;
        public double Montant { get; set; }
        public ClientDto Client { get; set; }
    }
}
