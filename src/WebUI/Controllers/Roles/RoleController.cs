using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Roles
{
    [ApiController]
    [Route("api/")]
    public partial class RoleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoleController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}