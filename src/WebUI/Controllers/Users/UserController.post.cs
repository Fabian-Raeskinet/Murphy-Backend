using System.Threading.Tasks;
using Application.Application.User.Commands;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Users
{
    public partial class UserController
    {
        [HttpPost]
        [Route("users")]
        public async Task<ActionResult> CreateUser([FromBody] CreateUserCommand user)
        {
            var result = await _mediator.Send(user);
            return Ok(result);
        }
    }
}