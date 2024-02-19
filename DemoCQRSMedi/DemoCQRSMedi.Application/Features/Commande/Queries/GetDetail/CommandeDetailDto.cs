namespace DemoCQRSMedi.Application.Features.Commande.Queries.GetDetail
{
    public class CommandeDetailDto
    {
        public Guid Id { get; set; }
        public int Numero { get; set; } = 0;
        public double Montant { get; set; }
        public ClientDto Client { get; set; }
    }
}
