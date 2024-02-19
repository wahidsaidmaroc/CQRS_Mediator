using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCQRSMedi.Application.Features.Commande.Commands.Create
{
    public class CreateCommandeCommand : IRequest<Guid>
    {
        public DateTime Date { get; set; }
        public double Montant { get; set; }
        public Guid IdClient { get; set; }

    }
}
