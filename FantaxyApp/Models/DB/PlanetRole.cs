using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class PlanetRole
    {
        public PlanetRole()
        {
            PlanetProfileRoles = new HashSet<PlanetProfileRole>();
        }

        public int IdRole { get; set; }
        public string? Role { get; set; }

        public virtual ICollection<PlanetProfileRole> PlanetProfileRoles { get; set; }
    }
}
