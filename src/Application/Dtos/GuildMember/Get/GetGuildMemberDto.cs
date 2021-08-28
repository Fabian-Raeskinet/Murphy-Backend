using System;

namespace Application.Dtos.GuildMember.Get
{
    public class GetGuildMemberDto
    {
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