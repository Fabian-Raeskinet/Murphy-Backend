using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.GuildMembers
{
    [ApiController]
    [Route("api/")]
    public partial class GuildMemberController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GuildMemberController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}