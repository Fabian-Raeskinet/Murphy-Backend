using System;

namespace Domain.Models
{
    public class TextChannel
    {
        public string TextChannelId { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public bool IsNsfw { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CategoryChannelId { get; set; }
        public CategoryChannel CategoryChannel { get; set; }
        public string GuildId { get; set; }
        public Guild Guild { get; set; }
    }
}