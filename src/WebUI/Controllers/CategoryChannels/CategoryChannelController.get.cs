using System.Threading.Tasks;
using Application.Application.CategoryChannel.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.CategoryChannels
{
    public partial class CategoryChannelController
    {
        [HttpGet]
        [Route("category-channels")]
        public async Task<ActionResult> GetCategoryChannels()
        {
            var query = new GetAllCategoryChannelsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}