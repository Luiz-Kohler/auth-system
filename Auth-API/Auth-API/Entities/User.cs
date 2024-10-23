﻿using Auth_API.Common;

namespace Auth_API.Entities
{
    public class User : IBaseEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public virtual int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public virtual IReadOnlyCollection<RoleUser> RoleUsers { get; set; }
    }
}
