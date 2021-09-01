using System.Threading.Tasks;
using Application.Application.Seed.Commands;
using Application.Application.TextChannel.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Seeds
{
    [ApiController]
    [Route("api/")]
    public class SeedController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SeedController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpDelete]
        [Route("delete")]
        public async Task<ActionResult> GetTextChannels()
        {
            var query = new DeleteDataCommand();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}