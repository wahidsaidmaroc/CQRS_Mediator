using MediatR;

namespace DemoCQRSMedi.Application.Features.Commande.Queries.GetList
{
    public class GetCommandeListQuery : IRequest<List<CommandeDto>>
    {
    }
}
