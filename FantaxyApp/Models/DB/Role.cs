using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class Role
    {
        public Role()
        {
            RolesUsers = new HashSet<RolesUser>();
        }

        public int IdRole { get; set; }
        public string RoleName { get; set; } = null!;

        public virtual ICollection<RolesUser> RolesUsers { get; set; }
    }
}
