using System;

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
    }
}