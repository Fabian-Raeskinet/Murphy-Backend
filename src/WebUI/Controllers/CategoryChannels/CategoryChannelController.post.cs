using System.Threading.Tasks;
using Application.Application.CategoryChannel.Commands;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.CategoryChannels
{
    public partial class CategoryChannelController
    {
        [HttpPost]
        [Route("category-channels")]
        public async Task<ActionResult> CreateCategoryChannel([FromBody] CreateCategoryChannelCommand categoryChannel)
        {
            var result = await _mediator.Send(categoryChannel);
            return Ok(result);
        }
    }
}