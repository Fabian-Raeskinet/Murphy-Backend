using System;

namespace Domain.Models
{
    public class Guild
    {
        public string GuildId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Banner { set; get; }
        public string Description { get; set; }
        public string OwnerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsAvailable { get; set; }
        public string AfkChannelId { get; set; }
        public int MemberCount { get; set; }
    }
}