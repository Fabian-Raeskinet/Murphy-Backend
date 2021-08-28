using System;

namespace Application.Dtos.User.Get
{
    public class GetUserDto
    {
        public string Username { get; set; }
        public string Tag { get; set; }
        public string Avatar { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsBot { get; set; }
    }
}