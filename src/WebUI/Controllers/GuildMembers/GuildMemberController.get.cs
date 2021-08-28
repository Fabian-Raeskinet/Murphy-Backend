using System.Threading.Tasks;
using Application.Application.GuildMember.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.GuildMembers
{
    public partial class GuildMemberController
    {
        [HttpGet]
        [Route("guild-members")]
        public async Task<ActionResult> GetGuilds()
        {
            var query = new GetAllGuildMembersQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}