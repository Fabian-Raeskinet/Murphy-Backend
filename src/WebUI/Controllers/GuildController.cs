using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("api/")]
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