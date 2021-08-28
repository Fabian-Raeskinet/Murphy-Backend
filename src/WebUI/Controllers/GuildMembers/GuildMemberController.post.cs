using System.Threading.Tasks;
using Application.Application.GuildMember.Commands;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.GuildMembers
{
    public partial class GuildMemberController
    {
        [HttpPost]
        [Route("guild-members")]
        public async Task<ActionResult> CreateGuildMember([FromBody] CreateGuildMemberCommand guildMember)
        {
            var result = await _mediator.Send(guildMember);
            return Ok(result);
        }
    }
}