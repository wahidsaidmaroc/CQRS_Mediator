using MediatR;
using ListCommande = DemoCQRSMedi.Application.Features.Commande.Queries.GetList;
using Microsoft.AspNetCore.Mvc;
using DemoCQRSMedi.Application.Features.Commande.Queries.GetList;

namespace DemoCQRSMedi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommandeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllClient")]
        public async Task<ActionResult<List<ListCommande.CommandeDto>>> GetAll()
        {
            var list = await _mediator.Send(new GetCommandeListQuery());
            return Ok(list);
        }

    }
}
