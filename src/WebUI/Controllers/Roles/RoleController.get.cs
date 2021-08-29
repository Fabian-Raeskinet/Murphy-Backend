using System.Threading.Tasks;
using Application.Application.Role.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Roles
{
    public partial class RoleController
    {
        [HttpGet]
        [Route("roles")]
        public async Task<ActionResult> GetRoles()
        {
            var query = new GetAllRolesQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}