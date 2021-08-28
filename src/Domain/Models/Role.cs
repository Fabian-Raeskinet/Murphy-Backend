using System;

namespace Domain.Models
{
    public class Role
    {
        public string RoleId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Position { get; set; }
        public int MemberRoleCount { get; set; }
    }
}