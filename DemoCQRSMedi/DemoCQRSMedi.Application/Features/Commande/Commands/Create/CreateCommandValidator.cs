using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCQRSMedi.Application.Features.Commande.Commands.Create
{
    public class CreateCommandValidator : AbstractValidator<CreateCommandeCommand>
    {
        public CreateCommandValidator() 
        {
            RuleFor(p => p.Date).NotEmpty().NotNull();
            RuleFor(p => p.IdClient).NotNull().NotNull();
            RuleFor(p => p.Montant).NotNull().NotEmpty();
        }
    }
}
