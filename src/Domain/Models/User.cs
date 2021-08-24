using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Tag { get; set; }
        public string Avatar { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsBot { get; set; }
        public List<GuildMember> GuildMembers { get; set; }
    }
}