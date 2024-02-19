using AutoMapper;
using DemoCQRSMedi.Application.Contrats;
using MediatR;

namespace DemoCQRSMedi.Application.Features.Commande.Queries.GetList
{
    public class GetCommandeListQueryHandler : IRequestHandler<GetCommandeListQuery, List<CommandeDto>>
    {
        private readonly IMapper _mapper;
        private readonly ICommandeRepos _commandeRepos;

        public GetCommandeListQueryHandler(IMapper mapper, ICommandeRepos commandeRepos)
        {
            _mapper = mapper;
            _commandeRepos = commandeRepos;
        }

        public async Task<List<CommandeDto>> Handle(GetCommandeListQuery request, CancellationToken cancellationToken)
        {
            var listData = _commandeRepos.GetAllAsync(true);
            return _mapper.Map<List<CommandeDto>>(listData);
        }
    }
}
