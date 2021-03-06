using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class CategoryChannel
    {
        public string CategoryChannelId { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public DateTime CreatedAt { get; set; }
        public string GuildId { get; set; }
        public Guild Guild { get; set; }
        public List<TextChannel> TextChannels { get; set; }
    }
}