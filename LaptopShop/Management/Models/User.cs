﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Management.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }
        public string RoleName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }

        public virtual Role Role { get; set; }
    }
}
