using System.Threading.Tasks;
using Application.Application.User.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Users
{
    public partial class UserController
    {
        [HttpGet]
        [Route("users")]
        public async Task<ActionResult> GetGuilds()
        {
            var query = new GetAllUsersQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}