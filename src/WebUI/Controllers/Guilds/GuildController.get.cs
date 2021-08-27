using System.Threading.Tasks;
using Application.Application.Guild.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Guilds
{
    public partial class GuildController
    {
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