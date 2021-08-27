using System.Net;
using System.Threading.Tasks;
using Application.Application.Guild.Queries;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("api/")]
    [ProducesResponseType(typeof(Guild),
        (int)HttpStatusCode.OK)]
    public partial class GuildController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GuildController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("guilds")]
        public async Task<ActionResult> GetGuilds()
        {
            var query = new GetAllGuildsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}