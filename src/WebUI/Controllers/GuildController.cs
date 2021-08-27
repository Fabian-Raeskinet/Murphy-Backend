using System.Net;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("api/")]
    [ProducesResponseType(typeof(Guild),
        (int)HttpStatusCode.OK)]
    public partial class GuildController : ControllerBase
    {
        [HttpGet]
        [Route("guilds")]
        public async Task<ActionResult> GetGuilds()
        {
            var response = "coucou";
            return Ok(response);
        }
    }
}