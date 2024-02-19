using AutoMapper;
using DemoCQRSMedi.Application.Contrats;
using FluentValidation;
using MediatR;

namespace DemoCQRSMedi.Application.Features.Commande.Commands.Create
{
    public class CreateCommandeCommandHandler : IRequestHandler<CreateCommandeCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly ICommandeRepos _commandeRepos;

        public CreateCommandeCommandHandler(IMapper mapper, ICommandeRepos commandeRepos)
        {
            _mapper = mapper;
            _commandeRepos = commandeRepos;
        }
        public async Task<Guid> Handle(CreateCommandeCommand request, CancellationToken cancellationToken)
        {
            var commande = _mapper.Map<DemoCQRSMedi.Domain.Commande>(request);

            CreateCommandValidator v = new CreateCommandValidator();
            var resule = await v.ValidateAsync(request);
            if (resule.Errors.Any()) 
            {
                throw new Exception("Erreur au niveau Data");
            }

            commande = await _commandeRepos.AddAsync(commande);

            return commande.Id;
        }
    }
}
