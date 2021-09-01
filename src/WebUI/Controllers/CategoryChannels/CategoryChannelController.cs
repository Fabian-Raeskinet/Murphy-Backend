using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.CategoryChannels
{
    [ApiController]
    [Route("api/")]
    public partial class CategoryChannelController: ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryChannelController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}