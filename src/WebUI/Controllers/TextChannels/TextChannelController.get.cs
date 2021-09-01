using System.Threading.Tasks;
using Application.Application.TextChannel.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.TextChannels
{
    public partial class TextChannelController
    {
        [HttpGet]
        [Route("text-channels")]
        public async Task<ActionResult> GetTextChannels()
        {
            var query = new GetAllTextChannelsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}