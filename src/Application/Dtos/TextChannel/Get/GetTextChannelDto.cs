using System;

namespace Application.Dtos.TextChannel.Get
{
    public class GetTextChannelDto
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public bool IsNsfw { get; set; }
        public string CategoryChannelId { get; set; }
    }
}