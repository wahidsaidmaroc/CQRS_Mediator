using AutoMapper;
using DemoCQRSMedi.Application.Contrats;
using MediatR;

namespace DemoCQRSMedi.Application.Features.Commande.Queries.GetDetail
{
    public class GetCommandeDetailQueryHandler : IRequestHandler<GetCommandeDetailQuery, CommandeDetailDto>
    {
        private readonly IMapper _mapper;
        private readonly ICommandeRepos _commandeRepos;

        public GetCommandeDetailQueryHandler(IMapper mapper, ICommandeRepos commandeRepos)
        {
            _mapper = mapper;
            _commandeRepos = commandeRepos;
        }
        public async Task<CommandeDetailDto> Handle(GetCommandeDetailQuery request, CancellationToken cancellationToken)
        {
            var data = _commandeRepos.GetAsync(request.CommandeId, true);
            return _mapper.Map<CommandeDetailDto>(data);
        }
    }
}
