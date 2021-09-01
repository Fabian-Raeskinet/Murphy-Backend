using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.TextChannels
{
    [ApiController]
    [Route("api/")]
    public partial class TextChannelController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TextChannelController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}