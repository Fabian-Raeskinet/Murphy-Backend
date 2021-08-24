using System;

namespace Domain.Models
{
    public class GuildMember
    {
        public string GuildMemberId { get; set; }
        public string UserId { get; set; }
        public string GuildId { get; set; }
        public string Nickname { get; set; }
        public DateTime JoinedAt { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsBanned { get; set; }
        public bool IsKicked { get; set; }
    }
}