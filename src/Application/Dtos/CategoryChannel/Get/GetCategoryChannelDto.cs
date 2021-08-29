using System;

namespace Application.Dtos.CategoryChannel.Get
{
    public class GetCategoryChannelDto
    {
        public string CategoryChannelId { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}