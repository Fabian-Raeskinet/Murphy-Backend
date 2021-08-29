using System.Threading.Tasks;
using Application.Application.Role.Commands;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Roles
{
    public partial class RoleController
    {
        [HttpPost]
        [Route("roles")]
        public async Task<ActionResult> CreateRole([FromBody] CreateRoleCommand role)
        {
            var result = await _mediator.Send(role);
            return Ok(result);
        }
    }
}