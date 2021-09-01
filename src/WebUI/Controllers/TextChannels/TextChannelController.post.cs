using System.Threading.Tasks;
using Application.Application.TextChannel.Commands;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.TextChannels
{
    public partial class TextChannelController
    {
        [HttpPost]
        [Route("text-channels")]
        public async Task<ActionResult> CreateTextChannel([FromBody] CreateTextChannelCommand textChannel)
        {
            var result = await _mediator.Send(textChannel);
            return Ok(result);
        }
    }
}