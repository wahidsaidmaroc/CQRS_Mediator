using MediatR;

namespace DemoCQRSMedi.Application.Features.Commande.Queries.GetDetail
{
    public class GetCommandeDetailQuery : IRequest<CommandeDetailDto>
    {
        //Argument
        public Guid CommandeId { get; set; }    
    }
}
