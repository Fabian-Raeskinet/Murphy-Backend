using System.Threading.Tasks;
using Application.Application.Guild.Commands;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Guilds
{
    public partial class GuildController
    {
        [HttpPost]
        [Route("guilds")]
        public async Task<ActionResult> CreateGuild([FromBody] CreateGuildCommand guild)
        {
            var result = await _mediator.Send(guild);
            return Ok(result);
        }
    }
}