using System.Net;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Guilds
{
    [ApiController]
    [Route("api/")]
    public partial class GuildController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GuildController(IMediator mediator)
        {
            _mediator = mediator;
        }

       
    }
}