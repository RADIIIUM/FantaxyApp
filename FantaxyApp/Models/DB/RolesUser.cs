using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class RolesUser
    {
        public int IdRp { get; set; }
        public string? UserLogin { get; set; }
        public int? IdRole { get; set; }

        public virtual Role? IdRoleNavigation { get; set; }
        public virtual User? UserLoginNavigation { get; set; }
    }
}
